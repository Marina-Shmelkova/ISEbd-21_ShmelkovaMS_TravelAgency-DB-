using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace TravelAgencyDatabaseImplement
{
    public partial class Client
    {
        public Client()
        {
            Contract = new HashSet<Contract>();
        }
        public int Clientid { get; set; }
        public string Nameclient { get; set; }
        public string Phonenumber { get; set; }
        public DateTime Datebithday { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Status { get; set; }
        public virtual ICollection<Contract> Contract { get; set; }
    }
}
