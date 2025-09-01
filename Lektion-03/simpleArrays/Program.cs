namespace simpleArrays;

class Program
{
    static void Main()
    {
        // Array en datastruktur som lagrar information/data
        // linjärt. Data som lagras kallas för element...
        // Vi kan skapa arrayer ifrån vilken datatyp som helst...
        // Åtkomst till elementen(datat) sker via elements index(position)

        // ============================================================
        // Låt oss skapa en array som lagrar element av datatypen int
        // ============================================================
        // Metod 1.        
        int[] numbers = new int[5];

        // Lägg till data i en arrays element...
        numbers[0] = -1;
        numbers[1] = 1;
        numbers[2] = 2;
        numbers[3] = 3;
        numbers[4] = 4;
        // numbers[5] = 5;

        Console.WriteLine("Värdet i byrån i låda 1: {0}", numbers[0]);
        Console.WriteLine("Hur många lådor finns det i byrån? {0}", numbers.Length);

        // Metod 2.
        int[] values = [-1, 2, 3, 4, 5, 6, 7, 8, 9];
        Console.WriteLine("Value på position 2 i array values: {0}", values[1]);

        // ============================================================
        // Låt oss skapa en array som lagrar element av datatypen string
        // ============================================================
        string[] names = ["Wilma", "Simon", "Jocke", "My"];

        Console.WriteLine("Vad heter du på position 2 i listan? {0}", names[1]);
        names[1] = "Filip";
        Console.WriteLine("Vad heter du på position 2 i listan? {0}", names[1]);

        // Går icke!!!
        // names[5] = "Hassan";

        // ============================================================
        // Låt oss skapa en array som lagrar element av typen
        // anonyma objekt...
        // ============================================================

        object[] vehicles = [
            new {make="Volvo", model="XC60", mileage=50000, modelYear=2018},
            new {make="Ford", model="MACH-E", mileage=20000, modelYear=2022},
            new {make="KIA", model="EV6", mileage=45000, modelYear=2023},
        ];

        Console.WriteLine(vehicles[2]);
        var vehicle = vehicles[vehicles.Length - 1];
        Console.WriteLine(vehicle);
        var lastVehicle = vehicles.Last();
        Console.WriteLine(lastVehicle);
        var firstVehicle = vehicles.First();
        Console.WriteLine(firstVehicle);
    }
}
