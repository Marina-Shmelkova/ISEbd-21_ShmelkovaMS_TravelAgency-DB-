using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TravelAgencyBusinessLogic.ViewModels
{
   public class HotelViewModel
    {
        public int Id { get; set; }
        [DisplayName("Город")]
        public string City { get; set; }
        [DisplayName("Название отеля")]
        public string Hotelname { get; set; }
        public Dictionary<int, int> Contract { get; set; }
        public Dictionary<int, string> HotelNumberofhotel { get; set; }
    }
}
