namespace Domain;

public class DbRepository : IRepository
{
    public string Add()
    {
        return "Jag lägger till data i en riktig databas";
    }

    public string List()
    {
        return "Jag hämtar data ifrån en riktig databas";
    }
}
