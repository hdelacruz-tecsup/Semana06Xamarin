﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ListViewGroup
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new GroupedListXaml());
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
