using Bank.Domain.Models;

namespace Bank.Domain;

public class Private : Customer
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string SocialSecurityNumber { get; set; }

    public Private(string firstName, string lastName, string ssn)
    {
        FirstName = firstName;
        LastName = lastName;
        SocialSecurityNumber = ssn;
    }

    public override string ToString()
    {
        return $"{FirstName} {LastName}";
    }

}
