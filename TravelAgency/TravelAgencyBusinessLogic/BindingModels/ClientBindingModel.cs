using System;
using System.Collections.Generic;
using System.Text;
using TravelAgencyBusinessLogic.Enums;

namespace TravelAgencyBusinessLogic.BindingModels
{
    public class ClientBindingModel
    {
        public int? Id { get; set; }
        public string Nameclient { get; set; }
        public string Phonenumber { get; set; }
        public DateTime Datebithday { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserRoles Status { get; set; }
        public Dictionary<int, int> Contract { get; set; } //id, countrooms
    }
}
