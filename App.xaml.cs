namespace MemoryLeaks;

public partial class App : Application
{
	public App()
	{
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzE3MTM1QDMyMzAyZTMyMmUzMGJhK3VpeVAydm5ZWUtWbHprY3o3alhGejdTbXdSSXhwelBLZ01TTnN4ZkU9;NzE3MTM2QDMyMzAyZTMyMmUzMGJhK3VpeVAydm5ZWUtWbHprY3o3alhGejdTbXdSSXhwelBLZ01TTnN4ZkU9");

		InitializeComponent();

		MainPage = new NavigationPage(new MainPage());
	}
}