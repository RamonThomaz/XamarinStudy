using DailyProgramming.Models.PageModels.Base;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgramming.Models.PageModels
{
    public class DashboardPageModel : PageModelBase
    {
        private NewTicketPageModel _newTicketPageModel;
        public NewTicketPageModel NewTicketPageModel { get => _newTicketPageModel; set => SetProperty(ref _newTicketPageModel, value); }
        private ProfilePageModel _profilePageModel;
        public ProfilePageModel ProfilePageModel { get => _profilePageModel; set => SetProperty(ref _profilePageModel, value); }
        private SettingsPageModel _settingsPageModel;
        public SettingsPageModel SettingsPageModel { get => _settingsPageModel; set => SetProperty(ref _settingsPageModel, value); }
        private TicketsPageModel _ticketsPageModel;
        public TicketsPageModel TicketsPageModel { get => _ticketsPageModel; set => SetProperty(ref _ticketsPageModel, value); }

        public DashboardPageModel(NewTicketPageModel newTicketPageModel, ProfilePageModel profilePageModel, SettingsPageModel settingsPageModel, TicketsPageModel ticketsPageModel)
        {
            NewTicketPageModel = newTicketPageModel;
            ProfilePageModel = profilePageModel;
            SettingsPageModel = settingsPageModel;
            TicketsPageModel = ticketsPageModel;
        }

        public override Task InitializeAsync(object navigationData = null)
        {
            return Task.WhenAll(base.InitializeAsync(navigationData),
                NewTicketPageModel.InitializeAsync(),
                ProfilePageModel.InitializeAsync(),
                SettingsPageModel.InitializeAsync(),
                TicketsPageModel.InitializeAsync());
        }
    }
}
