using System;
using System.Collections.Generic;
using System.Text;

namespace TravelAgencyBusinessLogic.BindingModels
{
    public class RouteBindingModel
    {
        public int? Id { get; set; }
        public string Cityfrom { get; set; }
        public string Cityto { get; set; }
        public int Transportid { get; set; }
        public Dictionary<int, int> Contract { get; set; }
        public Dictionary<int, (string, string, string, decimal)> Transport { get; set; }
    }
}
