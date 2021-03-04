using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Activity
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
            MainPage.DisplayAlert("Message", "Onstart", "Continue");
        }

        protected override void OnSleep()
        {
            MainPage.DisplayAlert("Message", "OnSleep", "Continue");
        }

        protected override void OnResume()
        {
            MainPage.DisplayAlert("Message", "OnResume", "Continue");
        }
      

    }
}
