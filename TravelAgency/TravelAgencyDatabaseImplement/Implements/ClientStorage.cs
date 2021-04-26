using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Enums;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;
using TravelAgencyDatabaseImplement.Models;

namespace TravelAgencyDatabaseImplement.Implements
{
    public class ClientStorage : IClientStorage
    {
        public List<ClientViewModel> GetFullList()
        {
            using (var context = new TravelAgencyContext())
            {
                return context.Client.Include(x => x.Contract).Select(CreateModel)
                .ToList();
            }
        }
        public List<ClientViewModel> GetFilteredList(ClientBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyContext())
            {
                return context.Client.Include(x => x.Contract)
                .Where(rec => rec.Datebithday == model.Datebithday)
                .Select(CreateModel)
                .ToList();
            }
        }
        public ClientViewModel GetElement(ClientBindingModel model)
        {
            if (model == null)
            {
                return null;
            }
            using (var context = new TravelAgencyContext())
            {
                var client = context.Client.Include(x => x.Contract)
                .FirstOrDefault(rec => rec.Clientid == model.Id || rec.Email == model.Email);
                return client != null ? CreateModel(client) :
                null;
            }
        }
        public void Insert(ClientBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                context.Client.Add(CreateModel(model, new Client()));
                context.SaveChanges();
            }
        }

        public void Update(ClientBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                var element = context.Client.FirstOrDefault(rec => rec.Clientid == model.Id);
                if (element == null)
                {
                    throw new Exception("Клиент не найден");
                }
                CreateModel(model, element);
                context.SaveChanges();
            }
        }

        public void Delete(ClientBindingModel model)
        {
            using (var context = new TravelAgencyContext())
            {
                Client element = context.Client.FirstOrDefault(rec => rec.Clientid == model.Id);
                if (element != null)
                {
                    context.Client.Remove(element);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("Клиент не найден");
                }
            }
        }

        private Client CreateModel(ClientBindingModel model, Client client)
        {
            client.Nameclient = model.Nameclient;
            client.Phonenumber = model.Phonenumber;
            client.Datebithday = model.Datebithday;
            client.Email = model.Email;
            client.Password = model.Password;
            client.Status = Convert.ToInt32(model.Status);
            return client;
        }

        private ClientViewModel CreateModel(Client client)
        {
            ClientViewModel model = new ClientViewModel();
            model.Id = client.Clientid;
            model.Nameclient = client.Nameclient;
            model.Phonenumber = client.Phonenumber;
            model.Datebithday = client.Datebithday;
            model.Contract = client.Contract.ToDictionary(x => x.Contractid, x => x.Countnumberhotel);
            model.Email = client.Email;
            model.Password = client.Password;
            model.Status = (UserRoles)client.Status;
            return model;
        }
    }
}
