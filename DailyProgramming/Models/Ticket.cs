using DailyProgramming.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace DailyProgramming.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string ClientName { get; set; }
        public string Description { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public TicketStatus Status { get; set; }
        public string PersonInChargeOf { get; set; }
    }
}
