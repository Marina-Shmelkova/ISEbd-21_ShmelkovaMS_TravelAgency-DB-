using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.BusinessLogics;

namespace TravelAgencyView
{
    public partial class FormHotel : Form
    {
        private readonly HotelLogic _logicH;
        public int? Id { get; set; }
        public FormHotel(HotelLogic logicH)
        {
            _logicH = logicH;
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCity.Text) || string.IsNullOrEmpty(textBoxHotelName.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                HotelBindingModel model = new HotelBindingModel
                {
                    City = textBoxCity.Text,
                    Hotelname = textBoxHotelName.Text
                };
                if (Id.HasValue)
                {
                    model.Id = Id;
                }
                _logicH.CreateOrUpdate(model);
                MessageBox.Show("Успешно", "Сохранено",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void FormHotel_Load(object sender, EventArgs e)
        {
            if (Id.HasValue)
            {
                var model = _logicH.Read(new HotelBindingModel { Id = Id })?[0];
                if (model == null) { return; }
                textBoxCity.Text = model.City.ToString();
                textBoxHotelName.Text = model.Hotelname.ToString();
            }
        }
    }
}
