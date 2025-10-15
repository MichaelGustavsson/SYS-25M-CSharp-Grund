namespace domain;

public class Order
{
    public string OrderNumber { get; set; } = GenerateOrderNumber();
    public DateTime OrderDate { get; set; } = DateTime.Now;
    public string DiscountCode { get; set; } = "";
    public decimal OrderValue { get; set; }
    public List<OrderItem> OrderItems { get; set; } = [];
    public Customer Customer { get; set; } = new();

    private static string GenerateOrderNumber()
    {
        Random rnd = new();
        string prefix = "ES";
        string suffix = rnd.Next(1000000, 9999999).ToString();
        return $"{prefix}{suffix}";
    }
}
