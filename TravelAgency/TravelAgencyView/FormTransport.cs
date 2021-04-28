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
using Unity;

namespace TravelAgencyView
{
    public partial class FormTransport : Form
    {

        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly TransportLogic _logicT;
        private readonly RouteLogic _logicR;
        public int? Id { get; set; }
        public FormTransport(TransportLogic logicT, RouteLogic route)
        {
            _logicR = route;
            _logicT = logicT;
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBoxViewTransport.Text) || string.IsNullOrEmpty(textBoxPrice.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (dataGridView.SelectedRows.Count != 1) { return; }
                var route = _logicR.Read(new RouteBindingModel { Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value) })?[0];
                TransportBindingModel model = new TransportBindingModel
                {
                    Routefrom = route.Cityfrom,
                    Routeto = route.Cityto,
                    Routeid = route.Id,
                    Viewtransport = textBoxViewTransport.Text,
                    Priceticket = Convert.ToInt32(textBoxPrice.Text)
                };
                if (Id.HasValue)
                {
                    model.Id = Id;
                }
                _logicT.CreateOrUpdate(model);
                MessageBox.Show("Успешно", "Сохранено",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message + "\n" + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormTransport_Load(object sender, EventArgs e)
        {
            var list = _logicR.Read(null);
            if (list != null)
            {
                dataGridView.DataSource = list;
                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[3].Visible = false;
                dataGridView.Columns[4].Visible = false;
            }
            if (Id.HasValue)
            {
                var transport = _logicT.Read(new TransportBindingModel { Id = Id.Value })?[0];
                if (transport == null) { return; }
                textBoxViewTransport.Text = transport.Viewtransport;
                textBoxPrice.Text = transport.Priceticket.ToString();
            }
        }
    }
}
