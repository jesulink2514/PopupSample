using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PopupSample
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var typ = typeof(Rg.Plugins.Popup.Animations.ScaleAnimation);

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
