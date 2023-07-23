using FavoriteFilmListApp.Maui.Services;
using FavoriteFilmListApp.Maui.ViewModels;
using FavoriteFilmListApp.Maui.Views;
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

            #region SQLLite Configuration
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "movies.db3");
            builder.Services.AddSingleton<MovieService>(s => ActivatorUtilities
                .CreateInstance<MovieService>(s, dbPath));
            #endregion


            #region StaticList
            //For static list
            //builder.Services.AddSingleton<MovieService>(); 
            #endregion


            builder.Services.AddSingleton<MovieListViewModel>();
            builder.Services.AddTransient<MovieDetailsViewModel>();
            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddTransient<MovieDetailsPage>();






            return builder.Build();
        }
    }
}