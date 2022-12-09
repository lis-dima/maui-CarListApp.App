using maui_CarListApp.ViewModels;

namespace maui_CarListApp.Views;

public partial class CarDetailsPage : ContentPage
{
	public CarDetailsPage(CarDetailsVeiwModel carDetailsVeiwModel)
	{
		InitializeComponent();
		BindingContext  = carDetailsVeiwModel;
    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        base.OnNavigatedTo(args);
    }
}