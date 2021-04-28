using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;
using TravelAgencyDatabaseImplement.Models;

namespace TravelAgencyDatabaseImplement.Implements
{
    public class ContractStorage : IContractStorage
    {
        public List<ContractViewModel> GetFullList()
        {
            using (var context = new TravelAgencyContext())
            {
                return context.Contract.Select(rec => new ContractViewModel
                {
                    Id = rec.Contractid,
                    Clientid = rec.Clientid,
                    Datetotravel = rec.Datetotravel,
                    Datefromtravel = rec.Datefromtravel,
                    Countnumberhotel = rec.Countnumberhotel,
                    Datetohotel = rec.Datetohotel,
                    Datefromhotel = rec.Datefromhotel,
                    Routeid = rec.Routeid,
                    Hotelid = rec.Hotelid,
                    Price = rec.Price,
                    Transportid = rec.Trasportid
                })
                .ToList();
            }
        }

        public List<ContractViewModel> GetFilteredList(ContractBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyContext())
            {
                return context.Contract
                .Where(rec => rec.Datefromtravel == model.Datefromtravel)
                .Select(rec => new ContractViewModel
                {
                    Id = rec.Contractid,
                    Clientid = rec.Clientid,
                    Datetotravel = rec.Datetotravel,
                    Datefromtravel = rec.Datefromtravel,
                    Countnumberhotel = rec.Countnumberhotel,
                    Datetohotel = rec.Datetohotel,
                    Datefromhotel = rec.Datefromhotel,
                    Routeid = rec.Routeid,
                    Hotelid = rec.Hotelid,
                    Transportid = rec.Trasportid
                })
                .ToList();
            }
        }

        public ContractViewModel GetElement(ContractBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyContext())
            {
                var contract = context.Contract
                .FirstOrDefault(rec => rec.Contractid == model.Id);
                return contract != null ?
                new ContractViewModel
                {
                    Id = contract.Contractid,
                    Clientid = contract.Clientid,
                    Datetotravel = contract.Datetotravel,
                    Datefromtravel = contract.Datefromtravel,
                    Countnumberhotel = contract.Countnumberhotel,
                    Datetohotel = contract.Datetohotel,
                    Datefromhotel = contract.Datefromhotel,
                    Routeid = contract.Routeid,
                    Hotelid = contract.Hotelid,
                    Transportid = contract.Trasportid
                } :
                null;
            }
        }

        public void Insert(ContractBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                context.Contract.Add(CreateModel(model, new Contract()));
                context.SaveChanges();
            }
        }

        public void Update(ContractBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                var element = context.Contract.FirstOrDefault(rec => rec.Contractid == model.Id);
                if (element == null)
                {
                    throw new Exception("Договор не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(ContractBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                Contract element = context.Contract.FirstOrDefault(rec => rec.Contractid == model.Id);
                if (element != null)
                {
                    context.Contract.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Договор не найден");
                }
            }
        }

        private Contract CreateModel(ContractBindingModel model, Contract contract)
        {
            contract.Clientid = model.Clientid;
            contract.Datetotravel = model.Datetotravel;
            contract.Datefromtravel = model.Datefromtravel;
            contract.Countnumberhotel = model.Countnumberhotel;
            contract.Datetohotel = model.Datetohotel;
            contract.Datefromhotel = model.Datefromhotel;
            contract.Routeid = model.Routeid;
            contract.Hotelid = model.Hotelid;
            contract.Price = model.Price;
            contract.Trasportid = model.Transportid;
            return contract;
        }
    }
}
