using Bank.Domain.Models;
using Bank.Domain.Utilities;


namespace Bank.App;

class Program
{
    static void Main()
    {
        // Använder objekt initiering...
        BankAccount account = new();
        Console.WriteLine("Konto skapat: {0} AccountNumber: {1}, Kontohavare: {2} - Saldo: {3}",
            account.CreatedDate, account.AccountNumber, "???", account.Balance);

        BankAccount account2 = new(500);
        Console.WriteLine("Konto skapat: {0} AccountNumber: {1}, Kontohavare: {2} - Saldo: {3}",
            account2.CreatedDate, account2.AccountNumber, "???", account2.Balance);

        Console.WriteLine(account.ToString());
        Console.WriteLine(account2.ToString());

        try
        {
            account.Deposit(1500);
            account.Deposit(500);
            account.Withdraw(125);
            account.Deposit(100);
            account.Deposit(50);
            account.Deposit(75);
            account.Withdraw(45);
            account.Withdraw(35000);
        }
        catch (NoFundsException ex)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(ex.ToString());
            // Console.WriteLine("Felmeddelande: {0} Uttag: {1} aktuellt saldo: {2}",
            //     ex.Message, ex.AmountToWithdraw, ex.Balance);
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


        Console.ForegroundColor = ConsoleColor.DarkBlue;
        Console.WriteLine("---------------------------------------------------");
        foreach (var trx in account.Transactions)
        {
            Console.WriteLine(trx.ToString());
        }
        Console.WriteLine("---------------------------------------------------");
        Console.ResetColor();

        SavingsAccount savingsAccount = new SavingsAccount(1500);
        Console.WriteLine(savingsAccount.ToString());

        savingsAccount.Deposit(250);
        savingsAccount.Withdraw(75);
        savingsAccount.Deposit(350);
        savingsAccount.Deposit(450);
        savingsAccount.Withdraw(350);

        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.WriteLine("---------------------------------------------------");
        foreach (var trx in savingsAccount.Transactions)
        {
            Console.WriteLine(trx.ToString());
        }
        Console.WriteLine("---------------------------------------------------");
        Console.ResetColor();

        // savingsAccount.Balance => summan av alla transaktion uppräknat med räntesatsen...

    }
}
