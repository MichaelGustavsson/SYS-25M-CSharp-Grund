namespace atm;

class Program
{
    static void Main(string[] args)
    {
        // Här kommer en rad med kommentarer...
        /* 
            Här är radbrutna kommentarer...
        */

        /* Console.WriteLine("Hello, World!");
        Console.WriteLine("Hej på dig");
        var name = Console.ReadLine();
        Con sole.WriteLine(name);*/

        var age = 35;
        Console.WriteLine("Du så här gammal " + age);
        // Template string...
        Console.WriteLine($"Du så här gammal, {age}");

        var i = 10;
        var j = 5;

        var result = i + j;

        Console.WriteLine($"Resultatet av {i} + {j} är {result}");

    }
}
