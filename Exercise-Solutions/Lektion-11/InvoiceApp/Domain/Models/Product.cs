namespace Domain;

public class Product
{
    public string ItemNumber { get; set; } = "";
    public string Name { get; set; } = "";
    public decimal Price { get; set; }

    public override string ToString()
    {
        return $"Artikelnummer: {ItemNumber} Produktnamn: {Name} Pris/st: {Price:N2}";
    }
}