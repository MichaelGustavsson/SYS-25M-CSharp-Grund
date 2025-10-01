using Bank.Domain;
using Bank.Domain.Models;
using Bank.Domain.Utilities;

namespace Bank.Client;

class Program
{
    static void Main()
    {
        // Presentera alla befintliga transaktioner...
        // ...
        BankAccount account = new();

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("--------------------------------------------------------------------------------");
        foreach (var trx in account.Transactions)
        {
            Console.WriteLine(trx.ToString());
        }
        Console.WriteLine("--------------------------------------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("");

        BankAccount account2 = new(500);
        SavingsAccount savingsAccount = new(1500);

        Private michael = new("Michael", "Gustavsson", "11112233-4444")
        {
            Address = new Address
            {
                AddressLine = "Gatan 1",
                PostalCode = "12345",
                City = "Staden"
            }
        };

        account.Owner = michael;

        account2.Owner = new Company("Företaget AB", "666666-7777");

        DisplayAccountInfo("Konto 1", account);
        DisplayAccountInfo("Konto 2", account2);
        DisplayAccountInfo("Sparkonto", savingsAccount);

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
            account.Withdraw(-45);
        }
        catch (NoFundsException ex)
        {
            DisplayErrorMessage(ex.ToString());
            return;
        }
        catch (Exception ex)
        {
            DisplayErrorMessage(ex.Message);
            return;
        }

        DisplayTransactionInfo("Konto 1 transaktioner", account.Balance, account.Transactions);
        DisplayTransactionInfo("Konto 2 transaktioner", account2.Balance, account2.Transactions);

        try
        {
            savingsAccount.Deposit(250);
            savingsAccount.Withdraw(75);
            savingsAccount.Deposit(350);
            savingsAccount.Deposit(450);
            savingsAccount.Withdraw(350);
        }
        catch (NoFundsException ex)
        {
            DisplayErrorMessage(ex.ToString());
            return;
        }
        catch (Exception ex)
        {
            DisplayErrorMessage(ex.Message);
            return;
        }


        DisplayTransactionInfo("Sparkonto transaktioner", savingsAccount.Balance, savingsAccount.Transactions);
    }

    private static void DisplayAccountInfo(string message, Account account)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine($"{message} - {account} {(account.Owner == null ? "Kunduppgifter saknas" : "| " + account.Owner + " " + account.Owner.Address)} ");
        Console.WriteLine("------------------------------------------------------------------------------------------------------------------------------");
        Console.ResetColor();
    }

    private static void DisplayTransactionInfo(string message, decimal balance, List<Transaction> transactions)
    {
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine($"{message}");

        foreach (var trx in transactions)
        {
            Console.WriteLine("\t{0}", trx.ToString());
        }

        Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("Konto 1 saldo: {0:N2}", balance);
        Console.ResetColor();
    }

    private static void DisplayErrorMessage(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{message}");
        Console.ResetColor();
    }
}
