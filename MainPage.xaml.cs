using maui_CarListApp.ViewModels;

namespace maui_CarListApp;

public partial class MainPage : ContentPage
{

	public MainPage(CarListViewModel carListViewModel)
	{
		InitializeComponent();
		BindingContext = carListViewModel;
    }

}

