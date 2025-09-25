
using Bank.Domain.Utilities;

namespace Bank.Domain.Models;

public class BankAccount : Account
{
    public override string AccountNumber => GenerateAccountNumber();

    public override decimal Balance
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

    public override Customer? Owner { get; set; }
    public override DateTime CreatedDate { get; set; }
    public override List<Transaction> Transactions { get; set; }

    public BankAccount()
    {
        CreatedDate = DateTime.Now;
        Transactions = [];
    }
    public BankAccount(decimal initialBalance) : this()
    {
        Transactions.Add(new Transaction(initialBalance));
    }

    public override void Deposit(decimal amount)
    {
        Transactions.Add(new Transaction(amount));
    }

    public override void Withdraw(decimal amount)
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
}
