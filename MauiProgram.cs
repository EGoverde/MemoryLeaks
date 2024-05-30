using System.Diagnostics;
using MemoryToolkit.Maui;
using Microsoft.Extensions.Logging;
using Syncfusion.Maui.Core.Hosting;

namespace MemoryLeaks;

public static class MauiProgram
{
	public static string SyncFusionLicenseKey = string.Empty;

	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureSyncfusionCore()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			})
			.UseLeakDetection(collectionTarget =>
			{
				Debug.WriteLine($"❗🧟❗{collectionTarget.Name} is a zombie! 💦Leak Detected💦");

				if (collectionTarget.Name.Contains("Page"))
				{
					Application.Current?.MainPage?.DisplayAlert("Leak Detected", $"{collectionTarget.Name} is a zombie.", "OK");
				}
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
