using Microsoft.Extensions.Logging;
using MoonNFTApp.Services;
using MoonNFTApp.ViewModels;
using MoonNFTApp.Views;

namespace MoonNFTApp;

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

                fonts.AddFont("Teko-Bold.ttf", "TekoBold");
                fonts.AddFont("Teko-Light.ttf", "TekoLight");
                fonts.AddFont("Teko-Medium.ttf", "TekoMedium");
                fonts.AddFont("Teko-Regular.ttf", "TekoRegular");
                fonts.AddFont("Teko-SemiBold.ttf", "TekoSemiBold");
            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

        builder.Services.AddSingleton<NFTService>();
        builder.Services.AddSingleton<MainViewModel>();
        builder.Services.AddSingleton<MainView>();

        return builder.Build();
	}
}