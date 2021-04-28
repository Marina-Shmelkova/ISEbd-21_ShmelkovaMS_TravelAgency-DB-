using System;
using System.Collections.Generic;
using System.Text;

namespace TravelAgencyBusinessLogic.BindingModels
{
    public class TransportBindingModel
    {
        public int? Id { get; set; }
        public string Routefrom { get; set; }
        public string Routeto { get; set; }
        public string Viewtransport { get; set; }
        public decimal Priceticket { get; set; }
        public int Routeid { get; set; }
    }
}
