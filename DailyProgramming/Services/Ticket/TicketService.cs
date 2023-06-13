using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgramming.Services.Ticket
{
    public class TicketService : ITicketService
    {
        private List<Models.Ticket> _tickets;

        public TicketService()
        {
            _tickets = new List<Models.Ticket>();
        }

        public Task<ObservableCollection<Models.Ticket>> GetTickets()
        {
            return Task.FromResult(new ObservableCollection<Models.Ticket>(_tickets));
        }

        public Task<bool> RegisterTicket(Models.Ticket ticket)
        {
            _tickets.Insert(0, ticket);
            return Task.FromResult(true);
        }
    }
}
