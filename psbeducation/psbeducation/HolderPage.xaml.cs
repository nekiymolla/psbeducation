using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace psbeducation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HolderPage : ContentPage
    {
        public HolderPage()
        {
            InitializeComponent();
            Logo.Source = ImageSource.FromResource("psbeducation.data.img.logo.svg");
            NavigationPage.SetHasNavigationBar(this, false);
            Thread.Sleep(10000);
            Navigation.PushAsync(new MainPage());
        }
    }
}