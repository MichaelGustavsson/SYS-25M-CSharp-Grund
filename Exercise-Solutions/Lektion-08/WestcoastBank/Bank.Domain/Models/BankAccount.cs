using Bank.Domain.Utilities;

namespace Bank.Domain.Models;

public class BankAccount
{
    // ============================================================
    // Tillstånd/State/Data...
    // Auto implementerad egenskaper
    public string AccountNumber { get; }
    public virtual decimal Balance
    {
        get
        {
            decimal sum = 0;
            foreach (var trx in Transactions)
            {
                sum += trx.Amount;
            }
            return sum;
        }
    }
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
        Transactions = [];
    }
    public BankAccount(decimal initialBalance) : this()
    {
        Transactions.Add(new Transaction(initialBalance));
    }

    // Metoderna representerar vad vi behöver kunna utföra med klassen
    // Beteende/Behavior
    public void Deposit(decimal amount)
    {
        Transactions.Add(new Transaction(amount));
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
