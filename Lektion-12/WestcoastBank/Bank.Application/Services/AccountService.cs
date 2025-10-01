

using Bank.Persistence;

namespace Bank.Application;

public class AccountService(string path) : IAccountService
{
    private readonly string _path = path;

    public IList<string> FetchTransactions()
    {
        return FileStorage.ReadFile(_path);
    }
}
