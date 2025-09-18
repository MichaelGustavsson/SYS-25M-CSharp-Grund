namespace Bank.Domain.Models;

public class Transaction(decimal amount)
{
    // Tillstånd/State...
    public DateTime TransactionDate { get; } = DateTime.Now;
    public decimal Amount { get; private set; } = amount;
}
