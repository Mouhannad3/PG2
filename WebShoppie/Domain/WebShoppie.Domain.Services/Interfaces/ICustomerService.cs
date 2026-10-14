using System;
using WebShoppie.Api.Contracts;


namespace WebShoppie.Domain.Services.Interfaces;

public interface ICustomerService
{
    CustomerResponseContract CreateCustomer(CustomerRequestContract customerToCreate);
    CustomerResponseContract? GetById(int customerId);

}
