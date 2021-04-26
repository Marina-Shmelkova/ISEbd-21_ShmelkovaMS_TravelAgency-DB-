using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TravelAgencyDatabaseImplement.Models
{
    public partial class Route
    {
        public Route()
        {
            Contract = new HashSet<Contract>();
        }

        public int Routeid { get; set; }
        public string Сityfrom { get; set; }
        public string Cityto { get; set; }
        public int Transportid { get; set; }

        public virtual Transport Transport { get; set; }
        public virtual ICollection<Contract> Contract { get; set; }
    }
}
