namespace FavoriteFilmListApp.Maui.Models;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public KindOfMovie KindOfMovie { get; set; }

}