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
    }
}
