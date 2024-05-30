using MemoryToolkit.Maui;
using Syncfusion.Maui.DataGrid;

namespace MemoryLeaks;

public class DataGridCSharpPage : ContentPage
{
	private byte[] _memoryHog = new byte[100000000];

	public DataGridCSharpPage()
	{
		Title = "DataGridCSharpPage";

		LeakMonitorBehavior.SetCascade(this, true);

		Content = new VerticalStackLayout
		{
			Padding = 40,
			Children = 
			{ 
				new SfDataGrid
				{
					MinimumHeightRequest = 100,
					MinimumWidthRequest = 450,
					BackgroundColor = Colors.LightGrey
				}
			}
		};
	}
}