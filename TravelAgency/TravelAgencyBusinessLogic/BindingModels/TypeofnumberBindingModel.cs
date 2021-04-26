using System;
using System.Collections.Generic;
using System.Text;

namespace TravelAgencyBusinessLogic.BindingModels
{
    public class TypeofnumberBindingModel
    {
        public int? Id { get; set; }
        public string Viewnumber { get; set; }
        public Dictionary<int, decimal> Numberofhotel { get; set; }
    }
}
