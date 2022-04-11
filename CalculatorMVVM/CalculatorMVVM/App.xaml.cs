﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using CalculatorMVVM.Views;

namespace CalculatorMVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CalculatorPage());
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
