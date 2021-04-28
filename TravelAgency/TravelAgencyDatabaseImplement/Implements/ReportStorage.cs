using System;
using System.Collections.Generic;
using System.Linq;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;
using TravelAgencyDatabaseImplement.Models;
using Microsoft.EntityFrameworkCore;

namespace TravelAgencyDatabaseImplement.Implements
{
    public class ReportStorage : IReportStorage
    {
        public List<ReportClientViewModel> GetClientInfo(ReportBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                var client = context.Client.Include(x => x.Contract).ThenInclude(x => x.Hotel)
                    .Include(x => x.Contract).ThenInclude(x => x.Route)
                    .FirstOrDefault(x => x.Clientid == model.ClientId);
                if (client == null)
                {
                    throw new Exception("Клиент не найден");
                }
                return client.Contract.Select(ClientCreateModel).ToList();
            }
        }

        public List<ReportClientViewModel> GetFullClientInfo()
        {
            using (var context = new TravelAgencyContext())
            {
                return context.Contract.Include(x => x.Client)
                    .Include(x => x.Hotel).Include(x => x.Route)
                    .Select(ClientCreateModel).ToList();
            }
        }

        public List<ReportClientViewModel> GetClientInfoFiltered(ReportBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                var client = context.Client.Include(x => x.Contract).ThenInclude(x => x.Hotel)
                    .Include(x => x.Contract).ThenInclude(x => x.Route)
                    .FirstOrDefault(x => x.Clientid == model.ClientId);
                if (client == null)
                {
                    throw new Exception("Клиент не найден");
                }
                return context.Contract.Where(x => x.Datefromtravel.Date >= model.DateFrom.Value.Date
                && x.Datetotravel.Date <= model.DateTo.Value.Date).Select(ClientCreateModel).ToList();
            }
        }

        public List<ReportClientViewModel> GetFullClientInfoFiltered(ReportBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                return context.Contract.Include(x => x.Client)
                    .Include(x => x.Hotel).Include(x => x.Route).Where(x => x.Datefromtravel.Date >= model.DateFrom.Value.Date 
                && x.Datetotravel.Date <= model.DateTo.Value.Date).Select(ClientCreateModel).ToList();
            }
        }

        public List<ReportRoomsViewModel> GetRooms()
        {
            using (var context = new TravelAgencyContext())
            {
                return context.Numberofhotel.Include(x => x.HotelNumberofhotel).ThenInclude(x => x.Hotel).Select(rec =>
                new ReportRoomsViewModel
                {
                    HotelName = rec.HotelNumberofhotel.FirstOrDefault(x => x.Numberofhotelid == rec.Numberofhotelid).Hotel.Hotelname,
                    Price = rec.Price,
                    TypeRoom = rec.Typeofnumber.Viewnumber,
                    ViewRoom = rec.Viewnumber
                }).ToList();
            }
        }

        public List<ReportClientRoute> GetClientRoute(ReportBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                var client = context.Client.Include(x => x.Contract).ThenInclude(x => x.Route).ThenInclude(x => x.Transport)
                    .FirstOrDefault(x => x.Clientid == model.ClientId);
                if (client == null)
                {
                    throw new Exception("Клиент не найден");
                }
                return client.Contract.Select(x => new ReportClientRoute
                {
                    ClientName = x.Client.Nameclient,
                    CityFrom = x.Route.Cityfrom,
                    CityTo = x.Route.Cityto,
                    Transport = x.Route.Transport.FirstOrDefault(rec => rec.Transportid == x.Trasportid).Viewtransport,
                    Price = x.Route.Transport.FirstOrDefault(rec => rec.Transportid == x.Trasportid).Priceticket,
                }).ToList();
            }
        }

        public List<ReportClientRoute> GetFullClientRoute()
        {
            using (var context = new TravelAgencyContext())
            {
                return context.Contract.Select(x => new ReportClientRoute
                {
                    ClientName = x.Client.Nameclient,
                    CityFrom = x.Route.Cityfrom,
                    CityTo = x.Route.Cityto,
                    Transport = x.Route.Transport.FirstOrDefault(rec => rec.Transportid == x.Trasportid).Viewtransport,
                    Price = x.Route.Transport.FirstOrDefault(rec => rec.Transportid == x.Trasportid).Priceticket,
                }).ToList();
            }
        }

        private ReportClientViewModel ClientCreateModel(Contract contract)
        {
            return new ReportClientViewModel
            {
                ClientFIO = contract.Client.Nameclient,
                ClientId = contract.Client.Clientid,
                Datebirthday = contract.Client.Datebithday,
                Phonenumber = contract.Client.Phonenumber,
                RouteNameFrom = contract.Route.Cityfrom,
                RouteNameTo = contract.Route.Cityto,
                HotelName = contract.Hotel.Hotelname,
                StartDate = contract.Datetotravel,
                EndDate = contract.Datefromtravel
            };
        }
    }
}
