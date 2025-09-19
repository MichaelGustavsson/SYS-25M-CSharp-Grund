namespace Bank.Domain.Models;

// SavingsAccount ärver ifrån BankAccount...
public class SavingsAccount : BankAccount
{
    // Tillstånd...
    public decimal InterestRate { get; set; }

    public SavingsAccount(decimal initialBalance) : base(initialBalance)
    {
        InterestRate = 0.0175M;
    }

    public override void Deposit(decimal amount)
    {
        var sum = amount * (1 + InterestRate);
        Transactions.Add(new Transaction(sum));
        Balance += sum;
    }

    public override string ToString()
    {
        return $"Kontodatum: {CreatedDate.ToShortDateString()} - Kontonummer: {AccountNumber} - Saldo: {Balance} - Räntesats: {InterestRate}";
    }
}
