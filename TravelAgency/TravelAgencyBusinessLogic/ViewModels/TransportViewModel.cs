using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TravelAgencyBusinessLogic.ViewModels
{
    public class TransportViewModel
    {
        public int Id { get; set; }
        public int Routeid { get; set; }
        [DisplayName("Город отправления")]
        public string Routefrom { get; set; }
        [DisplayName("Город прибытия")]
        public string Routeto { get; set; }
        [DisplayName("Транспорт")]
        public string Viewtransport { get; set; }
        [DisplayName("Цена билета")]
        public int Priceticket { get; set; }
        
    }
}
