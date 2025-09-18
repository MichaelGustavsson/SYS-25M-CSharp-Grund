using Bank.Domain.Models;

namespace Bank.App;

class Program
{
    static void Main()
    {
        // Använder objekt initiering...
        BankAccount account = new("Stig Karlsson", 500);

        Console.WriteLine("Konto skapat: {0} AccountNumber: {1}, Kontohavare: {2} - Saldo: {3}",
            account.CreatedDate, account.AccountNumber, "???", account.Balance);

        Console.WriteLine("Konto skapat: {0} AccountNumber: {1}, Kontohavare: {2} - Saldo: {3}",
            account.CreatedDate, account.AccountNumber, "???", account.Balance);

        // BankAccount basicAccount = new("Stig Karlsson") { Balance = 75 };
        // Console.WriteLine("Kontonummer: {0}", basicAccount.AccountNumber);
        // BankAccount basicAccount = new BankAccount("Stig Karlsson") { _balance = 75 };
        // BankAccount basicAccount = new BankAccount{_balance = 10};
        // Denna rad anropar Constructor metoden i BankAccount klassen...
        // BankAccount basicAccount = new BankAccount("Stig Karlsson", 500);
        // BankAccount basicAccount = new BankAccount("Stig Karlsson");
        // BankAccount basicAccount = new BankAccount();

        // Console.WriteLine(basicAccount.GetAccountInfo());
    }
}
