

using FavoriteFilmListApp.Maui.Models;

namespace FavoriteFilmListApp.Maui.Services;

public class MovieService
{
    public List<Movie> GetFilms()
    {
        return new List<Movie>
            {

                new Movie
                {   Id = 1,
                    Name = "Spider Man",
                    ImdbRate = "9.5",
                    CreatedYear = DateTime.Today.AddYears(-5),
                    KindOfMovie = KindOfMovie.Film,
                    TotalSeasonNumber = 0,
                    WatchedPart = 1,
                    WatchedSeason = 0

                },new Movie
                {   Id = 2,
                    Name = "Driver",
                    ImdbRate = "6",
                    CreatedYear = DateTime.Today.AddYears(-1),
                    KindOfMovie = KindOfMovie.Film,
                    TotalSeasonNumber = 0,
                    WatchedPart = 1,
                    WatchedSeason = 0

                },
                new Movie
                {   Id = 3,
                    Name = "Dark",
                    ImdbRate = "9",
                    CreatedYear = DateTime.Today.AddYears(-5),
                    KindOfMovie = KindOfMovie.Serial,
                    TotalSeasonNumber = 3,
                    WatchedPart = 5,
                    WatchedSeason = 2

                },
                new Movie
                {   Id = 4,
                    Name = "Dark Wind",
                    ImdbRate = "7",
                    CreatedYear = DateTime.Today.AddYears(-8),
                    KindOfMovie = KindOfMovie.Serial,
                    TotalSeasonNumber = 3,
                    WatchedPart = 8,
                    WatchedSeason = 3

                }



            };

    }
}

