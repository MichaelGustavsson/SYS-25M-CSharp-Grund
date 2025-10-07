namespace Bank.Persistence;

public interface IStorage
{
    void Write(string path, string data);
    string Read(string path);
}
