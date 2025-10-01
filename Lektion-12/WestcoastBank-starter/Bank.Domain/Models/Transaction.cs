namespace Bank.Domain.Models;

public class Transaction(decimal amount)
{
    // Tillstånd/State...
    public DateTime TransactionDate { get; set; } = DateTime.Now;
    public decimal Amount { get; private set; } = amount;

    public override string ToString()
    {
        return $"Transaktionsdatum: {TransactionDate.ToShortDateString()} - Transaktionsbelopp: {Amount,10:N2}";
    }
}
