using System;
using WebShoppie.Api.Contracts;
using WebShoppie.Domain.Services.Interfaces;
using WebShoppie.Storage;
using WebShoppie.Storage.DataModel;

namespace WebShoppie.Domain.Services.Implementations;

public class CustomerService(ICustomerRepository customerRepository) : ICustomerService
{
    
    public CustomerResponseContract CreateCustomer(
        CustomerRequestContract customerToCreate)
    {
        var dataModel = new CustomerDataModel
        {
            CreationDateTime = DateTime.UtcNow,
            FirstName = customerToCreate.FirstName,
            LastName = customerToCreate.LastName,
            DateOfBirth = customerToCreate.DateOfBirth,
            Email = customerToCreate.Email,
            Addresslinel = customerToCreate.Addressline1,
            Addressline2 = customerToCreate.Addressline2,
            Addressline3 = customerToCreate.Addressline3,
            Country = customerToCreate.Country,
        
        };

    var createInDb = customerRepository.Create(dataModel);

    return new CustomerResponseContract
    {
        Id = createInDb.Id,
        FirstName = createInDb.FirstName,
        LastName = createInDb.LastName,
        Email = createInDb.Email,
        DateOfBirth = createInDb.DateOfBirth!.Value,
        Addressline = createInDb.Addresslinel
+ " " + createInDb.Addressline2
+ " " + createInDb.Addressline3
+ " " + createInDb.Country

    };
 


    }

    public CustomerResponseContract? GetById(int customerId)
    {
        var dbResult = customerRepository.GetById(customerId);

        if (dbResult is not null)
        {
            return new CustomerResponseContract
            {
                Id = dbResult.Id,
                FirstName = dbResult.FirstName,
                LastName = dbResult.LastName,
                Email = dbResult.Email,
                DateOfBirth = dbResult.DateOfBirth!.Value,
                Addressline = dbResult.Addresslinel + " " + 
                dbResult.Addressline2 + " " +
                dbResult.Addressline3 + " " + 
                 dbResult.Country
            };
        }
        return null;
    }
    
}