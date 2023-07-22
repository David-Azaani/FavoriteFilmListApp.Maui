

using CommunityToolkit.Mvvm.ComponentModel;
namespace FavoriteFilmListApp.Maui.ViewModels;
public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    string _title;

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(IsNotLoading))]
    bool _isLoading;


    public bool IsNotLoading => !_isLoading;


}

