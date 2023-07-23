using SQLite;

namespace FavoriteFilmListApp.Maui.Models;

public abstract class BaseEntity
{
    [PrimaryKey,AutoIncrement]
    public int Id { get; set; }
    public KindOfMovie KindOfMovie { get; set; }

}