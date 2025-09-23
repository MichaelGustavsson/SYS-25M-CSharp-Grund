namespace CarTrade.Domain;

public class Truck : Vehicle
{
    public int Tara { get; set; }
    public Truck(string regNumber) : base(regNumber) { }
}
