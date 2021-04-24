using System;
using System.Collections.Generic;
using System.Text;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyBusinessLogic.Interfaces
{
    public interface IContractStorage
    {
        List<ContractViewModel> GetFullList();

        List<ContractViewModel> GetFilteredList(ContractBindingModel model);

        ContractViewModel GetElement(ContractBindingModel model);

        void Insert(ContractBindingModel model);

        void Update(ContractBindingModel model);

        void Delete(ContractBindingModel model);
    }
}
