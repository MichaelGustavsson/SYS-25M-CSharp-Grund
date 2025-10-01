namespace Bank.Application;

public interface IAccountService
{
    IList<string> FetchTransactions();
}
