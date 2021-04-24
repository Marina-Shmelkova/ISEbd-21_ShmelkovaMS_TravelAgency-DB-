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
        public int? Id { get; set; }
        public FormTransport(TransportLogic logicT)
        {
            _logicT = logicT;
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(textBoxRoutefrom.Text) || string.IsNullOrEmpty(textBoxRouteto.Text) ||
                string.IsNullOrEmpty(textBoxViewTransport.Text) || string.IsNullOrEmpty(textBoxPrice.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                TransportBindingModel model = new TransportBindingModel
                {
                    Routefrom = textBoxRoutefrom.Text,
                    Routeto = textBoxRouteto.Text,
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
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message, "Ошибка",
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
            if (Id.HasValue)
            {
                var transport = _logicT.Read(new TransportBindingModel { Id = Id.Value })?[0];
                if (transport == null) { return; }
                textBoxRoutefrom.Text = transport.Routefrom;
                textBoxRouteto.Text = transport.Routeto;
                textBoxViewTransport.Text = transport.Viewtransport;
                textBoxPrice.Text = transport.Priceticket.ToString();
            }
        }
    }
}
