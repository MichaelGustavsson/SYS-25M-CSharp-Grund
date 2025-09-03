using System.Reflection.Metadata.Ecma335;

namespace atm;

public class BankAccount
{
    public string Owner = "";
    public int Balance = 0;

    public void Deposit(int amount)
    {
        Balance += amount;
    }

    public void Withdraw(int amount)
    {
        Balance -= amount;
    }

    public string DisplayBalance()
    {
        return Balance.ToString();
    }
}
