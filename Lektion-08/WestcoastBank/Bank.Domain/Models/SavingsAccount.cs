namespace Bank.Domain.Models;

// SavingsAccount ärver ifrån BankAccount...
public class SavingsAccount : BankAccount
{
    // Tillstånd...
    public decimal InterestRate { get; set; }
}
