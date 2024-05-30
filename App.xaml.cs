namespace MemoryLeaks;

public partial class App : Application
{
	public App()
	{
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(MauiProgram.SyncFusionLicenseKey);

		InitializeComponent();

		MainPage = new NavigationPage(new MainPage());
	}
}