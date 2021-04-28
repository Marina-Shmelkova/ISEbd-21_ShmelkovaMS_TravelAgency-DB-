using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TravelAgencyBusinessLogic.BusinessLogics;
using TravelAgencyBusinessLogic.ViewModels;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.Enums;

namespace TravelAgencyView
{
    public partial class FormReportContracts : Form
    {
        private readonly ReportLogic logic;
        public FormReportContracts(ReportLogic report)
        {
            logic = report;
            InitializeComponent();
        }

        private void buttonMake_Click(object sender, EventArgs e)
        {
            if (dateTimePickerTo.Value.Date <= dateTimePickerFrom.Value.Date)
            {
                MessageBox.Show("Вторая дата должна быть больше =)", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var list = logic.GetClientInfoFiltered(new ReportBindingModel 
            { 
                ClientId = Program.Client.Id,
                Status = Program.Client.Status,
                DateFrom = dateTimePickerFrom.Value,
                DateTo = dateTimePickerTo.Value
            });
            if (list == null)
                return;
            dataGridView.DataSource = list;
            dataGridView.Columns[0].Visible = false;
        }
    }
}
