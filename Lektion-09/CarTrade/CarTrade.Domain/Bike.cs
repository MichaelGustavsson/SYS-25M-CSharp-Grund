namespace CarTrade.Domain;

public class Bike : Vehicle
{
    public bool Basket { get; set; }
    public override string ToString()
    {
        return $"Jag är en cykel: Jag har en cykelkorg: {Basket}";
    }
}
