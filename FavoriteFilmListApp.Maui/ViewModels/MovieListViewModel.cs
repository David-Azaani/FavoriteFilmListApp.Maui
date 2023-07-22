using System.Collections.ObjectModel;
using System.Diagnostics;
using CommunityToolkit.Mvvm.Input;
using FavoriteFilmListApp.Maui.Models;
using FavoriteFilmListApp.Maui.Services;

namespace FavoriteFilmListApp.Maui.ViewModels;

public partial class MovieListViewModel : BaseViewModel
{
    private readonly MovieService _movieService;
    public ObservableCollection<Movie> Movies { get; private set; } = new(); // for using Any()

    public MovieListViewModel(MovieService movieService)
    {
        Title = "Movies List";
        _movieService = movieService;
    }




    [RelayCommand]
    async Task GetMovieList()
    {
        if (IsLoading) return;
        try
        {
            IsLoading = true;

            if (Movies.Any()) Movies.Clear();

            var movies = _movieService.GetFilms();

            foreach (var movie in movies) Movies.Add(movie);
            


        }
        catch (Exception ex)
        {

            Debug.WriteLine($"Unable to get Movies : {ex.Message}");

            await Shell.Current.DisplayAlert("Error", "Failed to Retrieve List of Movies", "Ok");
        }
        finally
        {
            IsLoading = false;
        }



    }



}

