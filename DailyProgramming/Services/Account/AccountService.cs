using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgramming.Services.Account
{
    public class AccountService : IAccountService
    {
        public Task<bool> LoginAsync(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                return Task.FromResult(false);

            return Task.Delay(1000).ContinueWith(x => true);
        }
    }
}
