using Bank.Domain.Models;

namespace Bank.Domain;

// public class Private(string firstName, string lastName, string ssn) : Customer
public class Private() : Customer
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string SocialSecurityNumber { get; set; } = "";

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }

}
