using domain;

namespace web;

public class JsonData<T>
{
    public static List<T> Get(string path)
    {
        var data = Storage<T>.ReadJson(path);
        return data;
    }

    public static void Save(string path, List<T> data)
    {
        Storage<T>.WriteJson(path, data);
    }
}
