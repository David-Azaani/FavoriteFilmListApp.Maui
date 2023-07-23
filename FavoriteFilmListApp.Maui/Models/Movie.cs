

using SQLite;

namespace FavoriteFilmListApp.Maui.Models;



[Table("Movies")]
public class Movie:BaseEntity
{

    public string Name { get; set; }
    public int TotalSeasonNumber { get; set; }
    public int WatchedSeason { get; set; }
    public int WatchedPart { get; set; }
    public string ImdbRate { get; set; }
  
    public DateTime CreatedYear { get; set; }

}  



//[MaxLength(12),Unique]