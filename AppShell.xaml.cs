using maui_CarListApp.Views;

namespace maui_CarListApp;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

		Routing.RegisterRoute(nameof(CarDetailsPage), typeof(CarDetailsPage));
	}
}
