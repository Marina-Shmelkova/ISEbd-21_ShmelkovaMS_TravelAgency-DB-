using System;
using System.Collections.Generic;
using System.Text;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Interfaces;
using TravelAgencyBusinessLogic.ViewModels;

namespace TravelAgencyBusinessLogic.BusinessLogics
{
    public class HotelLogic
    {
        private readonly IHotelStorage _hotelStorage;

        public HotelLogic(IHotelStorage hotelStorage)
        {
            _hotelStorage = hotelStorage;
        }
        public List<HotelViewModel> Read(HotelBindingModel model)
        {
            if (model == null)
            {
                return _hotelStorage.GetFullList();
            }
            if (model.Id.HasValue)
            {
                return new List<HotelViewModel> { _hotelStorage.GetElement(model) };
            }
            return _hotelStorage.GetFilteredList(model);
        }
        public void CreateOrUpdate(HotelBindingModel model)
        {
            if (model.Id.HasValue)
            {
                _hotelStorage.Update(model);
            }
            else
            {
                _hotelStorage.Insert(model);
            }
        }
        public void Delete(HotelBindingModel model)
        {
            var element = _hotelStorage.GetElement(new HotelBindingModel
            {
                Id = model.Id
            });
            if (element == null)
            {
                throw new Exception("Элемент не найден");
            }
            _hotelStorage.Delete(model);
        }
    }
}
