namespace JsonSerialization;

class Program
{
    static void Main()
    {
        /* 
            Att skapa ett objekt ifrån Person klassen och lägga till en adress.
            Sedan ska detta skrivas ner till disk som ett json objekt => text...
        */
        var address = new Address
        {
            AddressLine = "Hålvägen 1",
            PostalCode = "123 45",
            City = "Hålan"
        };

        var erik = new Person
        {
            FirstName = "Erik",
            LastName = "Larsson",
            Email = "erik@gmail.com",
            Phone = "010-1111111",
            Age = 25,
            Address = address
        };

        Storage.WriteJson($"{Environment.CurrentDirectory}/Data/personInfo.json", erik);
        var person = Storage.ReadJson($"{Environment.CurrentDirectory}/Data/personInfo.json");

        person.Phone = "070-4567890";

        Storage.WriteJson($"{Environment.CurrentDirectory}/Data/personInfo.json", person);
    }
}
