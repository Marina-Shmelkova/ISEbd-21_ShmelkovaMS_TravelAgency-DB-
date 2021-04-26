using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TravelAgencyDatabaseImplement.Models
{
    public partial class Hotel
    {
        public Hotel()
        {
            Contract = new HashSet<Contract>();
            HotelNumberofhotel = new HashSet<HotelNumberofhotel>();
        }

        public int Hotelid { get; set; }
        public string City { get; set; }
        public string Hotelname { get; set; }

        public virtual ICollection<Contract> Contract { get; set; }
        public virtual ICollection<HotelNumberofhotel> HotelNumberofhotel { get; set; }
    }
}
