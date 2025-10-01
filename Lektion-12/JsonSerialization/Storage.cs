using System.Text.Encodings.Web;
using System.Text.Json;

namespace JsonSerialization;

public class Storage
{
    private static JsonSerializerOptions _options = new()
    {
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        WriteIndented = true
    };

    public static void WriteJson(string path, Person person)
    {
        string json = JsonSerializer.Serialize(person, _options);
        File.WriteAllText(path, json);
    }

    public static Person ReadJson(string path)
    {
        _options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };

        var json = File.ReadAllText(path);
        Console.WriteLine(json);

        var person = JsonSerializer.Deserialize<Person>(json, _options);

        return person ?? new Person();
        // return person is null ? new Person() : person;
    }
}
