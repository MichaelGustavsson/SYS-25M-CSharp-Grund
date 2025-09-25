namespace Domain;

public class MockRepository : IRepository
{
    public string Add()
    {
        return "Jag lägger till data i en fejk databas";
    }

    public string List()
    {
        return "Jag hämtar data ifrån en fejk databas";
    }
}
