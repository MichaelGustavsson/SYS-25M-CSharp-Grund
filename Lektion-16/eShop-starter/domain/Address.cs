namespace domain;

public enum AddressTypeEnum
{
    Delivery = 1,
    Invoice
}
public class Address
{
    public AddressTypeEnum AddressType { get; set; }
    public string AddressLine { get; set; } = "";
    public string PostalCode { get; set; } = "";
    public string City { get; set; } = "";
}
