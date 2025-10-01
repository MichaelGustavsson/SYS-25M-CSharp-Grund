
namespace Bank.Domain;

public class Address
{
    public string AddressLine { get; set; }
    public string PostalCode { get; set; }
    public string City { get; set; }
    public string Country { get; set; }

    public Address()
    {
        AddressLine = "";
        PostalCode = "";
        City = "";
        Country = "";
    }

    public override string ToString()
    {
        return $"{AddressLine} {PostalCode} {City}";
    }
}
