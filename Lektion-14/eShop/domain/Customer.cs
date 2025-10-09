namespace domain;

public class Customer
{
    public string FirstName { get; set; } = "";
    public string LastName { get; set; } = "";
    public string Phone { get; set; } = "";
    public string Email { get; set; } = "";
    // Aggregation, en list av adresser hanteras
    // av Customer klassen...
    public List<Address> Addresses { get; set; } = [];
    public List<OrderHistory> OrderHistories { get; set; } = [];
}
