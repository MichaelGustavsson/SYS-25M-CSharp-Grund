using Persistence;

namespace Domain;

public class Invoice
{
    public string InvoiceNumber { get; set; } = "";
    public DateTime InvoiceDate { get; set; }
    public DateTime DueDate { get; set; }
    public decimal InvoiceValue { get; set; }
    public Customer Customer { get; set; }
    public IList<InvoiceItem> InvoiceItems { get; private set; } = [];

    public Invoice(Customer customer)
    {
        InvoiceNumber = new Random().Next(10000, 33000).ToString();
        Customer = customer;
        InvoiceDate = DateTime.Now;
        DueDate = Customer is Business business ? DateTime.Now.AddDays(business.PaymentTerms) : DateTime.Now.AddDays(10);

        Save();
    }

    public void AddInvoiceItem(InvoiceItem item)
    {
        InvoiceItems.Add(item);
        InvoiceValue += item.LineSum;
    }

    public override string ToString()
    {
        return $"Fakturanr: {InvoiceNumber} - Fakturadatum: {InvoiceDate:d} Förfallodatum: {DueDate:d} Kund: {Customer} Att betala: {InvoiceValue:N2}";
    }

    private void Save()
    {
        List<string> invoices = [ToString()];

        FileStorage.Write($"{Environment.CurrentDirectory}/Data/invoices.log", invoices);
    }

    public static List<string> FetchInvoices()
    {
        return [.. FileStorage.Read($"{Environment.CurrentDirectory}/Data/invoices.log")];
    }
}
