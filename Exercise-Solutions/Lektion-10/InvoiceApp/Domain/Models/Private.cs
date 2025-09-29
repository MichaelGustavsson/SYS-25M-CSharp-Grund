namespace Domain;

public class Private(string firstName, string lastName) : Customer
{
    public string FirstName { get; set; } = firstName;
    public string LastName { get; set; } = lastName;

    public override string ToString()
    {
        return $"Förnamn: {FirstName} Efternamn: {LastName} - {base.ToString()}";
    }
}
