using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace DailyProgramming.Models.PageModels.Base
{
    public class ExtendableBindableObject : BindableObject
    {
        protected bool SetProperty<T>(ref T propertyRef, T value, [CallerMemberName] string propertyName = null)
        {
            if (EqualityComparer<T>.Default.Equals(propertyRef, value))
                return false;

            propertyRef = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
