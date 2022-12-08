namespace maui_CarListApp;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();
	}
}
