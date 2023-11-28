using Microsoft.Extensions.Logging;

namespace PetApp
{
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
                    fonts.AddFont("Roboto-Black.ttf", "Roboto-Black");
                    fonts.AddFont("Roboto-Bold.ttf", "Roboto-Bold");
                    fonts.AddFont("Roboto-Light.ttf", "Roboto-Light");
                    fonts.AddFont("Roboto-Medium.ttf", "Roboto-Medium");
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}