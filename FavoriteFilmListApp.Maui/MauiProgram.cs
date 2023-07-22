using FavoriteFilmListApp.Maui.Services;
using FavoriteFilmListApp.Maui.ViewModels;
using Microsoft.Extensions.Logging;

namespace FavoriteFilmListApp.Maui
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
                });

#if DEBUG
		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<MovieService>();
            builder.Services.AddSingleton<MovieListViewModel>();
            builder.Services.AddSingleton<MainPage>();

            return builder.Build();
        }
    }
}