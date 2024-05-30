namespace MemoryLeaks;

public partial class NoLeakPage : ContentPage
{
	private byte[] _memoryHog = new byte[100000000];

	public NoLeakPage()
	{
		InitializeComponent();
	}
}