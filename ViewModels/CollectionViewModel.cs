namespace MemoryLeaks;

using CommunityToolkit.Mvvm.ComponentModel;

public partial class CollectionViewModel : ObservableObject
{
    [ObservableProperty]
    private IList<string> _items = new List<string>
    {
        "One",
        "Two",
        "Three",
        "Four",
        "Five"
    };
}