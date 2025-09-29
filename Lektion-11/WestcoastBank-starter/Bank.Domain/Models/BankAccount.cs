
using Bank.Domain.Utilities;

namespace Bank.Domain.Models;

public class BankAccount : Account
{
    public override string AccountNumber => GenerateAccountNumber();

    // public override decimal Balance
    // {
    //     get
    //     {
    //         decimal sum = 0;
    //         foreach (var trx in Transactions)
    //         {
    //             sum += trx.Amount;
    //         }
    //         return sum;
    //     }
    // }

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
        Transaction transaction = new(amount);
        Transactions.Add(transaction);

        string path = $"{Environment.CurrentDirectory}/Data/Transactions.txt";
        File.AppendAllText(path, $"{transaction}\n");
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

        Transaction transaction = new(amount);
        Transactions.Add(transaction);
        Transactions.Add(transaction);

        string path = $"{Environment.CurrentDirectory}/Data/Transactions.txt";
        File.AppendAllText(path, $"{transaction}\n");
    }
}
