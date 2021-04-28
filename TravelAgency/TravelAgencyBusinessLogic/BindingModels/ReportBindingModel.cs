using System;
using System.Collections.Generic;
using TravelAgencyBusinessLogic.Enums;

namespace TravelAgencyBusinessLogic.BindingModels
{
    public class ReportBindingModel
    {
        public int? ClientId { get; set; }

        public UserRoles? Status { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }
    }
}
