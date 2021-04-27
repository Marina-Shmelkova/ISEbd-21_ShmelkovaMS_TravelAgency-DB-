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
        private HotelLogic _logicH { get; set; }
        private TypeofnumberLogic _logicT { get; set; }
        private Dictionary<int, string> roomHotel;
        public int? Id { get; set; }
        private int? Typeofnumberid { get; set; }
        public FormRoom(NumberofhotelLogic logicN, TypeofnumberLogic logicT, HotelLogic logicH)
        {
            _logicH = logicH;
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
                var listH = _logicH.Read(null);
                foreach (var component in list)
                {
                    comboBoxHotel.DisplayMember = "Hotelname";
                    comboBoxHotel.ValueMember = "Id";
                    comboBoxHotel.DataSource = listH;
                    comboBoxHotel.SelectedItem = null;
                }
                if (Id.HasValue)
                {
                    var room = _logicN.Read(new NumberofhotelBindingModel { Id = Id.Value })?[0];
                    roomHotel = room?.HotelNumberofhotel;
                }
                else
                {
                    roomHotel = new Dictionary<int, string> ();
                }
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

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxView.Text) || string.IsNullOrEmpty(textBoxPrice.Text))
            {
                MessageBox.Show("Заполните все поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                roomHotel.Add(Convert.ToInt32(comboBoxHotel.SelectedValue), comboBoxHotel.Text);
                _logicN.CreateOrUpdate(new NumberofhotelBindingModel
                {

                    Typeofnumberid = Convert.ToInt32(comboBoxType.SelectedValue),
                    HotelNumberofhotel = roomHotel,
                    Viewnumber = textBoxView.Text,
                    Datearrival = dateTimePickerTo.Value,
                    Dateofdeparture = dateTimePickerFrom.Value,
                    Price = Convert.ToInt32(textBoxPrice.Text)
                }) ;
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
