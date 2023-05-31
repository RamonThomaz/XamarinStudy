using DailyProgramming.Models.PageModels;
using DailyProgramming.Models.PageModels.Base;
using DailyProgramming.Services.Navigation;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DailyProgramming
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        private Task InitNavigation()
        {
            INavigationService navigationService = PageModelLocator.Resolve<INavigationService>();
            return navigationService.NavigateToAsync<LoginPageModel>();
        }

        protected override async void OnStart()
        {
            await InitNavigation();
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
