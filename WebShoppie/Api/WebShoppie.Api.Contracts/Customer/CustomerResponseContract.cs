using System;

namespace WebShoppie.Api.Contracts;

public class CustomerResponseContract
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Email { get; set; }
    public string Addressline { get; set; }
    public string Country { get; set; }

}
