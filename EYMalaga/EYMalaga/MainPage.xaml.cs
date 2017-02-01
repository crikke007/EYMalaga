using EYMalaga.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EYMalaga
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async void OnLogoutButtonClicked(object sender, EventArgs e)
        {
            App.IsUserLoggedIn = false;
            Navigation.InsertPageBefore(new LoginPage(), this);
            await Navigation.PopAsync();
        }

        public async void CameraButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new CameraPage());
        }

        public async void TagButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new RoutePage());
        }

        public async void RankingButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new RankingPage());
        }

        public async void UserButtonTapped(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new UserPage());
        }
    }
}
