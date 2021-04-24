using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TravelAgencyDatabaseImplement
{
    public partial class HotelNumberofhotel
    {
        public int Hotelid { get; set; }
        public int Numberofhotelid { get; set; }

        public virtual Hotel Hotel { get; set; }
        public virtual Numberofhotel Numberofhotel { get; set; }
    }
}
