﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XFMasterDetail.Views;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XFMasterDetail
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainView();
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
