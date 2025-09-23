using Bank.Domain.Models;
using Bank.Domain.Utilities;
using Microsoft.VisualBasic;

namespace Bank.Client;

class Program
{
    static void Main()
    {
        // Använder objekt initiering...
        BankAccount account = new();
        BankAccount account2 = new(500);

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("----------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Konto 1 - {0}", account.ToString());
        Console.WriteLine("Konto 2 - {0}", account2.ToString());
        Console.WriteLine("----------------------------------------------------------------------------------------------------------");

        try
        {
            account.Deposit(100);
            account2.Deposit(20);
            account.Deposit(500);
            account.Withdraw(125);
            account.Deposit(100);
            account.Deposit(50);
            account2.Withdraw(5);
            account.Deposit(75);
            account.Withdraw(450);
        }
        catch (NoFundsException ex)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(ex.ToString());
            Console.ResetColor();
            return;
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(ex.Message);
            Console.ResetColor();
            return;
        }

        // account.Balance => då ska bara saldot visas...        
        Console.WriteLine("");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("Konto 1 transaktioner");

        foreach (var trx in account.Transactions)
        {
            Console.WriteLine("\t{0}", trx.ToString());
        }

        Console.WriteLine("----------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Konto 1 saldo: {0:N2}", account.Balance);
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("");
        Console.WriteLine("Konto 2 transaktioner");

        foreach (var trx in account2.Transactions)
        {
            Console.WriteLine("\t{0}", trx.ToString());
        }
        Console.WriteLine("----------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Konto 2 saldo: {0:N2}", account2.Balance);
        Console.ResetColor();

        SavingsAccount savingsAccount = new(1500);
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("----------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Sparkonto - {0}", savingsAccount.ToString());
        Console.WriteLine("----------------------------------------------------------------------------------------------------------");
        Console.WriteLine("");
        Console.ResetColor();

        savingsAccount.Deposit(250);
        savingsAccount.Withdraw(75);
        savingsAccount.Deposit(350);
        savingsAccount.Deposit(450);
        savingsAccount.Withdraw(350);

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("Sparkonto transaktioner");
        foreach (var trx in savingsAccount.Transactions)
        {
            Console.WriteLine("\t{0}", trx.ToString());
        }
        Console.WriteLine("----------------------------------------------------------------------------------------------------------");

        // savingsAccount.Balance => summan av alla transaktion uppräknat med räntesatsen...
        Console.WriteLine("Sparkonto saldo: {0:N2}", savingsAccount.Balance);

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.ResetColor();
    }
}
