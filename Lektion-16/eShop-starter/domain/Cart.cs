namespace domain;

public class Cart
{
    public int Quantity { get; set; }
    // Composition - Kundvagnen har alltid en kund...
    public Customer Customer { get; set; }
    // Aggregation - Kundvagnen kan ha 1 eller flera produkter...
    public List<Product> Products { get; set; } = [];

    public Cart()
    {
        Customer = new Customer
        {
            Id = "2a672d3151c3490bba3cd270beada470"
        };
    }
}
