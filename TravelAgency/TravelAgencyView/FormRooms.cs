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
    public partial class FormRooms : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private NumberofhotelLogic _logicN { get; set; }
        public FormRooms(NumberofhotelLogic logicN)
        {
            _logicN = logicN;
            InitializeComponent();
        }

        private void FormRooms_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            var list = _logicN.Read(null);
            if (list != null)
            {
                try
                {
                    dataGridView.Rows.Clear();
                    foreach (var elem in list)
                    {
                        dataGridView.Rows.Add(new object[]
                        { elem.Id, elem.Type, elem.Viewnumber, 
                            elem.Price});
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormRoom>();
            form.ShowDialog();
            LoadData();
        }

        private void buttonUpd_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                var form = Container.Resolve<FormRoom>();
                form.Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value);
                //form.Type = dataGridView.SelectedRows[0].Cells[1].Value.ToString();
                form.ShowDialog();
                LoadData();
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {

            if (dataGridView.SelectedRows.Count == 1)
            {
                _logicN.Delete(new NumberofhotelBindingModel { Id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells[0].Value) });
                LoadData();
            }
        }

        private void buttonRef_Click(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}
