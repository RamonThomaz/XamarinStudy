using DailyProgramming.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace DailyProgramming.Services.Ticket
{
    public interface ITicketService
    {
        Task<bool> RegisterTicket(Models.Ticket ticket);
        Task<ObservableCollection<Models.Ticket>> GetTickets();
    }
}
