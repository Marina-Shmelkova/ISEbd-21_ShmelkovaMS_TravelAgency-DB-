using System;
using System.Collections.Generic;
using System.Text;

namespace TravelAgencyBusinessLogic.ViewModels
{
    public class NumberofhotelViewModel
    {
        public int Id { get; set; }
        public string Viewnumber { get; set; }
        public DateTime Datearrival { get; set; }
        public DateTime Dateofdeparture { get; set; }
        public decimal Price { get; set; }
        public string Type { get; set; }
        public int Typeofnumberid { get; set; }
        public Dictionary<int, string> HotelNumberofhotel { get; set; }
    }
}
