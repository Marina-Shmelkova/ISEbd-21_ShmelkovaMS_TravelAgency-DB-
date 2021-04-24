using System;
using System.Collections.Generic;
using System.Text;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyBusinessLogic.BusinessLogics
{
    public class TransportLogic
    {
        private readonly ITransportStorage _transportStorage;

        public TransportLogic(ITransportStorage transportStorage)
        {
            _transportStorage = transportStorage;
        }
        public List<TransportViewModel> Read(TransportBindingModel model)
        {
            if (model == null)
            {
                return _transportStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<TransportViewModel> { _transportStorage.GetElement(model) };
            }
            return _transportStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(TransportBindingModel model)
        {
            if (model.Id.HasValue)
            {
                _transportStorage.Update(model);
            }
            else
            {
                _transportStorage.Insert(model);
            }
        }
        public void Delete(TransportBindingModel model)
        {
            var element = _transportStorage.GetElement(new TransportBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _transportStorage.Delete(model);
        }
    }
}
