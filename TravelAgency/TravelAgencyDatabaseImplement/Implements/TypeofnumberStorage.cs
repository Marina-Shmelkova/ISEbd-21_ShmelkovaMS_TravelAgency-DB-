using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyDatabaseImplement.Implements
{
    public class TypeofnumberStorage : ITypeofnumberStorage
    {
        public List<TypeofnumberViewModel> GetFullList()
        {
            using (var context = new TravelAgencyContext())
            {
                return context.Typeofnumber.Include(x => x.Numberofhotel).Select(rec => new TypeofnumberViewModel
                {
                    Id = rec.Typeofnumberid,
                    Viewnumber = rec.Viewnumber,
                    Numberofhotel = rec.Numberofhotel.ToDictionary(x => x.Numberofhotelid, x => x.Price)
                })
                .ToList();
            }
        }
        public List<TypeofnumberViewModel> GetFilteredList(TypeofnumberBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyContext())
            {
                return context.Typeofnumber
                .Where(rec => rec.Viewnumber == model.Viewnumber)
                .Select(rec => new TypeofnumberViewModel
                {
                    Id = rec.Typeofnumberid,
                    Viewnumber = rec.Viewnumber,
                    Numberofhotel = rec.Numberofhotel.ToDictionary(x => x.Numberofhotelid, x => x.Price)
                })
                .ToList();
            }
        }
        public TypeofnumberViewModel GetElement(TypeofnumberBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyContext())
            {
                var typeofnumber = context.Typeofnumber
                .FirstOrDefault(rec => rec.Typeofnumberid == model.Id);
                return typeofnumber != null ?
                new TypeofnumberViewModel
                {
                    Id = typeofnumber.Typeofnumberid,
                    Viewnumber = typeofnumber.Viewnumber,
                    Numberofhotel = typeofnumber.Numberofhotel.ToDictionary(x => x.Numberofhotelid, x => x.Price)
                } :
                null;
            }
        }
        public void Insert(TypeofnumberBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                context.Typeofnumber.Add(CreateModel(model, new Typeofnumber(), context));
                context.SaveChanges();
            }
        }

        public void Update(TypeofnumberBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                var element = context.Typeofnumber.FirstOrDefault(rec => rec.Typeofnumberid == model.Id);
                if (element == null)
                {
                    throw new Exception("Тип номера не найден");
                }
                CreateModel(model, element, context);
                context.SaveChanges();
            }
        }

        public void Delete(TypeofnumberBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                Typeofnumber element = context.Typeofnumber.FirstOrDefault(rec => rec.Typeofnumberid == model.Id);
                if (element != null)
                {
                    context.Typeofnumber.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Тип номера не найден");
                }
            }
        }
        private Typeofnumber CreateModel(TypeofnumberBindingModel model, Typeofnumber typeofnumber, TravelAgencyContext database)
        {
            typeofnumber.Viewnumber = model.Viewnumber;
            return typeofnumber;
        }
    }
}
