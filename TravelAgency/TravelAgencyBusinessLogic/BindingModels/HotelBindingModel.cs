using System;
using System.Collections.Generic;
using System.Text;

namespace TravelAgencyBusinessLogic.BindingModels
{
   public class HotelBindingModel
    {
        public int? Id { get; set; }
        public string City { get; set; }
        public string Hotelname { get; set; }
        public Dictionary<int, int> Contract { get; set; }
        public Dictionary<int, int> HotelNumberofhotel { get; set; }
    }
}
