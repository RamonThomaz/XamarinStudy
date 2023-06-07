using DailyProgramming.Models.PageModels.Base;
using DailyProgramming.Services.Account;
using DailyProgramming.Services.Navigation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DailyProgramming.Models.PageModels
{
    public class LoginPageModel : PageModelBase
    {
        private ICommand _signInCommand;
        public ICommand LogInCommand { get => _signInCommand; set => SetProperty(ref _signInCommand, value); }
        private string _username;
        public string Username { get => _username; set => SetProperty(ref _username, value); }
        private string _password;
        public string Password { get => _password; set => SetProperty(ref _password, value); }

        private INavigationService _navigationService;
        private IAccountService _accountService;

        public LoginPageModel(INavigationService navigationService, IAccountService accountService)
        {
            _navigationService = navigationService;
            _accountService = accountService;

            LogInCommand = new Command(OnLogInAction);
        }

        private async void OnLogInAction(object obj)
        {
            bool isLoginSuccessful = await _accountService.LoginAsync(Username, Password);
            if (isLoginSuccessful)
                await _navigationService.NavigateToAsync<DashboardPageModel>();
            else
            {
                //TODO: Display alert regarding the unsuccessful attempt to log in
            }
        }
    }
}
