namespace MemoryLeaks;

public partial class DataGridPage : ContentPage
{
	private byte[] _memoryHog = new byte[100000000];

	public DataGridPage()
	{
		InitializeComponent();

		BindingContext = new DataGridViewModel();
	}
}