namespace CarTrade.Domain;

public class Car : Vehicle
{
    public string RegistrationNumber { get; set; }
    public string FuelType { get; set; } = "";
    public int Doors { get; set; }
    public int Mileage { get; set; }
    public Engine? Engine { get; set; }
    public bool IsImported { get; set; }
    public bool IsLeased { get; set; }
    public List<Equipment>? Equipments { get; set; }
    public Car(string regNo)
    {
        RegistrationNumber = regNo;
    }

    public override string ToString()
    {
        return "Jag är en bil";
    }
}
