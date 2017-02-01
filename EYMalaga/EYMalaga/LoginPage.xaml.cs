using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace EYMalaga
{
    public partial class LoginPage : ContentPage
    {
        User us = new User();
        public LoginPage()
        {
            InitializeComponent();
        }
        async void OnSignUpButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SignUpPage());
        }

        async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            var user = new User
            {
                Username = usernameEntry.Text,
                Password = passwordEntry.Text
            };

            var isValid = AreCredentialsCorrect(user);
            if (isValid)
            {
                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new MainPage(), this);
                await Navigation.PopAsync();
            }
            else
            {
                messageLabel.Text = "Login failed";
                passwordEntry.Text = string.Empty;
            }
        }

        bool AreCredentialsCorrect(User user)
        {
            int valid = 0;
            foreach (var item in us.Users)
            {
                if ((user.Username == item.Username && user.Password == item.Password))
                {
                    valid = 1;
                    break;
                }       
            }

            if (user.Username == Constants.Username && user.Password == Constants.Password)
            {
                valid = 1;
            }


            if (valid == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
            //return user.Username == Constants.Username && user.Password == Constants.Password;
        }
    }
}
