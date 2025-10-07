using Bank.Domain.Models;

namespace Bank.Domain;

public class Company(string name, string orgNumber) : Customer
{
    public string Name { get; set; } = name;
    public string OrganizationNumber { get; set; } = orgNumber;

    public override string ToString()
    {
        return $"{Name}";
    }
}
