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
            Transport = new HashSet<Transport>();
        }

        public int Routeid { get; set; }
        public string Cityfrom { get; set; }
        public string Cityto { get; set; }

        public virtual ICollection<Contract> Contract { get; set; }
        public virtual ICollection<Transport> Transport { get; set; }
    }
}
