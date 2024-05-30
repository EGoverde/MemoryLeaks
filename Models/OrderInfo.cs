namespace MemoryLeaks;

public class OrderInfo
{
    public OrderInfo(string orderId, string customerId, string country, string customer, string shipCity)
    {
        OrderID = orderId;
        CustomerID = customerId;
        Customer = customer;
        ShipCountry = country;
        ShipCity = shipCity;
    }

    public string OrderID { get; set; }

    public string CustomerID { get; set; }

    public string ShipCountry { get; set; }

    public string Customer { get; set; }

    public string ShipCity { get; set; }
}