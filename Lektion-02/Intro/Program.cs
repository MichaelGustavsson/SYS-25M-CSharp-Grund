namespace Intro;

class Program
{
    static void Main()
    {
        // Deklarerar explicit en variabel av typen string...
        string name;

        // Läser in ifrån terminalen...
        name = Console.ReadLine();

        // Skriver ut till terminalen...
        Console.WriteLine(name);

    }
}


// option + 4 = $
// shift + option + 8 = {
// shift + option + 9 = }
// option + 8 = [
// option + 9 = ]
// shift + option + 7 = \
// option + 7 = |

// var name = "Michael";
// var age = 25;
// var amount = 0;
// var isOk = true;
// var balance = 12.5;
// var vehicle = new { mileage= 10};

// string name = "Michael";
// name = 25;


// Implicit declaration...
// var name = "???";
// Explicit declaration...
// string name;

// name = "Michael";

// $"Hej på dig,{name}"
// Template string med en dynamisk plats({name})
// Skapar en interpollation => skapa en ny sträng
// med Hej på dig, och sedan hämtar värdet på name
// och skriver ut Michael.
// Console.WriteLine($"Hej på dig, {name}");