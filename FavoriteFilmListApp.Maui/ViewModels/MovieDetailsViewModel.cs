

using CommunityToolkit.Mvvm.ComponentModel;
using FavoriteFilmListApp.Maui.Models;

namespace FavoriteFilmListApp.Maui.ViewModels;

[QueryProperty(nameof(Movie),"Movie")]
    public partial class MovieDetailsViewModel:BaseViewModel
    {

        [ObservableProperty] 
         Movie movie;


         //public MovieDetailsViewModel()
         //{
         //    Title = $"Movie Details - {movie.Name},IMDB {movie.ImdbRate}";
         //}

    }

