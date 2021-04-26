using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TravelAgencyBusinessLogic.BusinessLogics;
using TravelAgencyBusinessLogic.Enums;
using Unity;

namespace TravelAgencyView
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly ClientLogic _LogicC;
        public FormMain(ClientLogic LogicC)
        {
            _LogicC = LogicC;
            InitializeComponent();
        }
        private string AdminCheck()
        {
            if (Program.Client.Status != UserRoles.Агент) { return "Недостаточно прав"; }
            return null;
        }
        private void личныеДанныеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormClientData>();
            // if (form.ShowDialog() == DialogResult.OK)
            //RefreshDataGrid();
        }

        private void направленияОтдыхаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = AdminCheck();
            if (message != null)
            {
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var form = Container.Resolve<FormRoutes>();
            form.ShowDialog();
        }

        private void транспортToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = AdminCheck();
            if (message != null)
            {
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var form = Container.Resolve<FormTransports>();
            form.ShowDialog();
        }

        private void отелиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = AdminCheck();
            if (message != null)
            {
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var form = Container.Resolve<FormHotels>();
            form.ShowDialog();
        }

        private void номераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = AdminCheck();
            if (message != null)
            {
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var form = Container.Resolve<FormRooms>();
            form.ShowDialog();
        }

        private void типНомераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string message = AdminCheck();
            if (message != null)
            {
                MessageBox.Show(message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var form = Container.Resolve<FormTypeofnumber>();
            form.ShowDialog();
        }
    }
}
