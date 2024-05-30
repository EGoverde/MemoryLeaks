using MemoryToolkit.Maui;

namespace MemoryLeaks;

public abstract class BasePage : ContentPage
{
	private byte[] _memoryHog = new byte[100000000];

	public BasePage()
	{
		LeakMonitorBehavior.SetCascade(this, true);
	}
}