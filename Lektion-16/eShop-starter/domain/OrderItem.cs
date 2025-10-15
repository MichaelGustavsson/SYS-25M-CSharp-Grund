namespace domain;

public class OrderItem
{
    public decimal Discount { get; set; }
    public int Quantity { get; set; }
    public Product Product { get; set; } = new();
}
