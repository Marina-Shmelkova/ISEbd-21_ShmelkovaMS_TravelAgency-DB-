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
using TravelAgencyBusinessLogic.ViewModels;
using Unity;

namespace TravelAgencyView
{
    public partial class FormRoute : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly RouteLogic _logicR;
        public int? Id { get; set; }
        public FormRoute(RouteLogic logicR)
        {
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
            try
            {
                RouteBindingModel model = new RouteBindingModel
                {
                    Cityfrom = textBoxCityFrom.Text,
                    Cityto = textBoxCityTo.Text
                };
                if (Id.HasValue) 
                { 
                    model.Id = Id; 
                }
                _logicR.CreateOrUpdate(model);
                MessageBox.Show("Успешно", "Сохранено",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void FormRoute_Load(object sender, EventArgs e)
        {
            if (Id.HasValue)
            {
                var route = _logicR.Read(new RouteBindingModel { Id = Id.Value })?[0];
                if (route == null) { return; }
                textBoxCityFrom.Text = route.Cityfrom;
                textBoxCityTo.Text = route.Cityto;
            }
        }
    }
}
