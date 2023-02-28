using System;
using System.Threading.Tasks;
using UventoXF.Models;
using UventoXF.ViewModel;
using UventoXF.Views;
using Xamarin.Forms;

namespace UventoXF.ViewModels
{
    public class StartPageViewModel : BaseViewModel
    {
        public StartPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
            NavigateToMainPageCommand = new Command(async () => await ExecuteNavigateToMainPageCommand());
        }

        public Command NavigateToMainPageCommand { get; }

        private async Task ExecuteNavigateToMainPageCommand()
        {
            var data = new DateItem { Title = "Title", dayWeek = "1" };
            await Navigation.PushAsync(new MainPage(data));
        }
    }
}
