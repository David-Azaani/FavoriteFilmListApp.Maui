using FavoriteFilmListApp.Maui.ViewModels;

namespace FavoriteFilmListApp.Maui
{
    public partial class MainPage : ContentPage
    {
        
    

        public MainPage(MovieListViewModel movieListViewModel)
        {
            BindingContext = movieListViewModel;
            InitializeComponent();


            
            #region Storage #1
            // Local Storage
            //Preferences.Set("saveDetails",true);
            //var savedData = Preferences.Get("saveDetails",false); 
            #endregion


        }

        
    }
}