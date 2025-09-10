namespace decisions_and_loops;

class Program
{
    // Applikationens EntryPoint...
    static void Main()
    {
        // ========================================================
        // if och else, else if
        // ========================================================
        int x = 3;

        if (x < 5)
        {
            // Om x är mindre än 5 så hamnar vi här
            Console.WriteLine("x = {0},alltså mindre än 5", x);
            Console.WriteLine("x = {0}, också x = {1},alltså mindre än 5", x, x);
            Console.WriteLine($"x = {x},alltså mindre än 5");
            if (x == 2)
            {

            }
        }
        else if (x == 4)
        {

        }
        else
        {
            // x är inte mindre än 5
        }

        var ok = x < 5 ? "Mindre än 5" : "Inte mindre än 5";

        // ===========================================================
        // Switch case alternativ till if else if else if...
        // ===========================================================
        switch (x)
        {
            case 1:
                // Gör något
                break;
            case 2:
                // Gör något annat...
                break;
            default:
                // Fanns ingen träff
                break;
        }

        // ===========================================================
        // Iterationer = loopar...
        // ===========================================================
        // Den klassiska varianten...
        for (int y = 0; y < 10; y++) { }

        string[] vehicles = ["Volvo", "Fiat", "Ford", "Kia", "Volkswagen"];
        // Mer moderna varianten...
        foreach (var vehicle in vehicles)
        {
            // Gör något med varje bil...
        }

        List<string> movies = new List<string>
        {
            "Fantomen",
            "Batman",
            "Bucket list"
        };

        movies.Add("Svampbob");

        // Deklaration = skapa en lista som heter movies som
        // lagrar strängar...
        // List<string> movies = new List<string>();
        // movies.Add("Fantomen");
        // movies.Add("Batman");
        // movies.Add("Bucket list");

        // List<string> movies = ["Fantomen", "Batman", "Bucket list"];

        // movies.ForEach(() => { });

        // Klassikerna ända tillbaka till windows 3.11(C)
        // while loopen
        int i = 0;
        while (i < 5)
        {
            // Gör något...
            i++;
        }

        // do while loopen...
        do
        {
            // Garanterade att alltid köra minst en gång.
            i++;
        } while (i < 5);

        // Defensiv kodning...
        // if är en del av defensiv programmering...
        // try catch finally...
        try
        {
            // försök att göra detta...
        }
        catch (NullReferenceException ex)
        {

        }
        catch (ArgumentNullException ex)
        {

        }
        catch (Exception ex)
        {

        }
        // catch
        // {
        //     // Här hamnar vi om det inte gick att göra...
        // }
        finally
        {
            // Här hamnar vi alltid oavsett vad som händer ovan...
            // Städa upp efter oss...
        }
    }


}
