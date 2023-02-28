using System;
using System.Collections.Generic;
using System.Text;
using UventoXF.ViewModel;
using Xamarin.Forms;

namespace UventoXF.ViewModels
{
    public class SettingPageViewModel : BaseViewModel
    {
        public SettingPageViewModel(INavigation navigation, string x)
        {
            var y = x;
            Navigation = navigation;
        }
    }
}
