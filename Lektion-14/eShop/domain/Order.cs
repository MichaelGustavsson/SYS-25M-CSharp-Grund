namespace domain;

public class Order
{
    public string OrderNumber { get; set; } = "";
    public string DiscountCode { get; set; } = "";
    public decimal OrderValue { get; set; }
    public List<OrderItem> OrderItems { get; set; } = [];
    public Customer Customer { get; set; } = new();
}
