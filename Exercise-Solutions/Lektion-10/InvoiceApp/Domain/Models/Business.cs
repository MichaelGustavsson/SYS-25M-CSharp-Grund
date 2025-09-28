namespace Domain;

public class Business : Customer
{
    public string CompanyName { get; set; }
    public int PaymentTerms { get; set; }

    public Business(string companyName)
    {
        CompanyName = companyName;
        PaymentTerms = 30;
    }

    public override string ToString()
    {
        return $"Kundnamn: {CompanyName} Betalningsvillkor: {PaymentTerms} - {base.ToString()}";
    }
}
