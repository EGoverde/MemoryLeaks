using Syncfusion.Maui.DataGrid;

namespace MemoryLeaks;

public class DataGridCSharpPage : BasePage
{
	public DataGridCSharpPage()
	{
		Title = "DataGridCSharpPage";

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