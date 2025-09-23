using domain.Models;

namespace client;

class Program
{
    static void Main()
    {
        Movie movie = new()
        {
            Title = "Batman",
            Description = "Test movie",
            Director = "Matt Reeves",
            Duration = 244,
            ReleaseYear = 2022,
            Categories =
            [
                new Category{Name = "Action"},
                new Category{Name = "Adventure"},
                new Category{Name = "Drama"},
            ]
        };

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("Movie info: --------------------------------------------");
        DisplayInfo(movie);
        Console.WriteLine("--------------------------------------------------------");
        Console.ResetColor();
        Console.WriteLine("");


        Show show = new()
        {
            Title = "Spin City",
            Description = "Fun sitcom with Michael J Fox",
            Episodes = 225,
            ReleaseYear = 1990,
            Categories = [
                new Category{Name="SitCom"},
                new Category{Name="Comedy"},
            ]
        };

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("TV-Show info: ------------------------------------------");
        DisplayInfo(show);
        Console.WriteLine("--------------------------------------------------------");
        Console.ResetColor();
    }

    private static void DisplayInfo(MovieFlixBase data)
    {
        Console.WriteLine(data);
        string categories = "";

        foreach (var category in data.Categories)
        {
            categories += $"{category.Name},";
        }

        Console.WriteLine($"\tCategories: {categories.Remove(categories.Length - 1)}");
    }
}
