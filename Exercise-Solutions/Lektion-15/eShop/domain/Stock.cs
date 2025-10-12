namespace domain;

public class Stock
{
    public int UnitsInStock { get; set; }
    public Product Product { get; set; } = new();
}
