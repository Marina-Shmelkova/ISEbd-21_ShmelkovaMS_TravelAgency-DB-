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
    public partial class FormRouteTransport : Form
    {
        private readonly TransportLogic _logicT;
        //public int Id { set { id = value; } }
        //private int? id;
        public int? Id { get; set; }
        /*public string Routefrom
        {
            get { return Convert.ToString(textBoxRoutefrom.Text); }
            set
            {
                textBoxRoutefrom.Text = value.ToString();
            }
        }
        public string Routeto
        {
            get { return Convert.ToString(textBoxRouteto.Text); }
            set
            {
                textBoxRouteto.Text = value.ToString();
            }
        }
        public string ViewTransport
        {
            get { return Convert.ToString(textBoxViewTransport.Text); }
            set
            {
                textBoxViewTransport.Text = value.ToString();
            }
        }
        public decimal Price
        {
            get { return Convert.ToDecimal(textBoxPrice.Text); }
            set
            {
                textBoxPrice.Text = value.ToString();
            }
        }*/
        public FormRouteTransport(TransportLogic logicT)
        {
            _logicT = logicT;
            InitializeComponent();
        }


        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxRoutefrom.Text))
            {
                MessageBox.Show("Заполните поле Количество", "Ошибка",
               MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
               var model = new TransportBindingModel
                {
                    Routefrom = textBoxRoutefrom.Text,
                    Routeto = textBoxRouteto.Text,
                    Viewtransport = textBoxViewTransport.Text,
                    Priceticket = Convert.ToDecimal(textBoxPrice.Text),
                };
                if (Id.HasValue)
                {
                    model.Id = Id;
                }
                _logicT.CreateOrUpdate(model);
                MessageBox.Show("Сохранение прошло успешно", "Сообщение",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
            }
        }

        private void FormRouteTransport_Load(object sender, EventArgs e)
        {
            var list = _logicT.Read(null);
            if (list != null)
            {
                dataGridView.DataSource = list;
                dataGridView.Columns[0].Visible = false;
                dataGridView.Columns[1].Visible = false;
                dataGridView.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
