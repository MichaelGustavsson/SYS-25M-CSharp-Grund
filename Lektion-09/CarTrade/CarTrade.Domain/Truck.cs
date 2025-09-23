namespace CarTrade.Domain;

public class Truck : Car
{
    public int Tara { get; set; }
    public Truck(string regNumber) : base(regNumber) { }

    public override string ToString()
    {
        return "Jag är en lastbil";
    }
}
