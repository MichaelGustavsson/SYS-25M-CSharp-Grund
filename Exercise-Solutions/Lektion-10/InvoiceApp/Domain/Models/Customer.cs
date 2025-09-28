namespace Domain;

public abstract class Customer
{
    public string CustomerNumber { get; set; } = Guid.NewGuid().ToString().Replace("-", "");
    public string Reference { get; set; } = "";
    public string Phone { get; set; } = "";
    public Address? DeliveryAddress { get; set; }
    public Address? InvoiceAddress { get; set; }

    public override string ToString()
    {
        return $"Referens: {Reference}";
    }
}
