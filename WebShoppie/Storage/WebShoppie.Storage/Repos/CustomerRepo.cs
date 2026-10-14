using System;
using WebShoppie.Storage.DataModel;

namespace WebShoppie.Storage.Repos;

public class CustomerRepo : ICustomerRepository
{
    private readonly Dictionary<int, CustomerDataModel> _dataModels = new();
    public CustomerDataModel Create(CustomerDataModel customer)
    {
        var newId = 1;
        if(_dataModels.Keys.Any())
        {
            newId = _dataModels.Keys.Max() + 1;
        }
        _dataModels[newId] = customer;
        customer.Id = newId;
        return _dataModels[newId];
    }

    public CustomerDataModel GetById(int Id)
    {
       return _dataModels.GetValueOrDefault(Id);
    }
}
