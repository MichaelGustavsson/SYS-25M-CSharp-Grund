namespace Bank.Persistence;

public class FileStorage
{
    public static void WriteFile(string path, string message)
    {
        File.AppendAllText(path, message);
    }
}
