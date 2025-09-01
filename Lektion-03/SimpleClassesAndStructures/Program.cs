namespace SimpleClassesAndStructures;

class Program
{
    static void Main()
    {
        // ==================================================
        // Skapa egna datatyper/datastrukturer
        // ==================================================

        // Struct
        // Skapar en instans(kopia)
        var position = new Point();
        position.x = 450;
        position.y = 600;

        Console.WriteLine("Positionens värde: {0} : {1}", position.x, position.y);

        position.Draw();

        // Class
        // new Vehicle skapar ett objekt med namnet volvo
        var volvo = new Vehicle();
        volvo.make = "Volvo";
        volvo.model = "XC60";
        volvo.mileage = 50000;
        volvo.modelYear = 2018;

        var ford = new Vehicle();
        ford.make = "Ford";
        ford.model = "MACH-E";
        ford.mileage = 20000;
        ford.modelYear = 2023;

        Console.WriteLine("Bilens information: {0}", volvo.make);
        Console.WriteLine("Bilens information: {0}", volvo.model);
        Console.WriteLine("Bilens information: {0}", volvo.mileage);
        Console.WriteLine("Bilens information: {0}", volvo.modelYear);

        Console.WriteLine("Bilens information: {0}", ford.make);
        Console.WriteLine("Bilens information: {0}", ford.model);
        Console.WriteLine("Bilens information: {0}", ford.mileage);
        Console.WriteLine("Bilens information: {0}", ford.modelYear);

        Vehicle[] vehicles = [
            new Vehicle{make="Fiat",model="Uno",mileage=250000,modelYear=2011},
            new Vehicle{make="Kia",model="Ceed",mileage=125000,modelYear=2015},
            new Vehicle{make="Mercedes",model="S500",mileage=450000,modelYear=2008}
        ];

        var vehicle = vehicles.Last();
        Console.WriteLine("Bilen är en {0} {1}", vehicle.make, vehicle.model);
    }

    // Class
    public class Vehicle
    {
        public string make = "";
        public string model = "";
        public int mileage;
        public int modelYear;
    }


    // Struct
    public struct Point
    {
        // Databärande variabler/data
        public int x = 0;
        public int y = 0;

        public Point()
        {
        }

        // Metoder...
        // Metoder utför något baserat på data som finns i structen...
        public void Draw()
        {
            Console.WriteLine("Jag kommer att rita en linje mellan punkterna: x={0} y={1}",
                x, y);
        }

    }
}
