using Bank.Application;

namespace Bank.Client;

class Program
{
    static void Main()
    {
        AccountService accountService =
            new($"{Environment.CurrentDirectory}/Data/Transactions.txt");

        var transactions = accountService.FetchTransactions();

        foreach (var item in transactions)
        {
            Console.WriteLine(item);
        }
    }
}
