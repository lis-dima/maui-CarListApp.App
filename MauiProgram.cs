using maui_CarListApp.Services;
using maui_CarListApp.ViewModels;
using maui_CarListApp.Views;
using Microsoft.Extensions.Logging;

namespace maui_CarListApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		
		builder.Services.AddSingleton<CarService>();

		builder.Services.AddSingleton<CarListViewModel>();
        builder.Services.AddTransient<CarDetailsVeiwModel>();

		builder.Services.AddSingleton<MainPage>();
		builder.Services.AddTransient<CarDetailsPage>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
