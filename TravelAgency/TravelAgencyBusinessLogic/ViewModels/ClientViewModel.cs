using System;
using System.Collections.Generic;
using System.ComponentModel;
using TravelAgencyBusinessLogic.Enums;

namespace TravelAgencyBusinessLogic.ViewModels
{
   public class ClientViewModel
    {
        public int Id { get; set; }
        [DisplayName("ФИО")]
        public string Nameclient { get; set; }
        [DisplayName("Телефон")]
        public string Phonenumber { get; set; }
        [DisplayName("Дата рождения")]
        public DateTime Datebithday { get; set; }
        [DisplayName("Почта")]
        public string Email { get; set; }
        [DisplayName("Пароль")]
        public string Password { get; set; }
        [DisplayName("Статус")]
        public UserRoles Status { get; set; }
        public Dictionary<int, int> Contract { get; set; }
    }
}
