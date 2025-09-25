using Bank.Domain.Models;

namespace Bank.Domain;

public class Company : Customer
{
    public string Name { get; set; }
    public string OrganizationNumber { get; set; }

    public Company(string name, string orgNumber)
    {
        Name = name;
        OrganizationNumber = orgNumber;
    }

    public override string ToString()
    {
        return $"{Name}";
    }
}
