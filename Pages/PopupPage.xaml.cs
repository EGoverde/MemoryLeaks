namespace MemoryLeaks;

public partial class PopupPage : BasePage
{
	public PopupPage()
	{
		InitializeComponent();
	}

	private void ClickToShowPopup_Clicked(object sender, EventArgs e)
	{
		popup.Show();
	}
}