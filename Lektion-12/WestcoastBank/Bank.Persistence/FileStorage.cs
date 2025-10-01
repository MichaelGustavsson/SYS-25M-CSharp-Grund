namespace Bank.Persistence;

public class FileStorage
{
    public static void WriteFile(string path, string message)
    {
        File.AppendAllText(path, message);
    }

    public static IList<string> ReadFile(string path)
    {
        return File.ReadAllLines(path);
    }
}
