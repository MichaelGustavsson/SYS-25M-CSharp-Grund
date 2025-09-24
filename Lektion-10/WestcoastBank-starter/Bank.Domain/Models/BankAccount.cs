using Bank.Domain.Utilities;

namespace Bank.Domain.Models;

public class BankAccount
{
    public string AccountNumber { get; } = GenerateAccountNumber();
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
    public Customer? Owner { get; set; }
    public DateTime CreatedDate { get; set; }
    public List<Transaction> Transactions { get; set; } = [];

    public BankAccount()
    {
        CreatedDate = DateTime.Now;
        Transactions = [];
    }
    public BankAccount(decimal initialBalance) : this()
    {
        Transactions.Add(new Transaction(initialBalance));
    }

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
        return $"Kontodatum: {CreatedDate:d} - Kontonummer: {AccountNumber} - Saldo: {Balance}";
    }

    private static string GenerateAccountNumber()
    {
        // Skapa autogenererad kontonummer...
        Random rnd = new();
        string prefix = "5578";
        string suffix = rnd.Next(10000000, 99999999).ToString();
        return $"{prefix}-{suffix}";
    }
}
