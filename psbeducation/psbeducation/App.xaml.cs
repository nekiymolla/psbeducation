using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace psbeducation
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new psbeducation.HolderPage());
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
