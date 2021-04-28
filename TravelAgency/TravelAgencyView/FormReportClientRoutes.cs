using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using TravelAgencyBusinessLogic.Enums;
using TravelAgencyBusinessLogic.BusinessLogics;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.ViewModels;
using System.Windows.Forms;

namespace TravelAgencyView
{
    public partial class FormReportClientRoutes : Form
    {
        private readonly ReportLogic logic;
        public FormReportClientRoutes(ReportLogic report)
        {
            logic = report;
            InitializeComponent();
        }

        private void FormReportClientRoutes_Load(object sender, EventArgs e)
        {
            List<ReportClientRoute> list;
            if (Program.Client.Status == UserRoles.Агент)
            {
                list = logic.GetFullClientRoute();
            }
            else
            {
                list = logic.GetClientRoutes(new ReportBindingModel { ClientId = Program.Client.Id });
            }
            if (list == null)
                return;
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
