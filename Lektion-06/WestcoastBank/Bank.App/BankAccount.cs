namespace Bank.App;

public struct BankAccount
{
    // Information/Tillstånd(State)
    public string AccountNumber;
    public decimal Balance;
    public string Owner;
    public DateTime CreatedDate;

    // Metoder/Beteende (Behavior)
    public void Deposit(decimal amount)
    {
        // Lägga till logik för att uppdatera saldot med inskickat belopp...
    }

    public void Withdraw(decimal amount)
    {
        // Minska saldot med inskickat belopp
        // Ni ska kontrollera så att det finns tillräcklig
        // i saldot för att kunna ta ut beloppet...
    }
}