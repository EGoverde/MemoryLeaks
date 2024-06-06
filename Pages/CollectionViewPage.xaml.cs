namespace MemoryLeaks;

public partial class CollectionViewPage : BasePage
{
	public CollectionViewPage()
	{
		InitializeComponent();

		BindingContext = new CollectionViewModel();
	}
}