﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace EYMalaga
{
    public class App : Application
    {
        public static bool IsUserLoggedIn { get; set; }
        public static double ScreenHeight;
        public static double ScreenWidth;

        public App()
        {
            //// The root page of your application
            //MainPage = new ContentPage
            //{
            //};

            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                MainPage = new NavigationPage(new EYMalaga.MainPage());
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
