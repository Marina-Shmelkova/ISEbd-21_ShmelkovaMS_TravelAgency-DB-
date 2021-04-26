using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TravelAgencyDatabaseImplement.Models
{
    public partial class Typeofnumber
    {
        public Typeofnumber()
        {
            Numberofhotel = new HashSet<Numberofhotel>();
        }

        public int Typeofnumberid { get; set; }
        public string Viewnumber { get; set; }

        public virtual ICollection<Numberofhotel> Numberofhotel { get; set; }
    }
}
