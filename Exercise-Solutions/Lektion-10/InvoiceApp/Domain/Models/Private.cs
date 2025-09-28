namespace Domain;

public class Private : Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Private(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public override string ToString()
    {
        return $"Förnamn: {FirstName} Efternamn: {LastName} - {base.ToString()}";
    }
}
