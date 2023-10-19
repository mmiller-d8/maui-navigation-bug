using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using NavigationBug.Extensions;
using NavigationBug.ViewModels;

namespace NavigationBug;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
            .UseMauiCommunityToolkit()
            .ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services
            .AddDerivedTypes<ViewModel>("ViewModel")
			.AddDerivedTypes<ContentPage>("Page");

#if DEBUG
        builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

