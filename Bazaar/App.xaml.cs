﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Bazaar
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new AddAddressPage());
        }

        protected override void OnStart()
        {
        }
        protected override void OnSleep()
        {
        }
        protected override void OnResume()
        {
        }
    }
}
