namespace Bank.Persistence;

public class FileStorage : IStorage
{
    public string Read(string path)
    {
        throw new NotImplementedException();
    }

    public void Write(string path, string data)
    {
        File.AppendAllText(path, data);
    }
}
