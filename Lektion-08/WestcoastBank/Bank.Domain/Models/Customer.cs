namespace Bank.Domain.Models;

public class Customer
{
    // Tillstånd...
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required string SocialSecurityNumber { get; set; }
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
