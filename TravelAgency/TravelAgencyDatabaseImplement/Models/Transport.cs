using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TravelAgencyDatabaseImplement
{
    public partial class Transport
    {
        public int Transportid { get; set; }
        public string Routefrom { get; set; }
        public string Routeto { get; set; }
        public string Viewtransport { get; set; }
        public int Priceticket { get; set; }
        public int Routeid { get; set; }

        public virtual Route Route { get; set; }
    }
}
