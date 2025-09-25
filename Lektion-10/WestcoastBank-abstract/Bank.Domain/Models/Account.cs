using Bank.Domain.Models;
using Bank.Domain.Utilities;

namespace Bank.Domain;

public abstract class Account
{
    public abstract string AccountNumber { get; }
    public abstract decimal Balance { get; }
    public abstract Customer? Owner { get; set; }
    public abstract DateTime CreatedDate { get; set; }
    public abstract List<Transaction> Transactions { get; set; }
    public abstract void Deposit(decimal amount);
    public abstract void Withdraw(decimal amount);

    public override string ToString()
    {
        return $"Kontodatum: {CreatedDate.ToShortDateString()} - Kontonummer: {AccountNumber} - Saldo: {Balance}";
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
