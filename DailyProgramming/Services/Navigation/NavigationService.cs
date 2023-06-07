using DailyProgramming.Models.PageModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DailyProgramming.Services.Navigation
{
    public class NavigationService : INavigationService
    {
        public Task GoBackAsync()
        {
            return App.Current.MainPage.Navigation.PopAsync();
        }

        public async Task NavigateToAsync<TPageModelBase>(object navigationData = null, bool setRoot = false)
        {
            Page page = PageModelLocator.CreatePageFor(typeof(TPageModelBase));
            if (!setRoot && App.Current.MainPage is NavigationPage navigationPage && !(page is TabbedPage tabbedPage))
                await navigationPage.PushAsync(page);
            else
                App.Current.MainPage = new NavigationPage(page);
            if (page.BindingContext is PageModelBase pageModelBase)
                await pageModelBase.InitializeAsync(navigationData);
        }
    }
}
