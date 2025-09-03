namespace Iterations;

class Program
{
    static void Main()
    {
        // ===========================================================
        // Iterationer = gå steg för steg igenom en lista av data
        // ===========================================================

        string[] vehicles = ["Volvo", "Fiat", "Ford", "Kia", "Volkswagen"];

        // Iterationer = loopar.
        // for i loopen...
        for (int i = 0; i < vehicles.Length; i++)
        {
            Console.WriteLine("Vi är på index: {0}, värdet är: {1}", i, vehicles[i]);
        }

        // foreach loopen...
        foreach (var vehicle in vehicles)
        {
            Console.WriteLine("Bilen är av märket: {0}", vehicle);
            // if (vehicle == "Ford") break;
        }

        // while och do while looparna...
        // int i = 1;
        // while (i <= 5)
        // {
        //     Console.WriteLine("Iteration: {0}", i);
        //     // JÄTTEVIKTIGT GLÖM INTE ATT RÄKNA UPP VILLKORS VARIABELN!!!
        //     i++; // i = i + 1;
        // }

        // do
        // {
        //     Console.WriteLine("Iteration: {0}", i);

        //     // JÄTTEVIKTIGT GLÖM INTE ATT RÄKNA UPP VILLKORS VARIABELN!!!
        //     i++; // i = i + 1;
        // } while (i < 5);
    }
}
