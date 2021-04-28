using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;
using TravelAgencyDatabaseImplement.Models;

namespace TravelAgencyDatabaseImplement.Implements
{
    public class RouteStorage : IRouteStorage
    {
        public List<RouteViewModel> GetFullList()
        {
            using (var context = new TravelAgencyContext())
            {
                return context.Route.Include(x => x.Transport).Select(CreateModel)
                .ToList();
            }
        }
        public List<RouteViewModel> GetFilteredList(RouteBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyContext())
            {
                return context.Route.Include(x => x.Transport)
                .Where(rec => rec.Cityto == model.Cityto)
                .Select(CreateModel)
                .ToList();
            }
        }
        public RouteViewModel GetElement(RouteBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyContext())
            {
                var route = context.Route.Include(x => x.Transport)
                .FirstOrDefault(rec => rec.Routeid == model.Id);
                return route != null ? CreateModel(route) :
                null;
            }
        }
        public void Insert(RouteBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                context.Route.Add(CreateModel(model, new Route()));
                context.SaveChanges();
            }
        }
        public void Update(RouteBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                var element = context.Route.FirstOrDefault(rec => rec.Routeid == model.Id);
                if (element == null)
                {
                    throw new Exception("Маршрут не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }
        public void Delete(RouteBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                Route element = context.Route.FirstOrDefault(rec => rec.Routeid == model.Id);
                if (element != null)
                {
                    context.Route.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Маршрут не найден");
                }
            }
        }
        private Route CreateModel(RouteBindingModel model, Route route)
        {
            route.Сityfrom = model.Cityfrom;
            route.Cityto = model.Cityto;
            return route;
        }
        private RouteViewModel CreateModel(Route route)
        {
            RouteViewModel model = new RouteViewModel();
            model.Id = route.Routeid;
            model.Cityfrom = route.Сityfrom;
            model.Cityto = route.Cityto;
           // model.Price = route.Transport.Priceticket;
            return model;
        }
    }
}
