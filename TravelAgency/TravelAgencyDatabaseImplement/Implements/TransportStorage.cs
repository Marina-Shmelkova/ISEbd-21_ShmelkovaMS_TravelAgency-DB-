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
    public class TransportStorage : ITransportStorage
    {
        public List<TransportViewModel> GetFullList()
        {
            using (var context = new TravelAgencyContext())
            {
                return context.Transport.Include(x => x.Route).Select(CreateModel)
                .ToList();
            }
        }
        public List<TransportViewModel> GetFilteredList(TransportBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyContext())
            {
                return context.Transport.Include(x => x.Route)
                .Where(rec => rec.Routeto == model.Routeto)
                .Select(CreateModel)
                .ToList();
            }
        }
        public TransportViewModel GetElement(TransportBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyContext())
            {
                var accounting = context.Transport.Include(x => x.Route)
                .FirstOrDefault(rec => rec.Transportid == model.Id);
                return accounting != null ? CreateModel(accounting) :
                null;
            }
        }
        public void Insert(TransportBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                context.Transport.Add(CreateModel(model, new Transport(), context));
                context.SaveChanges();
            }
        }

        public void Update(TransportBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                var element = context.Transport.FirstOrDefault(rec => rec.Transportid == model.Id);
                if (element == null)
                {
                    throw new Exception("Способ передвижения не найден");
                }
                CreateModel(model, element, context);
                context.SaveChanges();
            }
        }
        public void Delete(TransportBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                Transport element = context.Transport.FirstOrDefault(rec => rec.Transportid == model.Id);
                if (element != null)
                {
                    context.Transport.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Способ передвижения не найден");
                }
            }
        }

        private TransportViewModel CreateModel(Transport transport)
        {
            TransportViewModel model = new TransportViewModel();
            model.Id = transport.Transportid;
            model.Routefrom = transport.Routefrom;
            model.Routeto = transport.Routeto;
            model.Viewtransport = transport.Viewtransport;
            model.Priceticket = transport.Priceticket;
            return model;
        }
        private Transport CreateModel(TransportBindingModel model, Transport transport, TravelAgencyContext database)
        {
            transport.Routefrom = model.Routefrom;
            transport.Routeto = model.Routeto;
            transport.Viewtransport = model.Viewtransport;
            transport.Priceticket = model.Priceticket;
            return transport;
        }
    }
}
