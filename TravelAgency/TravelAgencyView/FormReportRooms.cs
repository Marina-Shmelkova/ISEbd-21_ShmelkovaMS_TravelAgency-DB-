using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using TravelAgencyBusinessLogic.BusinessLogics;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.ViewModels;
using System.Windows.Forms;

namespace TravelAgencyView
{
    public partial class FormReportRooms : Form
    {
        private readonly ReportLogic logic;
        public FormReportRooms(ReportLogic report)
        {
            logic = report;
            InitializeComponent();
        }

        private void FormReportRooms_Load(object sender, EventArgs e)
        {
            var list = logic.GetReportRooms();
            if (list == null)
                return;
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
    }
}
