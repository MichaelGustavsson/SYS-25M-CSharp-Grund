namespace Domain;

public class InvoiceItem
{
    public int NumberOfItems { get; set; }
    public decimal LineSum { get; set; }
    public Product Product { get; set; }

    public InvoiceItem(int numberOfItems, Product product)
    {
        Product = product;
        NumberOfItems = numberOfItems;
        LineSum = Product.Price * numberOfItems;
    }

    public override string ToString()
    {
        return $"Produkt: {Product} - Antal: {NumberOfItems} - Radsumma: {LineSum:N2}";
    }
}
