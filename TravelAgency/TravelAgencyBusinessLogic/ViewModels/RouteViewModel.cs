using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace TravelAgencyBusinessLogic.ViewModels
{
    public class RouteViewModel
    {
        public int Id { get; set; }
        [DisplayName("Родной город")]
        public string Cityfrom { get; set; }
        [DisplayName("Город путешествия")]
        public string Cityto { get; set; }
        public Dictionary<int, int> Contract { get; set; }
        public Dictionary<int, (string, string, string, decimal)> Transport { get; set; }
    }
}
