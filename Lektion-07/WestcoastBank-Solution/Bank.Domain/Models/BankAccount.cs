namespace Bank.Domain.Models;

public class BankAccount
{
    // ============================================================
    // Tillstånd/State/Data...
    // Auto implementerad egenskaper
    public string AccountNumber { get; }
    public decimal Balance { get; set; }
    public string Owner { get; set; }
    public DateTime CreatedDate { get; set; }

    // Constructor methods
    public BankAccount()
    {
        CreatedDate = DateTime.Now;
        AccountNumber = "5578-111111";
        Owner = "Michael Gustavsson";
    }

    // Överlagrade constructors...
    public BankAccount(string owner)
    {
        CreatedDate = DateTime.Now;
        AccountNumber = "5578-111111";
        Owner = owner;
    }

    public BankAccount(string owner, decimal initialBalance)
    {
        CreatedDate = DateTime.Now;
        AccountNumber = "5578-111111";
        Owner = owner;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount) => Balance += amount;

    public void Withdraw(decimal amount)
    {
        if (Balance < amount)
        {
            Console.WriteLine("Uttag medges ej.");
            return;
        }

        Balance -= amount;
    }
}
