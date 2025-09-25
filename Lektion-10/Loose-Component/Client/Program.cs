using Domain;

namespace Client;

class Program
{
    static void Main()
    {
        IRepository db = new DbRepository();

        Console.WriteLine(db.List());
        Console.WriteLine(db.Add());
    }
}
