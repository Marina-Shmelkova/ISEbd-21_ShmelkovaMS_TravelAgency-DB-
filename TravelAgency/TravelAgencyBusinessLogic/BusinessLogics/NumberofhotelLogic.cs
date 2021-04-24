using System;
using System.Collections.Generic;
using System.Text;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyBusinessLogic.BusinessLogics
{
    public class NumberofhotelLogic
    {
        private readonly INumberofhotelStorage _numberofhotelStorage;

        public NumberofhotelLogic(INumberofhotelStorage numberofhotelStorage)
        {
            _numberofhotelStorage = numberofhotelStorage;
        }
        public List<NumberofhotelViewModel> Read(NumberofhotelBindingModel model)
        {
            if (model == null)
            {
                return _numberofhotelStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<NumberofhotelViewModel> { _numberofhotelStorage.GetElement(model) };
            }
            return _numberofhotelStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(NumberofhotelBindingModel model)
        {
            if (model.Id.HasValue)
            {
                _numberofhotelStorage.Update(model);
            }
            else
            {
                _numberofhotelStorage.Insert(model);
            }
        }
        public void Delete(NumberofhotelBindingModel model)
        {
            var element = _numberofhotelStorage.GetElement(new NumberofhotelBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _numberofhotelStorage.Delete(model);
        }
    }
}
