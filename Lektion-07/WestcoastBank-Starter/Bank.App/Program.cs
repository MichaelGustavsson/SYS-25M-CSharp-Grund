using Bank.App.Types;

namespace Bank.App;

class Program
{
    static void Main()
    {
        List<BankAccount> accounts = new List<BankAccount>();

        BankAccount basicAccount = new BankAccount();
        basicAccount.AccountNumber = "111-222222";
        basicAccount.Owner = "Nils Nilsson";
        basicAccount.Balance = 5000;
        basicAccount.CreatedDate = DateTime.Now;

        accounts.Add(basicAccount);

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Baskonto: -----------------------------------------------");
        Console.WriteLine($"Ägare {basicAccount.Owner}");
        Console.WriteLine("Kontonummer {0}", basicAccount.AccountNumber);
        Console.WriteLine("Saldot {0}", basicAccount.Balance);
        Console.WriteLine("Öppnat datum {0}", basicAccount.CreatedDate);
        Console.WriteLine("---------------------------------------------------------");

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("");
        Console.WriteLine("Alla baskonton ------------------------------------------");
        foreach (BankAccount account in accounts)
        {
            Console.WriteLine("Baskonto - Kontonummer {0} - Saldo: {1}",
                account.AccountNumber, account.Balance);
        }
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("");
        Console.ResetColor();

        BankAccount savingsAccount = new BankAccount();
        savingsAccount.AccountNumber = "333-222222";
        savingsAccount.Owner = "Nils Nilsson";
        savingsAccount.Balance = 50000;
        savingsAccount.CreatedDate = DateTime.Now.AddDays(-30);

        accounts.Add(savingsAccount);

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Sparkonto: ----------------------------------------------");
        Console.WriteLine($"Ägare {savingsAccount.Owner}");
        Console.WriteLine("Kontonummer {0}", savingsAccount.AccountNumber);
        Console.WriteLine("Saldot {0}", savingsAccount.Balance);
        Console.WriteLine("Öppnat datum {0}", savingsAccount.CreatedDate);
        Console.WriteLine("---------------------------------------------------------");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("");
        Console.WriteLine("Alla konton ---------------------------------------------");
        foreach (BankAccount account in accounts)
        {
            Console.WriteLine("Kontonummer {0} - Saldo: {1}",
                account.AccountNumber, account.Balance);
        }
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("");
        Console.ResetColor();
    }
}
