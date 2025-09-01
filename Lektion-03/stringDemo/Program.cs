using System.Runtime.InteropServices;

namespace stringDemo;

class Program
{
    static void Main()
    {
        string name = "Jensen Education";
        Console.WriteLine(name);

        // Console.WriteLine(name.Count());
        Console.WriteLine(name.Length);

        // string partOfName = name.Substring(0);
        string partOfName = name[..];
        Console.WriteLine(partOfName);

        // partOfName = name.Substring(1);
        partOfName = name[1..];
        Console.WriteLine(partOfName);

        // partOfName = name.Substring(0, 6);
        partOfName = name[..6];
        Console.WriteLine(partOfName);

        // partOfName = name.Substring(7);
        partOfName = name[7..];
        Console.WriteLine(partOfName);

        double value = 7988.67950;
        Console.WriteLine("Värdet är: {0}", value);
        Console.WriteLine("Värdet är nu: {0:C2}", value);
        Console.WriteLine("Värdet är nu: {0:N2}", value);
        // Console.WriteLine("Värdet är nu: {0:F2}", value);
        // Console.WriteLine("Värdet är nu: {0:G2}", value);
        // C = Currency...
        // N = Fasta decimal med tusen separator...
        // D = Decimal
        // F = Fast decimaler
        // E = Exponenter
        // G = Generell formatering(standard)

        string firstName = "Michael";
        string lastName = "Gustavsson";
        // string fullName = firstName + " " + lastName;
        string fullName = string.Concat(firstName, " ", lastName);

        Console.WriteLine("Ditt fullständiga namn är: {0}", fullName);

        Console.WriteLine("Delar av ditt namn finns: {0}", fullName.Contains("Michael"));
        Console.WriteLine("Delar av ditt namn finns: {0}", fullName.Contains("ich"));
        Console.WriteLine("Delar av ditt namn finns: {0}", fullName.Contains("son"));
        Console.WriteLine("Delar av ditt namn finns: {0}", fullName.Contains("ols"));

        string[] words = name.Split(" ");

        Console.WriteLine("Första ordet är {0}", words[0]);
        Console.WriteLine("Andra ordet är {0}", words[1]);

    }
}
