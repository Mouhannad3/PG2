using Microsoft.AspNetCore.Mvc;
using WebShoppie.Api.Contracts;
using WebShoppie.Domain.Services.Interfaces;
namespace WebShoppie.Api.Controllers;

[ApiController]
[Route("customers")]
public class CustomersController(ICustomerService service) : ControllerBase
{
    [HttpPost]
    public ActionResult<CustomerResponseContract> Create(
        [FromBody] CustomerRequestContract customerContract)
    {


        return Ok(service.CreateCustomer(customerContract));
    }

    [HttpGet]
    [Route("{customerId}")]
    public ActionResult<CustomerResponseContract> GetById(
        [FromRoute] int customerId)
    {
        var customer = service.GetById(customerId);

        if (customer is null)
        {
            return NotFound();
        }
        return Ok(customer);
    }
}


      
    
