using System;
using TravelAgencyBusinessLogic.Enums;
using System.Windows.Forms;
using TravelAgencyBusinessLogic.BindingModels;
using TravelAgencyBusinessLogic.BusinessLogics;
using Unity;

namespace TravelAgencyView
{
    public partial class FormRegistration : System.Windows.Forms.Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private readonly ClientLogic _logicC;
        public FormRegistration(ClientLogic logicC)
        {
            InitializeComponent();
            _logicC = logicC;
            comboBoxRole.Items.AddRange(new string[] { "Клиент", "Агент" });
        }

        private void buttonCansel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxPassword.Text) ||
               comboBoxRole.SelectedValue != null)
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                return;
            }
            if (string.IsNullOrEmpty(comboBoxRole.Text))
            {
                MessageBox.Show("Необходимо выбрать роль", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                ClientBindingModel model = new ClientBindingModel
                {
                    Email = textBoxEmail.Text,
                    Password = textBoxPassword.Text,
                    Nameclient = "",
                    Datebithday = DateTime.Now,
                    Phonenumber = "",
                    Status = (UserRoles)Enum.Parse(typeof(UserRoles), comboBoxRole.Text)
                };
                _logicC.CreateOrUpdate(model);
                Program.Client = _logicC.Read(model)?[0];
                MessageBox.Show("Регистрация прошло успешно", "Сообщение",
              MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
                var form = Container.Resolve<FormAuthorization>();
                form.ShowDialog();
            }
          
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }
    }
}
