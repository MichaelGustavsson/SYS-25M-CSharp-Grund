namespace Bank.Domain.Models;

public abstract class Customer
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string SocialSecurityNumber { get; set; } = "";
    public string AddressLine { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }
    public string Country { get; set; }

    public Customer()
    {
        AddressLine = "";
        PostalCode = "";
        City = "";
        Country = "";
    }
}
