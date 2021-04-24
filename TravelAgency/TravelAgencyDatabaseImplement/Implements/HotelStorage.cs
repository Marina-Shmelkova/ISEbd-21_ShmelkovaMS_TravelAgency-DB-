using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyDatabaseImplement.Implements
{
    public class HotelStorage : IHotelStorage
    {
        public List<HotelViewModel> GetFullList()
        {
            using (var context = new TravelAgencyContext())
            {
                return context.Hotel.Include(x => x.HotelNumberofhotel).Include(x => x.Contract).Select(CreateModel)
                .ToList();
            }
        }
        public List<HotelViewModel> GetFilteredList(HotelBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyContext())
            {
                return context.Hotel.Include(x => x.HotelNumberofhotel).Include(x => x.Contract)
                .Where(rec => rec.Hotelname == model.Hotelname)
                .Select(CreateModel)
                .ToList();
            }
        }
        public HotelViewModel GetElement(HotelBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyContext())
            {
                var hotel = context.Hotel.Include(x => x.HotelNumberofhotel).Include(x => x.Contract)
                .FirstOrDefault(rec => rec.Hotelid == model.Id);
                return hotel != null ? CreateModel(hotel) :
                null;
            }
        }

        public void Insert(HotelBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                context.Hotel.Add(CreateModel(model, new Hotel(), context));
                context.SaveChanges();
            }
        }

        public void Update(HotelBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                var element = context.Hotel.FirstOrDefault(rec => rec.Hotelid == model.Id);
                if (element == null)
                {
                    throw new Exception("Отель не найден");
                }
                CreateModel(model, element, context);
                context.SaveChanges();
            }
        }

        public void Delete(HotelBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                Hotel element = context.Hotel.FirstOrDefault(rec => rec.Hotelid == model.Id);
                if (element != null)
                {
                    context.Hotel.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Отель не найден");
                }
            }
        }

        private Hotel CreateModel(HotelBindingModel model, Hotel hotel, TravelAgencyContext database)
        {
            hotel.City = model.City;
            hotel.Hotelname = model.Hotelname;
            return hotel;
        }

        private HotelViewModel CreateModel(Hotel hotel)
        {
            HotelViewModel model = new HotelViewModel();
            model.Id = hotel.Hotelid;
            model.City = hotel.City;
            model.Hotelname = hotel.Hotelname;
            model.Contract = hotel.Contract.ToDictionary(x => x.Contractid, x => x.Countnumberhotel);
            model.HotelNumberofhotel = hotel.HotelNumberofhotel.ToDictionary(x => x.Hotelid, x => x.Numberofhotelid);
            return model;
        }
    }
}
