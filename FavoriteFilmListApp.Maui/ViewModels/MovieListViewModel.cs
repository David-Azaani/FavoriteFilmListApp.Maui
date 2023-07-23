using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text.Json;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using FavoriteFilmListApp.Maui.Models;
using FavoriteFilmListApp.Maui.Services;
using FavoriteFilmListApp.Maui.Views;


namespace FavoriteFilmListApp.Maui.ViewModels;

public partial class MovieListViewModel : BaseViewModel
{
    //Static List
    //private readonly MovieService _movieService;
    public ObservableCollection<Movie> Movies { get; private set; } = new(); // for using Any()

    public MovieListViewModel(MovieService movieService)
    {
        Title = "Movies List";
        //Static List
        //_movieService = movieService;
    }

    [ObservableProperty]
    bool isRefreshing;


    [RelayCommand]
    async Task GetMovieList()
    {
        if (IsLoading) return;
        try
        {
            IsLoading = true;

            if (Movies.Any()) Movies.Clear();
            // Static List
            //  var movies = _movieService.GetFilms();

            // SqlLite
            var movies = App.MovieService.GetMovies();

            foreach (var movie in movies) Movies.Add(movie);



            #region Storage #2
            //string fileName = "movieList.json";
            //var serializedData = JsonSerializer.Serialize(movies);
            //File.WriteAllText(fileName,serializedData);


            //var rawText = File.ReadAllText(fileName);
            //var carFromtext = JsonSerializer.Deserialize<List<Movie>>(rawText);

            //string path = FileSystem.AppDataDirectory;
            //string folder = Environment.GetFolderPath(Environment.SpecialFolder.MyComputer); 
            #endregion



        }
        catch (Exception ex)
        {

            Debug.WriteLine($"Unable to get Movies : {ex.Message}");

            await Shell.Current.DisplayAlert("Error", "Failed to Retrieve List of Movies", "Ok");
        }
        finally
        {
            IsLoading = false;
            IsRefreshing = false;
        }



    }


    [RelayCommand]
    async Task GetMovieDetails(Movie movie)
    {

        if (movie == null) return;

        await Shell.Current.GoToAsync(nameof(MovieDetailsPage),
            true, new Dictionary<string, object>()
            {
                {nameof(Movie),movie}

            });


    }


}

