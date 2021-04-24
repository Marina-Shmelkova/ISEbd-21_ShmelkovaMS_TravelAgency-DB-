using System;
using System.Collections.Generic;
using System.Text;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyBusinessLogic.Interfaces
{
    public interface ITransportStorage
    {
        List<TransportViewModel> GetFullList();

        List<TransportViewModel> GetFilteredList(TransportBindingModel model);

        TransportViewModel GetElement(TransportBindingModel model);

        void Insert(TransportBindingModel model);

        void Update(TransportBindingModel model);

        void Delete(TransportBindingModel model);
    }
}
