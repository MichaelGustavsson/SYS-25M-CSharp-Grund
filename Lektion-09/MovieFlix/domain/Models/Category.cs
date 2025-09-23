namespace domain.Models;

public class Category
{
    public string Id { get; set; } = Guid.NewGuid().ToString().Replace("-", "");
    public required string Name { get; set; }
}
