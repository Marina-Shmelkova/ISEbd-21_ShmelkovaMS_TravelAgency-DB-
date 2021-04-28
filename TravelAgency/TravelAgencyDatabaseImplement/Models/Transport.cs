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
            Contract = new HashSet<Contract>();
        }

        public int Transportid { get; set; }
        public string Routefrom { get; set; }
        public string Routeto { get; set; }
        public string Viewtransport { get; set; }
        public decimal Priceticket { get; set; }
        public int Routeid { get; set; }

        public virtual Route Route { get; set; }
        public virtual ICollection<Contract> Contract { get; set; }
    }
}
