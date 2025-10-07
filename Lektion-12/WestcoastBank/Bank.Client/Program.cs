using Bank.Application;
using Bank.Domain;
using Bank.Domain.Models;

namespace Bank.Client;

class Program
{
    static void Main()
    {
        AccountService accountService =
            new($"{Environment.CurrentDirectory}/Data/accountInfo.json");

        // Add customer and account...
        var customer = new Private()
        {
            FirstName = "Kalle",
            LastName = "Olsson",
            SocialSecurityNumber = "1990-02-12",
            Address = new Address()
            {
                AddressLine = "Hålvägen 1",
                PostalCode = "111 22",
                City = "Hålan",
                Country = "Sverige"
            }
        };

        var account = new BankAccount(500)
        {
            Owner = customer
        };

        accountService.SaveAccount(account);

        // Fetch an account...
        var result = accountService.GetAccount();
        Console.WriteLine(result);
    }
}
