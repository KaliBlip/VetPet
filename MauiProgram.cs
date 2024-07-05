using Microsoft.Extensions.Logging;
using UraniumUI;


namespace VetPet;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder

            .UseUraniumUI()
			.UseUraniumUIMaterial() // 👈 Don't forget these two lines.


            .UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                fonts.AddFont("MaterialIcons-Regular.ttf", "MaterialRegular");
                fonts.AddFont("GaMaamli-Regular.ttf", "GaMaamli");

            });

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}
