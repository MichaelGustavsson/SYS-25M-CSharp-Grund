namespace DatatypesAndListStructures;

class Program
{
    static void Main()
    {
        // DataTypes .NET BaseType...
        Console.WriteLine(".NET Base Type......");
        object obj = new();

        Console.WriteLine("HashCode: {0}", obj.GetHashCode());
        Console.WriteLine("Type: {0}", obj.GetType());

        Console.WriteLine("");
        Console.WriteLine(".NET Integer(int)......");
        int x = 10;

        Console.WriteLine("HashCode: {0}", x.GetHashCode());
        Console.WriteLine("Type: {0}", x.GetType());
        Console.WriteLine("CompareTo: {0}", x.CompareTo(20));
        Console.WriteLine("ToString(): {0}", x.ToString());

        Console.WriteLine("");
        Console.WriteLine(".NET String(string)......");
        string name = "Nisse Nilsson";

        Console.WriteLine("HashCode: {0}", name.GetHashCode());
        Console.WriteLine("Type: {0}", name.GetType());
        Console.WriteLine("Length of string: {0}", name.Length);
        Console.WriteLine("OldString: {0} newString: {1}",
            name, name.Replace("Nisse Nilsson", "Nils Nilsson")
        );
        Console.WriteLine("Concat: {0}",
            string.Concat("Fan", " ", "vad C# är kul🤩"));


        Console.WriteLine("");
        Console.WriteLine(".NET DateTime................");

        // DateTime testDate = DateTime.Today;
        DateTime testDate = DateTime.Now;
        Console.WriteLine("Aktuell datum och tid: {0}", testDate);
        Console.WriteLine("Aktuell datum och tid: {0}", testDate.Date);
        Console.WriteLine("Aktuell datum och tid: {0}", testDate.TimeOfDay);
        Console.WriteLine("Aktuell datum och tid: {0}", testDate.Year);
        Console.WriteLine("Aktuell datum och tid: {0}", testDate.Month);
        Console.WriteLine("Aktuell datum och tid: {0}", testDate.DayOfWeek);
        Console.WriteLine("Aktuell datum och tid: {0}", testDate.DayOfYear);
        Console.WriteLine("Aktuell datum och tid: {0}", testDate.IsDaylightSavingTime());

        Console.WriteLine("Aktuell datum och tid: {0}", testDate.AddMonths(2));
        Console.WriteLine("Aktuell datum och tid: {0}", testDate.AddMonths(-2));
        Console.WriteLine("Aktuell datum och tid: {0}", testDate.AddDays(2));
        Console.WriteLine("Aktuell datum och tid: {0}", testDate.AddDays(-2));

    }
}
