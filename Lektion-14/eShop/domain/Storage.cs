using System.Text.Encodings.Web;
using System.Text.Json;

namespace domain;

public class Storage
{
    private static JsonSerializerOptions _options = new()
    {
        PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        WriteIndented = true,
        PropertyNameCaseInsensitive = true
    };

    public static List<Product> ReadProductsJson(string path)
    {
        var json = File.ReadAllText(path);
        var products = JsonSerializer.Deserialize<List<Product>>(json, _options);
        return products ?? [];
    }

    public static void WriteProductsJson(string path, List<Product> products)
    {
        var json = JsonSerializer.Serialize(products, _options);
        File.WriteAllText(path, json);
    }
}
