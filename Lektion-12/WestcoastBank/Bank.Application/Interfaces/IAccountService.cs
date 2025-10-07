using Bank.Domain;

namespace Bank.Application;

public interface IAccountService
{
    string FetchTransactions();
    void SaveAccount(Account account);
    Account GetAccount();
}
