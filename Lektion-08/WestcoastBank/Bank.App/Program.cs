using Bank.Domain.Models;

namespace Bank.App;

class Program
{
    static void Main()
    {
        // Använder objekt initiering...
        BankAccount account = new(500);

        Console.WriteLine("Konto skapat: {0} AccountNumber: {1}, Kontohavare: {2} - Saldo: {3}",
            account.CreatedDate, account.AccountNumber, "???", account.Balance);

        Console.WriteLine("Konto skapat: {0} AccountNumber: {1}, Kontohavare: {2} - Saldo: {3}",
            account.CreatedDate, account.AccountNumber, "???", account.Balance);

        account.Deposit(500);

        SavingsAccount savingsAccount = new()
        {
            InterestRate = 0.0175M
        };

    }
}
