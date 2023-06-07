using DailyProgramming.Models.PageModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DailyProgramming.ViewModels.Buttons
{
    public class ButtonModel : ExtendableBindableObject
    {
        private string _text;
        public string Text { get => _text; set => SetProperty(ref _text, value); }

        private bool _isEnabled;
        public bool IsEnabled { get => _isEnabled; set => SetProperty(ref _isEnabled, value); }

        private bool _isVisible;
        public bool IsVisible { get => _isVisible; set => SetProperty(ref _isVisible, value); }

        private ICommand _command;
        public ICommand Command { get => _command; set => SetProperty(ref _command, value); }

        public ButtonModel(string text, ICommand command, bool isEnabled=true, bool isVisible=true)
        {
            Text = text;
            Command = command;
            IsEnabled = isEnabled;
            IsVisible = isVisible;
        }

        public ButtonModel(string text, Action action, bool isEnabled = true, bool isVisible = true)
        {
            Text = text;
            Command = new Command(action);
            IsEnabled = isEnabled;
            IsVisible = isVisible;
        }
    }
}
