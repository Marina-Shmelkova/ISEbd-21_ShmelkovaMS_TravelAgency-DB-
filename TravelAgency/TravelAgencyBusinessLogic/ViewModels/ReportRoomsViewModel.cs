using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace TravelAgencyBusinessLogic.ViewModels
{
    public class ReportRoomsViewModel
    {
        [DisplayName("Отель")]
        public string HotelName { get; set; }
        [DisplayName("Тип номера")]
        public string TypeRoom { get; set; }
        [DisplayName("Вид")]
        public string ViewRoom { get; set; }
        [DisplayName("Цена")]
        public decimal Price { get; set; }
    }
}
