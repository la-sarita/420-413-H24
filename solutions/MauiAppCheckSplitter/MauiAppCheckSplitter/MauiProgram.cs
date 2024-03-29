using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;

// This project is the content of a Pluralsight tutorial
// .NET MAUI: The Big Picture (https://app.pluralsight.com/library/courses/dot-net-maui-big-picture/table-of-contents) 
// It uses 'MAUI Community Toolkit' and ' MAUI Community Toolkit MVVM'


namespace MauiAppCheckSplitter
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                // Initialize the MAUI Community Toolkit
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                    fonts.AddFont("Kastore-Bold.ttf", "KastoreBold");
                });


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
