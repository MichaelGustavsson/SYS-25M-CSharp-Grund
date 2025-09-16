namespace Bank.App.Types;

public struct BankAccount
{
    public string AccountNumber;
    public decimal Balance;
    public string Owner;
    public DateTime CreatedDate;

    public void Deposit(decimal amount) => Balance += amount;

    public void Withdraw(decimal amount)
    {
        if (Balance < amount)
        {
            Console.WriteLine("Uttag medges ej.");
            return;
        }

        Balance -= amount;
    }
}
