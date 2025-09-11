using System.Globalization;

namespace Bank.App;

class Program
{
    // Bonus övning.
    // Gör applikationen interaktiv...
    // Insättning och uttag...
    static void Main()
    {
        // Super bonus...
        // Att lägga bankkontona som är skapade i en lista...
        // Loopa/itera igenom alla konton och skriv ut saldot och kontonummer...
        BankAccount basicAccount = new BankAccount();
        basicAccount.AccountNumber = "111-222222";
        basicAccount.Owner = "Nils Nilsson";
        basicAccount.Balance = 5000;
        basicAccount.CreatedDate = DateTime.Now;

        basicAccount.Deposit(100);
        basicAccount.Withdraw(50);

        Console.WriteLine($"Ägare {basicAccount.Owner}");
        Console.WriteLine("Kontonummer {0}", basicAccount.AccountNumber);
        Console.WriteLine("Saldot {0}", basicAccount.Balance);
        Console.WriteLine("Öppnat datum {0}", basicAccount.CreatedDate);

        BankAccount savingsAccount = new BankAccount();
        savingsAccount.AccountNumber = "333-222222";
        savingsAccount.Owner = "Nils Nilsson";
        savingsAccount.Balance = 50000;
        savingsAccount.CreatedDate = DateTime.Now.AddDays(-30);

        Console.WriteLine($"Ägare {savingsAccount.Owner}");
        Console.WriteLine("Kontonummer {0}", savingsAccount.AccountNumber);
        Console.WriteLine("Saldot {0}", savingsAccount.Balance);
        Console.WriteLine("Öppnat datum {0}", savingsAccount.CreatedDate);
    }
}

