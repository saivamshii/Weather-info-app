using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Weatherr
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
            //handle when your app starts
        }

        protected override void OnSleep()
        {
            //handle when your app sleeps
        }

        protected override void OnResume()
        {

        }
    }
}
