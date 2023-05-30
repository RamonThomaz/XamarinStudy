using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DailyProgramming.Models.PageModels.Base
{
    public class PageModelBase : BindableObject
    {
        private string _title;
        public string Title { get => _title; set => SetProperty(ref _title, value); }
        private bool _isLoading;
        public bool IsLoading { get => _isLoading; set => SetProperty(ref _isLoading, value); }

        public virtual Task InitializeAsync(object navigationData = null)
        {
            return Task.CompletedTask;
        }

        protected bool SetProperty<T>(ref T propertyRef, T value, [CallerMemberName] string propertyName = null)
        {
            if(EqualityComparer<T>.Default.Equals(propertyRef, value))
                return false;

            propertyRef = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
