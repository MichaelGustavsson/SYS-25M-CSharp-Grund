using Bank.Domain.Utilities;

namespace Bank.Domain.Models;

public class BankAccount
{
    // ============================================================
    // Tillstånd/State/Data...
    // Auto implementerad egenskaper
    public string AccountNumber { get; }
    public decimal Balance { get; set; }
    // Composition...
    public Customer? Owner { get; set; }
    public DateTime CreatedDate { get; set; }
    // Aggregation...
    public List<Transaction> Transactions { get; set; }

    // Constructor methods
    public BankAccount()
    {
        AccountNumber = GenerateAccountNumber();
        CreatedDate = DateTime.Now;
        Transactions = new List<Transaction>();
    }
    public BankAccount(decimal initialBalance) : this()
    {
        Balance = initialBalance;
    }

    // Metoderna representerar vad vi behöver kunna utföra med klassen
    // Beteende/Behavior
    public virtual void Deposit(decimal amount)
    {
        Transactions.Add(new Transaction(amount));
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (Balance < amount)
        {
            throw new NoFundsException("Uttag medges ej.", amount, Balance);
        }

        if (amount > 0)
        {
            amount = 0 - amount;
        }

        Transactions.Add(new Transaction(amount));
        Balance += amount;
    }

    public override string ToString()
    {
        return $"Kontodatum: {CreatedDate.ToShortDateString()} - Kontonummer: {AccountNumber} - Saldo: {Balance}";
    }

    // Privata metoder
    private string GenerateAccountNumber()
    {
        // Skapa autogenererad kontonummer...
        Random rnd = new();
        string prefix = "5578";
        string suffix = rnd.Next(10000000, 99999999).ToString();
        return $"{prefix}-{suffix}";
    }
}
