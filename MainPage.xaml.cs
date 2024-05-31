namespace MemoryLeaks;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

		_ = ReloadMemoryAsync();
    }

    private async Task ReloadMemoryAsync()
	{
		LabelMemoryTracker.Text = "Current Memory Usage: Calculating...";

		await Task.Delay(TimeSpan.FromMilliseconds(500));

		GC.Collect();
        GC.WaitForPendingFinalizers();
		
		var currentMemoryInBytes = GC.GetTotalMemory(true);

		LabelMemoryTracker.Text = $"Current Memory Usage: {ConvertByteCountToString(currentMemoryInBytes)}";
	}

	private void OnNoLeakPageButtonClicked(object sender, EventArgs e)
	{
		_ = Navigation.PushAsync(new NoLeakPage());
	}

	private void OnDataGridPageButtonClicked(object sender, EventArgs e)
	{
		_ = Navigation.PushAsync(new DataGridPage());
	}

	private void OnDataGridEmptyPageButtonClicked(object sender, EventArgs e)
	{
		_ = Navigation.PushAsync(new DataGridEmptyPage());
	}

	private void OnListViewPageButtonClicked(object sender, EventArgs e)
	{
		_ = Navigation.PushAsync(new ListViewPage());
	}

	private void OnPopupPageButtonClicked(object sender, EventArgs e)
	{
		_ = Navigation.PushAsync(new PopupPage());
	}

	private static string ConvertByteCountToString(long? byteCount)
    {
        if (byteCount == null)
        {
            return "Unknown";
        }

        string[] suf = { " B", " KB", " MB", " GB", " TB", " PB", " EB" }; //Longs run out around EB

        if (byteCount == 0)
        {
            return "0" + suf[0];
        }
            
        var bytes = Math.Abs(byteCount.Value);
        var place = Convert.ToInt32(Math.Floor(Math.Log(bytes, 1024)));
        var num = Math.Round(bytes / Math.Pow(1024, place), 1);

        return (Math.Sign(byteCount.Value) * num).ToString() + suf[place];
    }
}