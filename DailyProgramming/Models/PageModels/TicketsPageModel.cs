using DailyProgramming.Models.PageModels.Base;
using DailyProgramming.Services.Navigation;
using DailyProgramming.Services.Ticket;
using DailyProgramming.ViewModels.Buttons;
using DailyProgramming.Models.Enums;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgramming.Models.PageModels
{
    public class TicketsPageModel : PageModelBase
    {
        private INavigationService _navigationService;
        private ITicketService _ticketService;

        private int _totalOpenTickets;
        public int TotalOpenTickets { get => _totalOpenTickets; set => SetProperty(ref _totalOpenTickets, value); }

        private int _totalTickets;
        public int TotalTickets { get => _totalTickets; set => SetProperty(ref _totalTickets, value); }

        private ObservableCollection<Ticket> _tickets;
        public ObservableCollection<Ticket> Tickets { get => _tickets; set => SetProperty(ref _tickets, value); }

        private ButtonModel _newTicketModel;
        public ButtonModel NewTicketModel { get => _newTicketModel; set => SetProperty(ref _newTicketModel, value); }

        public TicketsPageModel(INavigationService navigationService, ITicketService ticketService)
        {
            _navigationService = navigationService;
            _ticketService = ticketService;
            NewTicketModel = new ButtonModel("New Ticket", OnNewTicketAction);
        }

        public override Task InitializeAsync(object navigationData = null)
        {
            Tickets = _ticketService.GetTickets().Result;
            return Task.WhenAll(base.InitializeAsync(navigationData));
        }

        private async void OnNewTicketAction() 
        {
            //Testing
            var ticket = new Ticket() { Id = 6, Status = TicketStatus.Open };
            await _ticketService.RegisterTicket(ticket);
            await _navigationService.NavigateToAsync<NewTicketPageModel>();
        }
    }
}
