namespace Bank.Domain.Models;

public abstract class Customer
{
    public Address? Address { get; set; }

    public Customer()
    {
        Address = new Address();
    }
}
