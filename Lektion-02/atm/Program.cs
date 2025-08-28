namespace atm;

class Program
{
    static void Main(string[] args)
    {
        // Deklarerar en variabel för att hantera saldo...
        int balance;
        // Insättning...
        Console.WriteLine("Ange hur mycket du vill sätta in");
        string? amount = Console.ReadLine();

        // if (amount is null || amount.Length == 0)
        // if (amount is null || amount.Trim().Length == 0)
        if (string.IsNullOrWhiteSpace(amount))
        {
            Console.WriteLine("Du MÅSTE ange hur mycket du vill sätta in!!!");
            // Tvinga applikationen att DÖ!
            Environment.Exit(0);
        }
        // Konvertera amount ifrån string => int...
        // Cast, Parse, Convert
        balance = int.Parse(amount);
        // Skriv ut balansen(saldot)...
        DisplayBalance(balance);

        // Skriv ett kommando som frågar efter hur mycket som ni vill ta
        Console.WriteLine("Hur mycket vill du ta ut?");
        // Hämta in ifrån terminalen värdet som ni vill ta ut
        amount = Console.ReadLine();
        // Skriv ut hur mycket ni vill ta ut...
        Console.WriteLine("Du har tagit ut: " + amount);

        // Räkna balansen/Saldot och skriva saldot.
        balance -= int.Parse(amount);
        // balance = balance - int.Parse(amount);

        DisplayBalance(balance);
    }

    // Egen metod för att visa saldot...
    static void DisplayBalance(int balance) // Metodens spefication/header/interface
    {
        Console.WriteLine("Ditt saldo är: " + balance);
    }
}
