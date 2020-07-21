using System;
using System.Diagnostics;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace firstapp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Debug.WriteLine("---> Application InitializeComponent");

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // This method will handle when your application starts
            Debug.WriteLine("---> Application start");
        }

        protected override void OnSleep()
        {
            // This method will handle when your application go to sleep (background)
            Debug.WriteLine("---> Application goes to sleep");
        }

        protected override void OnResume()
        {
            // This method will handle when your application come back from background to foreground
            Debug.WriteLine("---> Application resumes");
        }
    }
}
