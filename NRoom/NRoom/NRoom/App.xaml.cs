﻿using NRoom.Common;
using NRoom.Model;
using NRoom.ViewModel;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace NRoom
{
    public partial class App : Application
    {
        public static TradeInfoViewModel TradeInfoViewModel = new TradeInfoViewModel();
        public static TokenInfo tokenInfo;
       // public static MainPage MainPage;

        public App()
        {
            InitializeComponent();

            Setting.Load();
            MainPage = new MainPage();
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
