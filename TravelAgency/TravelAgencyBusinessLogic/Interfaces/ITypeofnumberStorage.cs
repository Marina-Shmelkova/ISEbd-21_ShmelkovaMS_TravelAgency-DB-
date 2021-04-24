using System;
using System.Collections.Generic;
using System.Text;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyBusinessLogic.Interfaces
{
    public interface ITypeofnumberStorage
    {
        List<TypeofnumberViewModel> GetFullList();

        List<TypeofnumberViewModel> GetFilteredList(TypeofnumberBindingModel model);

        TypeofnumberViewModel GetElement(TypeofnumberBindingModel model);

        void Insert(TypeofnumberBindingModel model);

        void Update(TypeofnumberBindingModel model);

        void Delete(TypeofnumberBindingModel model);
    }
}
