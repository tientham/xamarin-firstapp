using System.Diagnostics;

namespace firstapp
{
    public partial class App : Xamarin.Forms.Application
    {
        public App()
        {
            InitializeComponent();
            Debug.WriteLine("---> Application InitializeComponent");

            MainPage = new Xamarin.Forms.NavigationPage(new MainPage());
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
