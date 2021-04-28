using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace TravelAgencyBusinessLogic.ViewModels
{
    public class ReportClientRoute
    {
        [DisplayName("ФИО")]
        public string ClientName { get; set; }
        [DisplayName("Город отправления")]
        public string CityFrom { get; set; }
        [DisplayName("Город путешествия")]
        public string CityTo { get; set; }
        [DisplayName("Транспорт")]
        public string Transport { get; set; }
        [DisplayName("Цена билета")]
        public decimal Price { get; set; }
    }
}
