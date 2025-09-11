using System.Data;
using System.Security.Cryptography.X509Certificates;

namespace Demo;

class Program
{
    static void Main()
    {
        // ===================================================
        // Basic List... List<datatype>
        // ===================================================
        /*
            List<string> movies = new List<string>();
            movies.Add("Bucket List");
            movies.Add("Batman");
            movies.Add("Die Hard");
        */
        /*
        List<string> movies = ["Bucket List", "Batman", "Die Hard"];

        foreach (var movie in movies)
        {
            Console.WriteLine("Film: {0}", movie);
        }
        */

        // ===================================================
        // Dictionaries...
        // ===================================================
        // En lagring av ett nyckel och värde par sekventiellt...
        // Dictionary<int, string> vehicles = new Dictionary<int, string>
        // {
        //     { 1, "Volvo 245 1976" },
        //     { 2, "Ford Mustang 1968" }
        // };

        /*
        Dictionary<string, string> vehicles = new Dictionary<string, string>
        {
            { "A45YZ23", "Volvo 245 1976" },
            { "A678YXC7", "Ford Mustang 1968" }
        };

        var vehicle = vehicles["A45YZ23"];
        Console.WriteLine("Hittad bil med namn: {0}", vehicle);

        foreach (KeyValuePair<string, string> car in vehicles)
        {
            Console.WriteLine("Key: {0} Value: {1}", car.Key, car.Value);
        }
        */

        // foreach (KeyValuePair<int, string> car in vehicles)
        // {
        //     Console.WriteLine("Key: {0} Value: {1}", car.Key, car.Value);
        // }

        // ===================================================
        // Queues...
        // ===================================================

        /*
        Queue<string> comics = new Queue<string>();

        comics.Enqueue("Buster");
        comics.Enqueue("Läderlappen");
        comics.Enqueue("X9");

        foreach (var comic in comics)
        {
            Console.WriteLine("Serietidning: {0}", comic);
        }

        Console.WriteLine("Serietidning 1: {0}", comics.Dequeue());
        Console.WriteLine("Serietidning 2: {0}", comics.Dequeue());

        foreach (var comic in comics)
        {
            Console.WriteLine("Serietidning: {0}", comic);
        }
        */

        // ===================================================
        // Stacks...
        // ===================================================
        /*
        Stack<string> stores = new Stack<string>();

        stores.Push("ICA");
        stores.Push("Coop");
        stores.Push("Tempo");
        stores.Push("City Gross");

        Console.WriteLine("Första kedjan: {0}", stores.Pop());
        Console.WriteLine("Första kedjan: {0}", stores.Pop());

        foreach (var plate in stores)
        {
            Console.WriteLine("Butik: {0}", plate);
        }
        */

        // ===================================================
        // Metoder och överlagring...
        // ===================================================
        SimpleMethod();
        SimpleMethod("Nisse");
        SimpleMethod("Nisse", 25);

        // string result = SayHello();
        // Console.WriteLine("SayHello returnerade: {0} till mig", result);
        Console.WriteLine("Testar SayHello utan argument: {0} va kul det blev!!!", SayHello());
        Console.WriteLine(SayHello("Nisse"));
        Console.WriteLine(SayHello("Nisse", "Vägen 19 Storstaden"));
    }

    // Deklaration av metoder betyder att vi definierar
    // 1.   Namn på metoden
    // 2.   Eventuellt argument som metoden behöver
    // 3.   Eventuellt vad metoden returnerar
    public static void SimpleMethod()
    {
        Console.WriteLine("Jag gör inget och tar inte emot något");
    }

    public static void SimpleMethod(string value)
    {
        Console.WriteLine("Jag gör inget men tar emot ett värde: {0}", value);
    }

    public static void SimpleMethod(string value, int age)
    {
        Console.WriteLine("Jag gör inget men tar emot ett värde: {0} och ålder: {1}", value, age);
    }

    public static string SayHello()
    {
        return "Tjena";
    }
    public static string SayHello(string name)
    {
        return $"Tjena {name}";
    }
    public static string SayHello(string name, string address)
    {
        return $"Tjena {name} du bor på adress: {address}";
    }

    public static string SayHello(string name, int age)
    {
        return $"Tjena {name} du bor är: {age} gammal";
    }
}
