using FavoriteFilmListApp.Maui.Models;
using SQLite;

namespace FavoriteFilmListApp.Maui.Services;

public class MovieService
{
    SQLiteConnection conn;
    string _dbPath;
    public string _statusMessage;
    public MovieService(string dbPath)
    {
        _dbPath = dbPath;
    }


    private void Init()
    {
        if (conn != null) return;
        conn = new SQLiteConnection(_dbPath);
        conn.CreateTable<Movie>();


    }

    public List<Movie> GetMovies()
    {

        try
        {
            Init();
            return conn.Table<Movie>().ToList();
        }
        catch (Exception e)
        {
            _statusMessage = "Failed to retrieve data . ";
        }

        return new List<Movie>();
    }

    #region Becauseof Sqlite

    //public List<Movie> GetFilms()
    //{
    //    return new List<Movie>
    //        {

    //            new Movie
    //            {   Id = 1,
    //                Name = "Spider Man",
    //                ImdbRate = "9.5",
    //                CreatedYear = DateTime.Today.AddYears(-5),
    //                KindOfMovie = KindOfMovie.Film,
    //                TotalSeasonNumber = 0,
    //                WatchedPart = 1,
    //                WatchedSeason = 0

    //            },new Movie
    //            {   Id = 2,
    //                Name = "Driver",
    //                ImdbRate = "6",
    //                CreatedYear = DateTime.Today.AddYears(-1),
    //                KindOfMovie = KindOfMovie.Film,
    //                TotalSeasonNumber = 0,
    //                WatchedPart = 1,
    //                WatchedSeason = 0

    //            },
    //            new Movie
    //            {   Id = 3,
    //                Name = "Dark",
    //                ImdbRate = "9",
    //                CreatedYear = DateTime.Today.AddYears(-5),
    //                KindOfMovie = KindOfMovie.Serial,
    //                TotalSeasonNumber = 3,
    //                WatchedPart = 5,
    //                WatchedSeason = 2

    //            },
    //            new Movie
    //            {   Id = 4,
    //                Name = "Dark Wind",
    //                ImdbRate = "7",
    //                CreatedYear = DateTime.Today.AddYears(-8),
    //                KindOfMovie = KindOfMovie.Serial,
    //                TotalSeasonNumber = 3,
    //                WatchedPart = 8,
    //                WatchedSeason = 3

    //            },
    //            new Movie
    //            {   Id = 5,
    //                Name = "Hero",
    //                ImdbRate = "7.5",
    //                CreatedYear = DateTime.Today.AddYears(-8),
    //                KindOfMovie = KindOfMovie.Serial,
    //                TotalSeasonNumber = 3,
    //                WatchedPart = 8,
    //                WatchedSeason = 3

    //            },
    //            new Movie
    //            {   Id = 6,
    //                Name = "Killing",
    //                ImdbRate = "7",
    //                CreatedYear = DateTime.Today.AddYears(-8),
    //                KindOfMovie = KindOfMovie.Serial,
    //                TotalSeasonNumber = 3,
    //                WatchedPart = 8,
    //                WatchedSeason = 3

    //            },
    //            new Movie
    //            {   Id = 7,
    //                Name = "Boren",
    //                ImdbRate = "9",
    //                CreatedYear = DateTime.Today.AddYears(-8),
    //                KindOfMovie = KindOfMovie.Serial,
    //                TotalSeasonNumber = 3,
    //                WatchedPart = 8,
    //                WatchedSeason = 3

    //            },
    //            new Movie
    //            {   Id = 8,
    //                Name = "BobSponge",
    //                ImdbRate = "9",
    //                CreatedYear = DateTime.Today.AddYears(-8),
    //                KindOfMovie = KindOfMovie.Serial,
    //                TotalSeasonNumber = 3,
    //                WatchedPart = 8,
    //                WatchedSeason = 3

    //            },
    //            new Movie
    //            {   Id = 9,
    //                Name = "Reality",
    //                ImdbRate = "6",
    //                CreatedYear = DateTime.Today.AddYears(-8),
    //                KindOfMovie = KindOfMovie.Serial,
    //                TotalSeasonNumber = 3,
    //                WatchedPart = 8,
    //                WatchedSeason = 3

    //            },
    //            new Movie
    //            {   Id = 10,
    //                Name = "Pagan Peak",
    //                ImdbRate = "9",
    //                CreatedYear = DateTime.Today.AddYears(-8),
    //                KindOfMovie = KindOfMovie.Serial,
    //                TotalSeasonNumber = 3,
    //                WatchedPart = 8,
    //                WatchedSeason = 3

    //            }



    //        };

    //} 

    #endregion
}

