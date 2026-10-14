using System;
using WebShoppie.Storage.DataModel;
namespace WebShoppie.Storage;

public interface ICustomerRepository
{
    CustomerDataModel Create(CustomerDataModel customer);
    CustomerDataModel? GetById(int Id);

}
