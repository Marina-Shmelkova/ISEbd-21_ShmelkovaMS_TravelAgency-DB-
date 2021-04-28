using System;
using System.Collections.Generic;
using System.Text;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyBusinessLogic.Interfaces
{
    public interface IReportStorage
    {
        List<ReportClientViewModel> GetClientInfo(ReportBindingModel model);

        List<ReportRoomsViewModel> GetRooms();

        List<ReportClientRoute> GetClientRoute(ReportBindingModel model);
    }
}
