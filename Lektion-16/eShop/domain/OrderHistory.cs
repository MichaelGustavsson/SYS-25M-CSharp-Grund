using Microsoft.VisualBasic;

namespace domain;

public enum OrderStatus
{
    Mottagen = 1,
    Plockas,
    Skickad,
    Levererad
}
public class OrderHistory
{
    public string OrderNumber { get; set; } = "";
    public DateTime OrderDate { get; set; }
    public OrderStatus Status { get; set; }
    public List<OrderItem> OrderItems { get; set; } = [];
}
