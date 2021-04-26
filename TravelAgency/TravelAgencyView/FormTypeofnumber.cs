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
    public partial class FormTypeofnumber : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private TypeofnumberLogic _logicT { get; set; }
        public int? Id { get; set; }
        public FormTypeofnumber(TypeofnumberLogic logicT)
        {
            InitializeComponent();
            _logicT = logicT;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxType.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK,
               MessageBoxIcon.Error);
                return;
            }
            try
            {
                TypeofnumberBindingModel model = new TypeofnumberBindingModel
                {
                    Viewnumber = textBoxType.Text,

                };
                if (Id.HasValue)
                {
                    model.Id = Id;
                }
                _logicT.CreateOrUpdate(model);
                MessageBox.Show("Успешно", "Сохранено",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
