using System;
using System.Collections.Generic;
using System.Text;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;
using TravelAgencyBusinessLogic.Enums;

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

        public List<ReportClientViewModel> GetFullClientInfo()
        {
            return storage.GetFullClientInfo();
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

        public List<ReportClientRoute> GetFullClientRoute()
        {
            return storage.GetFullClientRoute();
        }

        public List<ReportClientViewModel> GetClientInfoFiltered(ReportBindingModel model)
        {
            if (model == null)
                return null;
            if (!model.DateTo.HasValue || !model.DateFrom.HasValue || !model.Status.HasValue)
                return null;
            if (model.Status.Value == UserRoles.Агент)
                return storage.GetFullClientInfoFiltered(model);
            else
                return storage.GetClientInfoFiltered(model);
        }
    }
}
