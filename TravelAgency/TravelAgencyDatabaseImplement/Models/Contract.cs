using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TravelAgencyDatabaseImplement.Models
{
    public partial class Contract
    {
        public int Contractid { get; set; }
        public DateTime Datetotravel { get; set; }
        public DateTime Datefromtravel { get; set; }
        public int Countnumberhotel { get; set; }
        public DateTime Datetohotel { get; set; }
        public DateTime Datefromhotel { get; set; }
        public int Clientid { get; set; }
        public int Routeid { get; set; }
        public int Hotelid { get; set; }
        public decimal Price { get; set; }
        public int Trasportid { get; set; }

        public virtual Client Client { get; set; }
        public virtual Hotel Hotel { get; set; }
        public virtual Route Route { get; set; }
        public virtual Transport Trasport { get; set; }
    }
}
