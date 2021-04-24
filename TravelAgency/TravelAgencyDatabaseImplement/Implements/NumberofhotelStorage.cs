using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyDatabaseImplement.Implements
{
   public class NumberofhotelStorage : INumberofhotelStorage
    {
        public List<NumberofhotelViewModel> GetFullList()
        {
            using (var context = new TravelAgencyContext())
            {
                return context.Numberofhotel.Include(x => x.Typeofnumber).Select(rec => new NumberofhotelViewModel
                {
                    Id = rec.Numberofhotelid,
                    Viewnumber = rec.Viewnumber,
                    Datearrival = rec.Datearrival,
                    Dateofdeparture = rec.Dateofdeparture,
                    Typeofnumberid = rec.Typeofnumberid,
                    Type = rec.Typeofnumber.Viewnumber,
                    Price = rec.Price
                })
                .ToList();
            }
        }

        public List<NumberofhotelViewModel> GetFilteredList(NumberofhotelBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyContext())
            {
                return context.Numberofhotel.Include(x => x.Typeofnumber)
                .Where(rec => rec.Viewnumber == model.Viewnumber)
                .Select(rec => new NumberofhotelViewModel
                {
                    Id = rec.Numberofhotelid,
                    Viewnumber = rec.Viewnumber,
                    Datearrival = rec.Datearrival,
                    Dateofdeparture = rec.Dateofdeparture,
                    Typeofnumberid = rec.Typeofnumberid,
                    Type = rec.Typeofnumber.Viewnumber,
                    Price = rec.Price
                })
                .ToList();
            }
        }

        public NumberofhotelViewModel GetElement(NumberofhotelBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyContext())
            {
                var numberofhotel = context.Numberofhotel
                .FirstOrDefault(rec => rec.Numberofhotelid == model.Id);
                return numberofhotel != null ?
                new NumberofhotelViewModel
                {
                    Id = numberofhotel.Numberofhotelid,
                    Typeofnumberid = numberofhotel.Typeofnumberid,
                    Viewnumber = numberofhotel.Viewnumber
                } :
                null;
            }
        }

        public void Insert(NumberofhotelBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                context.Numberofhotel.Add(CreateModel(model, new Numberofhotel()));
                context.SaveChanges();
            }
        }

        public void Update(NumberofhotelBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                var element = context.Numberofhotel.FirstOrDefault(rec => rec.Numberofhotelid == model.Id);
                if (element == null)
                {
                    throw new Exception("Номер не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(NumberofhotelBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                Numberofhotel element = context.Numberofhotel.FirstOrDefault(rec => rec.Numberofhotelid == model.Id);
                if (element != null)
                {
                    context.Numberofhotel.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Номер не найден");
                }
            }
        }

        private Numberofhotel CreateModel(NumberofhotelBindingModel model, Numberofhotel numberofhotel)
        {
            numberofhotel.Typeofnumberid = model.Typeofnumberid;
            numberofhotel.Viewnumber = model.Viewnumber;
            return numberofhotel;
        }
    }
}
