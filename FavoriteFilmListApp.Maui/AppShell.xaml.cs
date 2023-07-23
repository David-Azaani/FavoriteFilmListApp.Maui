﻿using FavoriteFilmListApp.Maui.Views;

namespace FavoriteFilmListApp.Maui
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute(nameof(MovieDetailsPage),typeof(MovieDetailsPage));
        }
    }
}