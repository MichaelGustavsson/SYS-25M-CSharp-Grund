
using Bank.Domain.Utilities;
using Bank.Persistence;

namespace Bank.Domain.Models;

public class BankAccount : Account
{
    readonly string _path = $"{Environment.CurrentDirectory}/Data/Transactions.txt";
    public override string AccountNumber => GenerateAccountNumber();

    public override Customer? Owner { get; set; }
    public override DateTime CreatedDate { get; set; }
    public override List<Transaction> Transactions { get; set; }

    public BankAccount()
    {
        CreatedDate = DateTime.Now;
        Transactions = [.. FetchTransactions()];
    }
    public BankAccount(decimal initialBalance) : this()
    {
        Transactions.Add(new Transaction(initialBalance));
    }

    public override void Deposit(decimal amount)
    {
        Transaction transaction = new(amount);
        Transactions.Add(transaction);

        FileStorage.WriteFile(_path, $"{transaction}\n");
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

        FileStorage.WriteFile(_path, $"{transaction}\n");
    }

    private IList<Transaction> FetchTransactions()
    {
        var result = FileStorage.ReadFile(_path);
        IList<Transaction> transactions = [];

        foreach (string item in result)
        {
            IList<string> element = item.Split(':');
            string trxDate = element[1].TrimStart()[..10];
            string trxAmount = element[2].TrimStart();
            Transaction trx = new(decimal.Parse(trxAmount))
            {
                TransactionDate = DateTime.Parse(trxDate)
            };
            transactions.Add(trx);
        }

        return transactions;
    }
}
