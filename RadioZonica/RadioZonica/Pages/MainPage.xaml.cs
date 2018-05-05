﻿using Xamarin.Forms;

namespace RadioZonica.Pages
{
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();

            Master = new MenuPage();
            Detail = new NavigationPage(new RadioPage())
            {
                BarTextColor = Color.Black
            };

            App.MenuItem = this;
        }
    }
}