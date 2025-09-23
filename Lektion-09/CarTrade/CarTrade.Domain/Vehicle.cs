namespace CarTrade.Domain;

public class Vehicle
{
    public string Id { get; set; } = Guid.NewGuid().ToString().Replace("-", "");
    public string RegistrationNumber { get; set; }
    public string FuelType { get; set; } = "";
    public string Manufacturer { get; set; } = "";
    public string VinNumber { get; set; } = "";
    public int Wheels { get; set; }
    public string TransmissionType { get; set; } = "";
    public int Doors { get; set; }
    public int Mileage { get; set; }
    public string ModelYear { get; set; } = "";
    public string Model { get; set; } = "";
    public string Color { get; set; } = "";
    public Engine? Engine { get; set; }
    public bool IsImported { get; set; }
    public bool IsLeased { get; set; }
    public List<Equipment>? Equipments { get; set; }


    public Vehicle(string regNo)
    {
        RegistrationNumber = regNo;
    }
}
