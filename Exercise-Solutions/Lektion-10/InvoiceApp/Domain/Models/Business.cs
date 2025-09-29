namespace Domain;

public class Business(string companyName) : Customer
{
    public string CompanyName { get; set; } = companyName;
    public int PaymentTerms { get; set; } = 30;

    public override string ToString()
    {
        return $"Kundnamn: {CompanyName} Betalningsvillkor: {PaymentTerms} - {base.ToString()}";
    }
}
