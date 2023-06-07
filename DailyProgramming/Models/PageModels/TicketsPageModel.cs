using DailyProgramming.Models.PageModels.Base;
using DailyProgramming.ViewModels.Buttons;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DailyProgramming.Models.PageModels
{
    public class TicketsPageModel : PageModelBase
    {
        private int _totalOpenTickets;
        public int TotalOpenTickets { get => _totalOpenTickets; set => SetProperty(ref _totalOpenTickets, value); }

        private int _totalTickets;
        public int TotalTickets { get => _totalTickets; set => SetProperty(ref _totalTickets, value); }

        private ObservableCollection<Ticket> _tickets;
        public ObservableCollection<Ticket> Tickets { get => _tickets; set => SetProperty(ref _tickets, value); }

        private ButtonModel _newTicketModel;
        public ButtonModel NewTicketModel { get => _newTicketModel; set => SetProperty(ref _newTicketModel, value); }

        public TicketsPageModel()
        {
            Tickets = new ObservableCollection<Ticket>();
            NewTicketModel = new ButtonModel("New Ticket", OnNewTicketAction);
        }

        private void OnNewTicketAction() { }
    }
}
