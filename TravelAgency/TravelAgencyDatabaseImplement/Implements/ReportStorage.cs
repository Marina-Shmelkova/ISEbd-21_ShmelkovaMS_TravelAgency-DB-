using System;
using System.Collections.Generic;
using System.Linq;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;
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
                return client.Contract.Select(x => new ReportClientViewModel
                {
                    ClientFIO = client.Nameclient,
                    ClientId = client.Clientid,
                    Datebirthday = client.Datebithday,
                    Phonenumber = client.Phonenumber,
                    RouteNameFrom = x.Route.Сityfrom,
                    RouteNameTo = x.Route.Cityto,
                    HotelName = x.Hotel.Hotelname,
                    StartDate = x.Datetotravel,
                    EndDate = x.Datefromtravel
                }).ToList();
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
                    CityFrom = x.Route.Сityfrom,
                    CityTo = x.Route.Cityto,
                    Transport = x.Route.Transport.FirstOrDefault(rec => rec.Transportid == x.Trasportid).Viewtransport,
                    Price = x.Route.Transport.FirstOrDefault(rec => rec.Transportid == x.Trasportid).Priceticket,
                }).ToList();
            }
        }
    }
}
