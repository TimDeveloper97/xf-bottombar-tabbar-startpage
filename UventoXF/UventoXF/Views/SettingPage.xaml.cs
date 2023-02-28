using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UventoXF.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace UventoXF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingPage : ContentView
    {
        public SettingPage(string x)
        {
            InitializeComponent();
            BindingContext = new SettingPageViewModel(Navigation, x);
        }
    }
}