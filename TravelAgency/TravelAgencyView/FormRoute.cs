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
        private readonly RouteLogic _logicR;
        private readonly TransportLogic _logicT;
        public int? Id { get; set; }
        public string CityFrom { get; set; }
        public string CityTo { get; set; }
        private int? TransportId { get; set; }
        public FormRoute(RouteLogic logicR, TransportLogic logicT)
        {
            _logicR = logicR;
            _logicT = logicT;
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
                    Transportid = TransportId.Value,
                    Cityfrom = textBoxCityFrom.Text,
                    Cityto = textBoxCityTo.Text
                };
                if (Id.HasValue) { model.Id = Id.Value; }
                _logicR.CreateOrUpdate(model);
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
            if (Id.HasValue) { textBoxCityFrom.Text = CityFrom; textBoxCityTo.Text = CityTo; }
            var list = _logicT.Read(null);
            if (list != null)
            {
                dataGridView.DataSource = list;
                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[1].Visible = false;
                dataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            foreach (var row in dataGridView.SelectedRows)
            {
                TransportId = Convert.ToInt32((row as DataGridViewRow).Cells[0].Value);
                /*transport.Add(_logicT.Read(new TransportBindingModel
                {
                    Id = Convert.ToInt32((row as DataGridViewRow).Cells[0].Value)
                })?[0]);*/
                MessageBox.Show("Успешно", "Категория выбрана", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
        }
    }
}
