using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace psbeducation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InterfacePage : TabbedPage
    {
        public InterfacePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
        }
    }
}