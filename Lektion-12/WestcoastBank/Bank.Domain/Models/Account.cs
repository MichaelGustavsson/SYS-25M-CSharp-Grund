using Bank.Domain.Models;
using Bank.Domain.Utilities;

namespace Bank.Domain;

public class Account
{
    public string AccountNumber => GenerateAccountNumber();
    public Customer Owner { get; set; }
    public DateTime CreatedDate { get; set; }
    public List<Transaction> Transactions { get; set; } = [];

    public Account()
    {
        Owner = new Customer();
        CreatedDate = DateTime.Now;
    }

    public Account(decimal initialBalance) : this()
    {
        Transactions.Add(new Transaction(initialBalance));
    }

    public void Deposit(decimal amount)
    {
        Transaction transaction = new(amount);
        Transactions.Add(transaction);
    }

    public virtual void Withdraw(decimal amount)
    {
        if (Balance < amount)
        {
            throw new NoFundsException("Uttag medges ej.", amount, Balance);
        }

        if (amount > 0)
        {
            amount = 0 - amount;
        }

        Transaction transaction = new(amount);
        Transactions.Add(transaction);
    }

    // Composed property
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

    public override string ToString()
    {
        return $"Kontodatum: {CreatedDate:d} - Kontonummer: {AccountNumber} - Saldo: {Balance:N2}";
    }
    protected static string GenerateAccountNumber()
    {
        // Skapa autogenererad kontonummer...
        Random rnd = new();
        string prefix = "5578";
        string suffix = rnd.Next(10000000, 99999999).ToString();
        return $"{prefix}-{suffix}";
    }
}
