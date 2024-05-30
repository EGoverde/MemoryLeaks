namespace MemoryLeaks;

public partial class ListViewPage : ContentPage
{
	private byte[] _memoryHog = new byte[100000000];

	public ListViewPage()
	{
		InitializeComponent();
	}
}