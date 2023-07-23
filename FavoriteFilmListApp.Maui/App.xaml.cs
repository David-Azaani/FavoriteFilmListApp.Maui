using FavoriteFilmListApp.Maui.Services;

namespace FavoriteFilmListApp.Maui;

    public partial class App : Application
    {
        public static MovieService MovieService { get; private set; }

        public App(MovieService movieService)
        {
            MovieService = movieService;
            InitializeComponent();

            MainPage = new AppShell();
        }
    }
