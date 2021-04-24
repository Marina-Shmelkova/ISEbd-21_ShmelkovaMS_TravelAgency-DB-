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
    public partial class FormRoom : Form
    {
        [Dependency]
        public new IUnityContainer Container { get; set; }
        private NumberofhotelLogic _logicN { get; set; }
        private TypeofnumberLogic _logicT { get; set; }
        public int? Id { get; set; }
        private int? Typeofnumberid { get; set; }
        public FormRoom(NumberofhotelLogic logicN, TypeofnumberLogic logicT)
        {
            _logicN = logicN;
            _logicT = logicT;
            InitializeComponent();
        }

        private void FormRoom_Load(object sender, EventArgs e)
        {
            try
            {
                var list = _logicT.Read(null);
                foreach (var component in list)
                {
                    comboBoxType.DisplayMember = "Viewnumber";
                    comboBoxType.ValueMember = "Id";
                    comboBoxType.DataSource = list;
                    comboBoxType.SelectedItem = null;
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxView.Text) || string.IsNullOrEmpty(textBoxPrice.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                _logicN.CreateOrUpdate(new NumberofhotelBindingModel
                {
                    
                    Typeofnumberid = Typeofnumberid.Value;
                    Datearrival = Convert.ToInt32(comboBoxName.SelectedValue),
                    Count = Convert.ToInt32(textBoxCount.Text),
                    Price = Convert.ToInt32(textBoxPrice.Text)
                });
              
                _logicN.CreateOrUpdate(model);
                MessageBox.Show("Сохранение прошло успешно", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
    }
}
