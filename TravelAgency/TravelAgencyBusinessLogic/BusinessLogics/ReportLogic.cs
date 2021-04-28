using System;
using System.Collections.Generic;
using System.Text;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyBusinessLogic.BusinessLogics
{
    public class ReportLogic
    {
        public readonly IReportStorage storage;

        public ReportLogic(IReportStorage report)
        {
            storage = report;
        }

        public List<ReportClientViewModel> GetClientInfo(ReportBindingModel model)
        {
            if (model == null || !model.ClientId.HasValue)
            {
                return null;
            }
            return storage.GetClientInfo(model);
        }

        public List<ReportRoomsViewModel> GetReportRooms()
        {
            return storage.GetRooms();
        }

        public List<ReportClientRoute> GetClientRoutes(ReportBindingModel model)
        {
            if (model == null || !model.ClientId.HasValue)
            {
                return null;
            }
            return storage.GetClientRoute(model);
        }
    }
}
