namespace Persistence;

public class FileStorage
{
    static public void Write(string path, List<string> data)
    {
        File.AppendAllLines(path, data);
    }
    static public IList<string> Read(string path)
    {
        return File.ReadAllLines(path);
    }
}
