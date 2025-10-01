namespace Bank.Domain.Utilities;

public class NoFundsException : Exception
{
    public decimal AmountToWithdraw { get; set; }
    public decimal Balance { get; set; }
    public NoFundsException(string Message, decimal amount, decimal balance) : base(Message)
    {
        AmountToWithdraw = amount;
        Balance = balance;
    }

    public override string ToString()
    {
        return $"{Message} {Balance}, {AmountToWithdraw}";
    }
}
