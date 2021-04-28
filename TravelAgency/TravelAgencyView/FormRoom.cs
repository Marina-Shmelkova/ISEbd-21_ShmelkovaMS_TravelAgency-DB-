using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        public int HotelId { get; set; }
        private int? ChangedHotelId;
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
                if (listH != null)
                {
                    foreach (var component in list)
                    {
                        comboBoxHotel.DisplayMember = "Hotelname";
                        comboBoxHotel.ValueMember = "Id";
                        comboBoxHotel.DataSource = listH;
                        comboBoxHotel.SelectedItem = null;
                    }
                }
                
                if (Id.HasValue)
                {
                    var room = _logicN.Read(new NumberofhotelBindingModel { Id = Id.Value })?[0];
                    roomHotel = room?.HotelNumberofhotel;
                    comboBoxType.SelectedItem = list.FirstOrDefault(x => x.Id == room.Typeofnumberid);
                    ChangedHotelId = HotelId;
                    comboBoxHotel.SelectedItem = listH.FirstOrDefault(x => x.Id == HotelId);
                    textBoxView.Text = room.Viewnumber;
                    textBoxPrice.Text = room.Price.ToString();
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
            decimal price;
            if (!decimal.TryParse(textBoxPrice.Text, out price))
            {
                MessageBox.Show("Цена должна быть числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (price <= 0)
            {
                MessageBox.Show("Цена должна быть больше нуля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                if (!roomHotel.ContainsKey(Convert.ToInt32(comboBoxHotel.SelectedValue)))
                {
                    roomHotel.Add(Convert.ToInt32(comboBoxHotel.SelectedValue), comboBoxHotel.Text);
                    if (Id.HasValue && ChangedHotelId.HasValue)
                    {
                        roomHotel.Remove(ChangedHotelId.Value);
                    }
                }
                
                NumberofhotelBindingModel model = new NumberofhotelBindingModel
                {
                    Typeofnumberid = Convert.ToInt32(comboBoxType.SelectedValue),
                    HotelNumberofhotel = roomHotel,
                    Viewnumber = textBoxView.Text,
                    Price = price
                };
                if (Id.HasValue)
                {
                    model.Id = Id;
                }
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
