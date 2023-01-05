namespace Breakfast;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(CreateBreakfastPage), typeof(CreateBreakfastPage));
	}
}
