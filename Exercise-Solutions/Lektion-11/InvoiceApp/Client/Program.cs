using Domain;

namespace Client;

class Program
{
    static void Main()
    {
        var storedInvoices = Invoice.FetchInvoices();
        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        foreach (var invoice in storedInvoices)
        {
            Console.WriteLine(invoice);
        }
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("");
        Console.ResetColor();
        // Create an invoice...
        // 1.   First create a new private customer...
        Customer customer_1 = new Private("Erik", "Persson")
        {
            DeliveryAddress = new Address { AddressLine = "Snickarvägen 1", PostalCode = "333 56", City = "Tollarp" },
            InvoiceAddress = new Address { AddressLine = "Snickarvägen 1", PostalCode = "333 56", City = "Tollarp" },
            Phone = "0790-44 56 78",
            Reference = "Erik Persson"
        };

        Invoice invoice_1 = new(customer_1);

        // Add som invoice items...
        Product product = Products.FindProduct("AA1111-1");
        invoice_1.AddInvoiceItem(new InvoiceItem(2, product));
        product = Products.FindProduct("BB5777-1");
        invoice_1.AddInvoiceItem(new InvoiceItem(1, product));

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Fakturar information:");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine(invoice_1);
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("");

        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Fakturarader:");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        // Iterate through invoiceItems...
        foreach (var item in invoice_1.InvoiceItems)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine("");

        // Next lets try with a business customer...
        Customer customer_2 = new Business("Skaftö Bageri")
        {
            Reference = "Michael Gustavsson",
            DeliveryAddress = new Address { AddressLine = "Bagaregatan 15", PostalCode = "444 21", City = "Smörriket" },
            InvoiceAddress = new Address { AddressLine = "Bagaregatan 12", PostalCode = "444 21", City = "Smörriket" }
        };

        Invoice invoice_2 = new(customer_2);

        // Add some invoice items...
        product = Products.FindProduct("AA2222-3");
        invoice_2.AddInvoiceItem(new InvoiceItem(1, product));
        product = Products.FindProduct("BB3666-9");
        invoice_2.AddInvoiceItem(new InvoiceItem(1, product));

        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("Fakturar information:");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.WriteLine(invoice_2);
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");

        Console.WriteLine("");
        Console.ForegroundColor = ConsoleColor.DarkCyan;
        Console.WriteLine("Fakturarader:");
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        // Iterate through invoiceItems...
        foreach (var item in invoice_2.InvoiceItems)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine("--------------------------------------------------------------------------------------------------------------------------------------------------------------------");
        Console.ResetColor();
    }
}
