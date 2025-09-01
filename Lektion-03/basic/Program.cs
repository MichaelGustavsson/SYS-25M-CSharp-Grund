namespace basic;

class Program
{
    static void Main(string[] args)
    {
        // ===========================================================
        // Explicit typing...
        // ===========================================================

        // Skapar en plats i minnet för att lagra data som får namnet balance...
        // Skapar en låda med namnet balance
        // Deklarera en variabel...
        // och initierar variabeln med värdet 10...
        // ByValue...
        int balance = 10;
        Console.WriteLine($"Balance har nu värdet: {balance}");

        // ===========================================================
        // Heltal(int, long) inga decimaler
        // ===========================================================
        // värdet på balance variabeln(10) kopieras till saldo
        // Copy ByValue...
        int saldo = balance;
        Console.WriteLine($"Saldo har nu värdet: {saldo}");

        balance = 20;
        Console.WriteLine($"Balance har nu värdet: {balance}");

        saldo = 30;
        Console.WriteLine($"Saldo har nu värdet: {saldo}");
        Console.WriteLine($"Balance har nu värdet: {balance}");

        // ===========================================================
        // Strängar(string)
        // ===========================================================
        // Variabler använder sig av camelCase namngivning...
        string firstName = "Michael";
        Console.WriteLine($"Ditt namn är {firstName}");

        string nickName = firstName;
        Console.WriteLine($"Ditt smeknamn är {nickName}");

        nickName = "Micke";
        Console.WriteLine($"Ditt namn är {firstName}");
        Console.WriteLine($"Ditt smeknamn är {nickName}");

        // ===========================================================
        // Flyttal(double, decimal) decimaler
        // ===========================================================
        double amount = 25.50;
        Console.WriteLine($"Värdet är nu: {amount}");

        decimal size = 12.5M;
        Console.WriteLine($"Storleken är nu: {size}");

        // ===========================================================
        // Booleans(true, false)
        // ===========================================================
        bool isValid = true;
        Console.WriteLine($"Är det ok? {isValid}");

        // PascalCase används i C# för klasser och metoder...
        // DisplayBalance(){}

        // ===========================================================
        // Implicit typing...
        // ===========================================================
        var lastName = "100";
        Console.WriteLine($"Ditt efternamn är: {lastName}");

        lastName = "Gustavsson";
        Console.WriteLine($"Ditt efternamn är: {lastName}");

    }
}
