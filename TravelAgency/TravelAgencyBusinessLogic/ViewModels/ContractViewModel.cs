using System;
using System.Collections.Generic;
using System.Text;

namespace TravelAgencyBusinessLogic.ViewModels
{
    public class ContractViewModel
    {
        public int Id { get; set; }
        public DateTime Datetotravel { get; set; }
        public DateTime Datefromtravel { get; set; }
        public int Countnumberhotel { get; set; }
        public DateTime Datetohotel { get; set; }
        public DateTime Datefromhotel { get; set; }
        public int Clientid { get; set; }
        public int Routeid { get; set; }
        public int Hotelid { get; set; }
    }
}
