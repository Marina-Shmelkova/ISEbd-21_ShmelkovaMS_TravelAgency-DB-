using System;
using System.Collections.Generic;
using System.Text;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyBusinessLogic.BusinessLogics
{
    public class ContractLogic
    {
        private readonly IContractStorage _contractStorage;

        public ContractLogic(IContractStorage contractStorage)
        {
            _contractStorage = contractStorage;
        }
        public List<ContractViewModel> Read(ContractBindingModel model)
        {
            if (model == null)
            {
                return _contractStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<ContractViewModel> { _contractStorage.GetElement(model) };
            }
            return _contractStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(ContractBindingModel model)
        {
            if (model.Id.HasValue)
            {
                _contractStorage.Update(model);
            }
            else
            {
                _contractStorage.Insert(model);
            }
        }
        public void Delete(ContractBindingModel model)
        {
            var element = _contractStorage.GetElement(new ContractBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _contractStorage.Delete(model);
        }
    }
}
