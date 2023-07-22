using FavoriteFilmListApp.Maui.ViewModels;

namespace FavoriteFilmListApp.Maui
{
    public partial class MainPage : ContentPage
    {
        
    

        public MainPage(MovieListViewModel movieListViewModel)
        {
            BindingContext = movieListViewModel;
            InitializeComponent();
        }

        
    }
}