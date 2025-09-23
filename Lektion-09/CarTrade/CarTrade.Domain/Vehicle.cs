namespace CarTrade.Domain;

public class Vehicle
{
    public string Id { get; set; } = Guid.NewGuid().ToString().Replace("-", "");
    public string Manufacturer { get; set; } = "";
    public string IdentificationNumber { get; set; } = "";
    public int Wheels { get; set; }
    public string TransmissionType { get; set; } = "";
    public string ModelYear { get; set; } = "";
    public string Model { get; set; } = "";
    public string Color { get; set; } = "";

    public override string ToString()
    {
        return "Jag är ett fordon";
    }
}
