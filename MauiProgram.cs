﻿using Microsoft.Extensions.Logging;
using UraniumUI;


namespace GreenChat;

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

                fonts.AddFont("Kanit-Black.ttf", "KanitBlack");
                fonts.AddFont("Kanit-Regular.ttf", "KanitRegular");
                fonts.AddFont("Kanit-Bold.ttf", "KanitBold");
                fonts.AddFont("Kanit-ExtraBold.ttf", "KanitExtraBold");
                fonts.AddFont("Kanit-ExtraBoldItalic.ttf", "KanitExtraBoldItalic");
                fonts.AddFont("Kanit-Light.ttf", "KanitLight");
                fonts.AddFont("Kanit-ExtraLight.ttf", "KanitExtraLight");

            });



#if DEBUG
		builder.Logging.AddDebug();
#endif

        // Add DbContext as a service
        builder.Services.AddDbContext<VetPetContext>();

        return builder.Build();
	}
}
