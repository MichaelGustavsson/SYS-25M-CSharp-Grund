namespace ATM;

// Klient programmet...
class Program
{
    static void Main()
    {
        // BankAccount account = new BankAccount();
        // var account = new BankAccount();
        BankAccount account = new();

        // Visa saldot...
        Console.WriteLine("Aktuellt saldo: {0}", account.GetBalance());

        // Sätt in pengar...
        account.Deposit(500);

        // Visa saldot...
        Console.WriteLine("Aktuellt saldo: {0}", account.GetBalance());

        // Ta ut lite pengar...
        try
        {
            account.Withdraw(25);
            account.Withdraw(1000);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Det gick fel, meddelande: {0}", ex.Message);
        }
        finally
        {
            // Visa saldot...
            Console.WriteLine("Aktuellt saldo: {0}", account.GetBalance());
        }
    }
}
// ================================================
public class BankAccount
{
    // Vi behöver en variabel för att spara undan tillgängligt saldo...
    int balance = 0;

    public void Deposit(int value)
    {
        // Öka värdet på saldot...
        // balance = balance + value;
        balance += value;
    }

    public void Withdraw(int value)
    {
        // Minska värdet på saldot...
        // balance = balance - value;
        if (balance < value)
        {
            throw new Exception("Du har inte tillräckligt på kontot");
        }
        else
        {
            balance -= value;
        }
    }

    public int GetBalance()
    {
        return balance;
    }
}
