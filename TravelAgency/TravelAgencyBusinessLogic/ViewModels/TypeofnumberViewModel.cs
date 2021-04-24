using System;
using System.Collections.Generic;
using System.Text;

namespace TravelAgencyBusinessLogic.ViewModels
{
    public class TypeofnumberViewModel
    {
        public int Id { get; set; }
        public string Viewnumber { get; set; }
        public Dictionary<int, int> Numberofhotel { get; set; }
    }
}
