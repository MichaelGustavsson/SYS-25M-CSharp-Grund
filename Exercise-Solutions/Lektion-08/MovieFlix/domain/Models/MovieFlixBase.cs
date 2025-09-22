namespace domain.Models
{
    public class MovieFlixBase
    {
        public string Id { get; set; } = Guid.NewGuid().ToString().Replace("-", "");
        public required string Title { get; set; }
        public required string Description { get; set; }
        public int ReleaseYear { get; set; }
        public List<Category> Categories { get; set; } = [];

        public override string ToString()
        {
            return $"\tTitle: {Title}\n\tDescription: {Description}\n\tReleaseYear: {ReleaseYear}";
        }
    }
}