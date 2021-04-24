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
    public partial class FormHotels : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly HotelLogic _logicH;
        public FormHotels(HotelLogic logicH)
        {
            _logicH = logicH;
            InitializeComponent();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {

            if (dataGridView.SelectedRows.Count == 1)
            {
                _logicH.Delete(new HotelBindingModel { Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value) });
                LoadData();
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormHotel>();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                form.ShowDialog();
                LoadData();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormHotel>();
            form.ShowDialog();
            LoadData();
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void FormHotels_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var list = _logicH.Read(null);
            if (list != null)
            {
                dataGridView.DataSource = list;
                dataGridView.Columns[0].Visible = false;
            }
        }
    }
}
