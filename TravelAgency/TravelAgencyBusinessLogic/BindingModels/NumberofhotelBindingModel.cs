using System;
using System.Collections.Generic;
using System.Text;

namespace TravelAgencyBusinessLogic.BindingModels
{
   public class NumberofhotelBindingModel
    {
        public int? Id { get; set; }
        public string Viewnumber { get; set; }
        public DateTime Datearrival { get; set; }
        public DateTime Dateofdeparture { get; set; }
        public int Price { get; set; }
        public int Typeofnumberid { get; set; }
        public Dictionary<int, int> HotelNumberofhotel { get; set; }
    }
}
