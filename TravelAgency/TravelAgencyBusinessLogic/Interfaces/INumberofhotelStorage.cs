using System;
using System.Collections.Generic;
using System.Text;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyBusinessLogic.Interfaces
{
    public interface INumberofhotelStorage
    {
        List<NumberofhotelViewModel> GetFullList();

        List<NumberofhotelViewModel> GetFilteredList(NumberofhotelBindingModel model);

        NumberofhotelViewModel GetElement(NumberofhotelBindingModel model);

        void Insert(NumberofhotelBindingModel model);

        void Update(NumberofhotelBindingModel model);

        void Delete(NumberofhotelBindingModel model);
    }
}
