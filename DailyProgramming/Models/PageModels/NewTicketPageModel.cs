using DailyProgramming.Models.Enums;
using DailyProgramming.Models.PageModels.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace DailyProgramming.Models.PageModels
{
    public class NewTicketPageModel : PageModelBase
    {
        private int _id;
        public int Id { get => _id; set => SetProperty(ref _id, value); }

        private string _clientName;
        public string ClientName { get => _clientName; set => SetProperty(ref _clientName, value); }

        private string _description;
        public string Description { get => _description; set => SetProperty(ref _description, value); }

        private string _address;
        public string Address { get => _address; set => SetProperty(ref _address, value); }

        private string _city;
        public string City { get => _city; set => SetProperty(ref _city, value); }

        private string _personInChargeOf;
        public string PersonInChargeOf { get => _personInChargeOf; set => SetProperty(ref _personInChargeOf, value); }
    }
}
