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

namespace TravelAgencyView
{
    public partial class FormClientData : Form
    {
        private readonly ClientLogic _LogicC;
        public FormClientData(ClientLogic LogicC)
        {
            _LogicC = LogicC;
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxName.Text))
            {
                MessageBox.Show("Заполните Имя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(textBoxPhonenumber.Text))
            {
                MessageBox.Show("Заполните номер телефона", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                ClientBindingModel client = new ClientBindingModel
                {
                    Id = Program.Client.Id,
                    Email = Program.Client.Email,
                    Password = Program.Client.Password,
                    Nameclient = textBoxName.Text,
                    Phonenumber = textBoxPhonenumber.Text,
                    Datebithday = dateTimePicker.Value,
                    Status = Program.Client.Status
                };
                _LogicC.CreateOrUpdate(client);
                Program.Client = _LogicC.Read(client)?[0];
                MessageBox.Show("Изменено", "Личные данные", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
         
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void FormClientData_Load(object sender, EventArgs e)
        {
            if (Program.Client == null)
            {
                return;
            }
            var client = Program.Client;
            textBoxName.Text = client.Nameclient;
            textBoxPhonenumber.Text = client.Phonenumber;
            dateTimePicker.Value = client.Datebithday;
        }
    }
}
