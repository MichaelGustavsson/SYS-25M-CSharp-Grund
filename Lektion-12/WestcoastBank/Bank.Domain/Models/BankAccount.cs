namespace Bank.Domain.Models;

public class BankAccount : Account
{
    public BankAccount() { }
    public BankAccount(decimal initialBalance) : base(initialBalance)
    {
        Transactions.Add(new Transaction(initialBalance));
    }
}
