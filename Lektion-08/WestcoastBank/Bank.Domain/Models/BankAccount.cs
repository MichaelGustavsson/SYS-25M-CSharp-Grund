namespace Bank.Domain.Models;

public class BankAccount
{
    // ============================================================
    // Tillstånd/State/Data...
    // Auto implementerad egenskaper
    public string AccountNumber { get; }
    public decimal Balance { get; set; }
    // Composition...
    public Customer? Owner { get; set; }
    public DateTime CreatedDate { get; set; }
    // Aggregation...
    public List<Transaction> Transactions { get; set; }

    // Constructor methods
    public BankAccount()
    {
        CreatedDate = DateTime.Now;
        AccountNumber = "5578-111111";
        Owner = new Customer
        {
            FirstName = "Michael",
            LastName = "Gustavsson",
            SocialSecurityNumber = "112233-5544"
        };

        Transactions = [];
    }

    // Överlagrade constructors...
    public BankAccount(decimal initialBalance)
    {
        CreatedDate = DateTime.Now;
        AccountNumber = "5578-111111";
        Balance = initialBalance;
        Transactions = [];
        Deposit(initialBalance);
    }

    // Metoderna representerar vad vi behöver kunna utföra med klassen
    // Beteende/Behavior
    public void Deposit(decimal amount)
    {
        Transactions.Add(new Transaction(amount));
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (Balance < amount)
        {
            Console.WriteLine("Uttag medges ej.");
            return;
        }

        Transactions.Add(new Transaction(amount));
        Balance -= amount;
    }
}
