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
    public partial class FormRoute : Form
    {
        private readonly TransportLogic _logicT;

        private readonly RouteLogic _logicR;
        private int? Id;
        private int? TransportId { get; set; }
        public FormRoute(TransportLogic logicT, RouteLogic logicR)
        {
            _logicT = logicT;
            _logicR = logicR;
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxCityFrom.Text))
            {
                MessageBox.Show("Введите родной город", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxCityTo.Text))
            {
                MessageBox.Show("Введите город путешествия", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (TransportId == null)
            {
                MessageBox.Show("Выберите способ передвижения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                RouteBindingModel model = new RouteBindingModel
                {
                    Сityfrom = textBoxCityFrom.Text,
                    Cityto = textBoxCityTo.Text,
                    //Transport = dataGridView.Value
                };
                if (Id.HasValue) { model.Id = Id.Value; }
                _logicR.CreateOrUpdate(model);
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonTransport_Click(object sender, EventArgs e)
        {
           
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
