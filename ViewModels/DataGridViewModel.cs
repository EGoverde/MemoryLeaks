using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using Syncfusion.Maui.ListView;

namespace MemoryLeaks;

public partial class DataGridViewModel : ObservableObject
{
    [ObservableProperty]
    private  ObservableCollection<OrderInfo> _orderInfoCollection;

    public DataGridViewModel()
    {
        OrderInfoCollection = new ObservableCollection<OrderInfo>();
        
        GenerateOrders();
    }

    public void GenerateOrders()
    {
        OrderInfoCollection.Add(new OrderInfo("1001", "Maria Anders", "Germany", "ALFKI", "Berlin"));
        OrderInfoCollection.Add(new OrderInfo("1002", "Ana Trujillo", "Mexico", "ANATR", "Mexico D.F."));
        OrderInfoCollection.Add(new OrderInfo("1003", "Ant Fuller", "Mexico", "ANTON", "Mexico D.F."));
        OrderInfoCollection.Add(new OrderInfo("1004", "Thomas Hardy", "UK", "AROUT", "London"));
        OrderInfoCollection.Add(new OrderInfo("1005", "Tim Adams", "Sweden", "BERGS", "London"));
        OrderInfoCollection.Add(new OrderInfo("1006", "Hanna Moos", "Germany", "BLAUS", "Mannheim"));
        OrderInfoCollection.Add(new OrderInfo("1007", "Andrew Fuller", "France", "BLONP", "Strasbourg"));
        OrderInfoCollection.Add(new OrderInfo("1008", "Martin King", "Spain", "BOLID", "Madrid"));
        OrderInfoCollection.Add(new OrderInfo("1009", "Lenny Lin", "France", "BONAP", "Marsiella"));
        OrderInfoCollection.Add(new OrderInfo("1010", "John Carter", "Canada", "BOTTM", "Lenny Lin"));
        OrderInfoCollection.Add(new OrderInfo("1011", "Laura King", "UK", "AROUT", "London"));
        OrderInfoCollection.Add(new OrderInfo("1012", "Anne Wilson", "Germany", "BLAUS", "Mannheim"));
        OrderInfoCollection.Add(new OrderInfo("1013", "Martin King", "France", "BLONP", "Strasbourg"));
        OrderInfoCollection.Add(new OrderInfo("1014", "Gina Irene", "UK", "AROUT", "London"));
    }
}