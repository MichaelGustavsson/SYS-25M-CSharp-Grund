namespace atm;

public class Program
{
    public static void Main()
    {
        var account1 = new BankAccount();
        var account2 = new BankAccount();

        account1.Owner = "Daniel";
        account2.Owner = "Lillian";

        account1.Deposit(100);
        account2.Deposit(200);

        account1.Withdraw(25);
        account2.Withdraw(45);

        Console.WriteLine("Account 1 owner: {0} - balance: {1}", account1.Owner, account1.DisplayBalance());
        Console.WriteLine("Account 2 owner: {0} - balance: {1}", account2.Owner, account2.DisplayBalance());

        // ====================================================================================
        // BONUS...
        // ====================================================================================
        BankAccount[] accounts = [
            new BankAccount{Owner="Michael"},
            new BankAccount{Owner="Eva"},
            new BankAccount{Owner="Filip"},
            new BankAccount{Owner="Wilma"},
            new BankAccount{Owner="Olle"},
        ];

        Console.WriteLine("Första bank kontot i listan: {0}", accounts.First().Owner);
        Console.WriteLine("Sista bank kontot i listan: {0}", accounts.Last().Owner);

    }
}