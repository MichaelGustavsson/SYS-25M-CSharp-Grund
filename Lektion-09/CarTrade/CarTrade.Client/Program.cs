using CarTrade.Domain;

namespace CarTrade.Client;

class Program
{
    static void Main(string[] args)
    {
        Car volvo = new Car("ABC123");
        Truck mack = new Truck("FGH123");
        Bike crescent = new Bike("");
    }
}
