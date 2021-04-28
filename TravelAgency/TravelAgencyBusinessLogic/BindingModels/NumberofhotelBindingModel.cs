using System;
using System.Collections.Generic;
using System.Text;

namespace TravelAgencyBusinessLogic.BindingModels
{
   public class NumberofhotelBindingModel
    {
        public int? Id { get; set; }
        public string Viewnumber { get; set; }
        public decimal Price { get; set; }
        public int Typeofnumberid { get; set; }
        public Dictionary<int, string> HotelNumberofhotel { get; set; }
    }
}
