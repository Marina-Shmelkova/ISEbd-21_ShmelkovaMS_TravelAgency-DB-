using System;
using System.Collections.Generic;
using System.Text;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyBusinessLogic.BusinessLogics
{
    public class TypeofnumberLogic
    {
        private readonly ITypeofnumberStorage _typeofnumberStorage;

        public TypeofnumberLogic(ITypeofnumberStorage typeofnumberStorage)
        {
            _typeofnumberStorage = typeofnumberStorage;
        }
        public List<TypeofnumberViewModel> Read(TypeofnumberBindingModel model)
        {
            if (model == null)
            {
                return _typeofnumberStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<TypeofnumberViewModel> { _typeofnumberStorage.GetElement(model) };
            }
            return _typeofnumberStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(TypeofnumberBindingModel model)
        {
            if (model.Id.HasValue)
            {
                _typeofnumberStorage.Update(model);
            }
            else
            {
                _typeofnumberStorage.Insert(model);
            }
        }
        public void Delete(TypeofnumberBindingModel model)
        {
            var element = _typeofnumberStorage.GetElement(new TypeofnumberBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _typeofnumberStorage.Delete(model);
        }
    }
}
