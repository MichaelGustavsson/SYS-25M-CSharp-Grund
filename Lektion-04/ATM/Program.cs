namespace ATM;

// Klient programmet...
class Program
{
    static void Main()
    {
        Console.WriteLine("-----------------------------------------------------------------------");
        Console.WriteLine("För att avsluta programmet tryck på tangent 'x' och sedan 'Enter'");
        Console.WriteLine("För att se saldo tryck på tangent 'b'");
        Console.WriteLine("För att sätta in pengar tryck på tangenten 'd'");
        Console.WriteLine("För att ta ut pengar tryck på tangenten 'w'");
        Console.WriteLine("För att se senaste transaktionerna tryck på tangenten 't'");
        Console.WriteLine("-----------------------------------------------------------------------");

        // BankAccount account = new BankAccount();
        // var account = new BankAccount();
        BankAccount account = new();

        while (true)
        {
            string? key = Console.ReadLine();

            if (key == "x")
            {
                Environment.Exit(0);
            }
            else if (key == "b")
            {
                var balance = account.GetBalance();
                Console.WriteLine("Aktuellt saldo: {0}", balance);
            }
            else if (key == "d")
            {
                Console.WriteLine("Hur mycket vill du sätta in?");
                int amount = int.Parse(Console.ReadLine()!);
                account.Deposit(amount);
            }
            else if (key == "w")
            {
                Console.WriteLine("Hur mycket vill du ta ut?");
                // int amount = int.Parse(Console.ReadLine()!);

                if (int.TryParse(Console.ReadLine(), out int amount))
                {
                    account.Withdraw(amount);
                }
            }
            else if (key == "t")
            {
                var transactions = account.GetTransactions();

                foreach (var tran in transactions)
                {
                    Console.WriteLine("Transaktionens värde: {0}", tran);
                }
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
// ================================================
public class BankAccount
{
    // Vi behöver en variabel för att spara undan tillgängligt saldo...
    int balance = 0;

    // Lagra insättningar och uttag => transaktioner...
    // Vi skapar en dynamisk array som lagrar heltal...
    List<int> transactions = [];
    // List<int> transaction = new List<int>();

    public void Deposit(int value)
    {
        // Öka värdet på saldot...
        // balance = balance + value;
        balance += value;
        // Lägg till transaktion till vår transaktionslista...
        transactions.Add(value);
    }

    public void Withdraw(int value)
    {
        // Minska värdet på saldot...
        // balance = balance - value;
        if (balance < value)
        {
            throw new Exception("Du har inte tillräckligt på kontot");
        }
        else
        {
            balance -= value;

            // Lägg till transaktion till vår transaktionslista...
            transactions.Add(value);
        }
    }

    public int GetBalance()
    {
        return balance;
    }

    public List<int> GetTransactions()
    {
        return transactions;
    }
}
