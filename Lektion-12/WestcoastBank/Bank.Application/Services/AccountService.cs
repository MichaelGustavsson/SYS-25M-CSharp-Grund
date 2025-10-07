using System.Text.Encodings.Web;
using System.Text.Json;

using Bank.Domain;
using Bank.Domain.Models;
using Bank.Persistence;

namespace Bank.Application;

public class AccountService(string path) : IAccountService
{
    private readonly string _path = path;
    private readonly JsonStorage _jsonStorage = new();
    private readonly JsonSerializerOptions _options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        WriteIndented = true,
        PropertyNameCaseInsensitive = true
    };

    public string FetchTransactions()
    {
        FileStorage fileStorage = new();
        return fileStorage.Read(_path);
    }

    public Account GetAccount()
    {
        var json = _jsonStorage.Read(_path);
        var account = JsonSerializer.Deserialize<Account>(json, _options);
        return account ?? new Account();
    }

    public void SaveAccount(Account account)
    {
        var json = JsonSerializer.Serialize(account, _options);
        _jsonStorage.Write(_path, json);
    }
}
