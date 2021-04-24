using System;
using System.Collections.Generic;
using System.Text;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyBusinessLogic.BusinessLogics
{
    public class RouteLogic
    {
        private readonly IRouteStorage _routeStorage;

        public RouteLogic(IRouteStorage routeStorage)
        {
            _routeStorage = routeStorage;
        }
        public List<RouteViewModel> Read(RouteBindingModel model)
        {
            if (model == null)
            {
                return _routeStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<RouteViewModel> { _routeStorage.GetElement(model) };
            }
            return _routeStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(RouteBindingModel model)
        {
            if (model.Id.HasValue)
            {
                _routeStorage.Update(model);
            }
            else
            {
                _routeStorage.Insert(model);
            }
        }
        public void Delete(RouteBindingModel model)
        {
            var element = _routeStorage.GetElement(new RouteBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _routeStorage.Delete(model);
        }
    }
}
