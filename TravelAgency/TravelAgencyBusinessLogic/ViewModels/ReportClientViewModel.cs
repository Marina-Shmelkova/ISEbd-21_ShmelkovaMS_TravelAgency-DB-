using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TravelAgencyBusinessLogic.ViewModels
{
    public class ReportClientViewModel
    {
        public int ClientId { get; set; }

        [DisplayName("ФИО")]
        public string ClientFIO { get; set; }

        [DisplayName("Номер телефона")]
        public string Phonenumber { get; set; }

        [DisplayName("Дата рождения")]
        public DateTime Datebirthday { get; set; }

        [DisplayName("Город отправления")]
        public string RouteNameFrom { get; set; }
        [DisplayName("Город путешествия")]
        public string RouteNameTo { get; set; }
        [DisplayName("Отель")]
        public string HotelName { get; set; }

        [DisplayName("Дата Отправления в путешествие")]
        public DateTime StartDate { get; set; }

        [DisplayName("Дата Приезда домой")]
        public DateTime EndDate { get; set; }
    }
}
