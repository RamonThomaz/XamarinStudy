using DailyProgramming.Pages;
using DailyProgramming.Services.Account;
using DailyProgramming.Services.Navigation;
using DailyProgramming.Services.Ticket;
using System;
using System.Collections.Generic;
using System.Text;
using TinyIoC;
using Xamarin.Forms;

namespace DailyProgramming.Models.PageModels.Base
{
    public class PageModelLocator
    {
        private static TinyIoCContainer _container;
        private static Dictionary<Type, Type> _viewLookup;

        static PageModelLocator() 
        { 
            _container = new TinyIoCContainer();
            _viewLookup = new Dictionary<Type, Type>();

            //Register pages and page models
            Register<DashboardPageModel, DashboardPage>();
            Register<LoginPageModel, LoginPage>();
            Register<NewTicketPageModel, NewTicketPage>();
            Register<ProfilePageModel, ProfilePage>();
            Register<SettingsPageModel, SettingsPage>();
            Register<TicketDetailsPageModel, TicketDetailsPage>();
            Register<TicketsPageModel, TicketsPage>();

            //Register services
            _container.Register<INavigationService, NavigationService>();
            _container.Register<IAccountService, AccountService>();
            _container.Register<ITicketService, TicketService>();
        }

        public static T Resolve<T>() where T : class
        {
            return _container.Resolve<T>();
        }

        public static Page CreatePageFor(Type pageModelType)
        {
            var pageType = _viewLookup[pageModelType];
            Page page = (Page)Activator.CreateInstance(pageType);
            page.BindingContext = _container.Resolve(pageModelType);
            return page;
        }

        private static void Register<TPageModel, TPage>() where TPageModel : PageModelBase where TPage : Page
        {
            _viewLookup.Add(typeof(TPageModel), typeof(TPage));
            _container.Register<TPageModel>();
        }
    }
}
