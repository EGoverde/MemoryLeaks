namespace MemoryLeaks;

public partial class DataGridEmptyPage : ContentPage
{
	private byte[] _memoryHog = new byte[100000000];

	public DataGridEmptyPage()
	{
		InitializeComponent();
	}
}