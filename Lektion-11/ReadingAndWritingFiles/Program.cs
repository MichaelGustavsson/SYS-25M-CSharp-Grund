namespace ReadingAndWritingFiles;

class Program
{
    static void Main()
    {
        // ./data - Relativ sökväg

        // Absolut sökväg => hela vägen i filsystemet...
        var path = $"{Environment.CurrentDirectory}/data/log.txt";
        Console.WriteLine("Aktuell sökväg är: {0}", path);

        // string message = $"\n\tDetta är en indenterad rad: {DateTime.Now:d}\n";
        // IList<string> messages = ["Nisse", "Jonatan", "Lilly"];

        // // File.WriteAllText(path, message);
        // // File.AppendAllText(path, message);
        // File.AppendAllLines(path, messages);

        // string fileText = File.ReadAllText(path);

        // Console.WriteLine($"{fileText} fanns i filen...");

        // ===============================================================
        // Använda Stream klasserna för att läsa och skriva till filer...
        // ===============================================================

        using StreamWriter sw = new(path);
        string message = "Använder StreamWriter till skriva till fil.";
        sw.WriteLine(message);

        message = "Kör en gång till!";
        sw.WriteLine(message);
        // Glömmer inte att stänga ner StreamWriter instansen...
        sw.Close();

        // Läsa in via StreamReader...
        using StreamReader sr = new(path);
        string text = sr.ReadToEnd();
        Console.WriteLine(text);
        sr.Close();
    }
}
