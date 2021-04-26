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
    public partial class FormAuthorization : System.Windows.Forms.Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ClientLogic _logicC;
        public FormAuthorization(ClientLogic logicC)
        {
            InitializeComponent();
            _logicC = logicC;
        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonInput_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            var client = _logicC.Read(new ClientBindingModel { Email = textBoxEmail.Text, Password = textBoxPassword.Text })?[0];
            if (client == null)
            {
                MessageBox.Show("Неверный Email или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Program.Client = client;

            var form = Container.Resolve<FormMain>();
            form.ShowDialog();
            Hide();

        }

    }
}
