using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TravelAgencyDatabaseImplement.Models
{
    public partial class Transport
    {
        public Transport()
        {
            Route = new HashSet<Route>();
        }

        public int Transportid { get; set; }
        public string Routefrom { get; set; }
        public string Routeto { get; set; }
        public string Viewtransport { get; set; }
        public decimal Priceticket { get; set; }

        public virtual ICollection<Route> Route { get; set; }
    }
}
