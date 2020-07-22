using System;
using System.Collections.Generic;
using System.Diagnostics;
using Xamarin.Forms;

namespace firstapp
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, true);
            BindingContext = new HomePageViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Debug.WriteLine("HomePage OnAppearing");
        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            Debug.WriteLine("HomePage OnDisappearing");
        }
    }
}
