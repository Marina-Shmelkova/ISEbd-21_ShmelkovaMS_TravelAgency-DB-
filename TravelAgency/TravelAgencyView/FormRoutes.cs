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
    public partial class FormRoutes : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private RouteLogic _logicR { get; set; }
        public FormRoutes(RouteLogic logicR)
        {
            _logicR = logicR;
            InitializeComponent();
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                _logicR.Delete(new RouteBindingModel { Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value) });
                LoadData();
            }
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormRoute>();
                //RouteId = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                form.ShowDialog();
                LoadData();
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {

            var form = Container.Resolve<FormRoute>();
            form.ShowDialog();
            LoadData();
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void FormRoutes_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var list = _logicR.Read(null);
            if (list != null)
            {
                try
                {
                    dataGridView.Rows.Clear();
                    foreach (var elem in list)
                    {
                        dataGridView.Rows.Add(new object[]
                        { elem.Id, elem.Сityfrom, elem.Cityto, elem.Price});
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
