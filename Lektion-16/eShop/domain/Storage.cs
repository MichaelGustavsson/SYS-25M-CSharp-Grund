using System.Text.Encodings.Web;
using System.Text.Json;

namespace domain;

public class Storage<T>
{
    private static JsonSerializerOptions _options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        WriteIndented = true,
        PropertyNameCaseInsensitive = true
    };

    public static List<T> ReadJson(string path)
    {
        var json = File.ReadAllText(path);
        var data = JsonSerializer.Deserialize<List<T>>(json, _options);
        return data ?? [];
    }

    public static void WriteJson(string path, List<T> data)
    {
        var json = JsonSerializer.Serialize(data, _options);
        File.WriteAllText(path, json);
    }
}
