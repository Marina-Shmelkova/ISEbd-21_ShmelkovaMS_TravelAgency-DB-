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
using TravelAgencyBusinessLogic.Enums;
using Unity;

namespace TravelAgencyView
{
    public partial class FormMain : System.Windows.Forms.Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }

        private readonly ClientLogic _LogicC;
        private readonly ReportLogic _LogicR;
        public FormMain(ClientLogic LogicC, ReportLogic LogicR)
        {
            _LogicC = LogicC;
            _LogicR = LogicR;
           // Program.Client = _LogicC.Read(new ClientBindingModel { Email = "Агент" })?[0];
          //  RefreshDataGrid();
            InitializeComponent();
        }
        private void RefreshDataGrid()
        {
            var list = _LogicR.GetClientInfo(new ReportBindingModel { ClientId = Program.Client?.Id });
            if (list == null) { return; }
            dataGridView.DataSource = list;
            dataGridView.Columns[0].Visible = false;
        }
        private string AdminCheck()
        {
            if (Program.Client.Status != UserRoles.Агент) { return "Недостаточно прав"; }
            return null;
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

        private void забронироватьПутешествиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormTravelReservation>();
            form.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            var list = _LogicR.GetClientInfo(new ReportBindingModel { ClientId = Program.Client.Id });
            if (list == null) { return; }
            dataGridView.DataSource = list;
            dataGridView.Columns[0].Visible = false;
        }

        private void МаршрутыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormReportClientRoutes>();
            form.ShowDialog();
        }

        private void ПроживаниеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = Container.Resolve<FormReportRooms>();
            form.ShowDialog();
        }
    }
}
