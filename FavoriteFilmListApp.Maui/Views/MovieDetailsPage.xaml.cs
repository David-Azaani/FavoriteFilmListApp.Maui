using FavoriteFilmListApp.Maui.ViewModels;

namespace FavoriteFilmListApp.Maui.Views;

public partial class MovieDetailsPage : ContentPage
{
	public MovieDetailsPage(MovieDetailsViewModel movieDetailsViewModel)
	{
		InitializeComponent();

        BindingContext = movieDetailsViewModel;
       
         // Title = $"Movie Details - {movieDetailsViewModel.Movie.Name},IMDB {movieDetailsViewModel.Movie.ImdbRate}";
        

    }

    protected override void OnNavigatedTo(NavigatedToEventArgs args)
    {
        // Do fanciness


        base.OnNavigatedTo(args);
    }
}