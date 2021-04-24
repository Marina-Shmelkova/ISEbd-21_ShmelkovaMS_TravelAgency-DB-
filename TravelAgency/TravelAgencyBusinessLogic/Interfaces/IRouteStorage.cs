using System;
using System.Collections.Generic;
using System.Text;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyBusinessLogic.Interfaces
{
    public interface IRouteStorage
    {
        List<RouteViewModel> GetFullList();

        List<RouteViewModel> GetFilteredList(RouteBindingModel model);

        RouteViewModel GetElement(RouteBindingModel model);

        void Insert(RouteBindingModel model);

        void Update(RouteBindingModel model);

        void Delete(RouteBindingModel model);
    }
}
