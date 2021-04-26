using System;
using System.Collections.Generic;
using System.Text;

namespace TravelAgencyBusinessLogic.ViewModels
{
    public class RouteViewModel
    {
        public int Id { get; set; }
        public string Сityfrom { get; set; }
        public string Cityto { get; set; }
        public decimal? Price { get; set; }
        public Dictionary<int, int> Contract { get; set; }
        public Dictionary<int, (string, string, string, decimal)> Transport { get; set; }
    }
}
