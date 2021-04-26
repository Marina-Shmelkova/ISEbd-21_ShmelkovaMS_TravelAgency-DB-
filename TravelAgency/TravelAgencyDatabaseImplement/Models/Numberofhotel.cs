using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TravelAgencyDatabaseImplement.Models
{
    public partial class Numberofhotel
    {
        public Numberofhotel()
        {
            HotelNumberofhotel = new HashSet<HotelNumberofhotel>();
        }

        public int Numberofhotelid { get; set; }
        public string Viewnumber { get; set; }
        public DateTime Datearrival { get; set; }
        public DateTime Dateofdeparture { get; set; }
        public decimal Price { get; set; }
        public int Typeofnumberid { get; set; }

        public virtual Typeofnumber Typeofnumber { get; set; }
        public virtual ICollection<HotelNumberofhotel> HotelNumberofhotel { get; set; }
    }
}
