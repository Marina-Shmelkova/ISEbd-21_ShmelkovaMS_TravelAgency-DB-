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
    public partial class FormTravelReservation : Form
    {
        private readonly TransportLogic _logicT;
        private readonly RouteLogic _logicR;
        private readonly HotelLogic _logicH;
        private readonly NumberofhotelLogic _logicN;
        private readonly ContractLogic _logicC;
        private int? RouteId { get; set; }
        private int? TransportId { get; set; }
        private int? HotelId { get; set; }
        public FormTravelReservation(TransportLogic logicT, RouteLogic logicR, 
            HotelLogic logicH, NumberofhotelLogic logicN, ContractLogic logicC)
        {
            _logicT = logicT;
            _logicR = logicR;
            _logicH = logicH;
            _logicN = logicN;
            _logicC = logicC;
            InitializeComponent();
        }

        private void FormTravelReservation_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            var list = _logicR.Read(null);
            if(list == null)
            {
                return;
            }
            dataGridViewRoute.DataSource = list;
            dataGridViewRoute.Columns[0].Visible = false;
            dataGridViewRoute.Columns[3].Visible = false;
            dataGridViewRoute.Columns[4].Visible = false;
            dataGridViewRoute.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            var listN = _logicN.Read(null);
            if (listN != null)
            {
                dataGridViewRooms.Rows.Clear();
                foreach(var room in listN)
                {
                    foreach(var hotel in room.HotelNumberofhotel)
                    {
                        dataGridViewRooms.Rows.Add(new object[] { hotel.Key, hotel.Value, room.Viewnumber, room.Type, room.Price });
                    }
                    
                }
            }
        }

        private void buttonTransport_Click(object sender, EventArgs e)
        {
            TransportId = Convert.ToInt32(dataGridViewTransport.SelectedRows[0].Cells[0].Value);

            MessageBox.Show("Успешно", "Сохранено",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonRoute_Click(object sender, EventArgs e)
        {
            var list = _logicT.Read(new TransportBindingModel { 
                Routefrom = dataGridViewRoute.SelectedRows[0].Cells[1].Value.ToString(), 
                Routeto = dataGridViewRoute.SelectedRows[0].Cells[2].Value.ToString() });
            if (list == null)
            {
                return;
            }
            dataGridViewTransport.DataSource = list;
            dataGridViewTransport.Columns[0].Visible = false;
            dataGridViewTransport.Columns[1].Visible = false;

            RouteId = Convert.ToInt32(dataGridViewRoute.SelectedRows[0].Cells[0].Value);
            MessageBox.Show("Успешно", "Сохранено",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

           // dataGridViewTransport.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            RouteId = Convert.ToInt32(dataGridViewRoute.SelectedRows[0].Cells[0].Value);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!HotelId.HasValue)
            {
                MessageBox.Show("Выберите номер", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!RouteId.HasValue)
            {
                MessageBox.Show("Выберите Маршрут", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!TransportId.HasValue)
            {
                MessageBox.Show("Выберите Транспорт", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateTimePickerHotelTo.Value.Date <= dateTimePickerHotelFrom.Value.Date)
            {
                MessageBox.Show("Дата заселения в отель должна быть меньше, чем дата выезда", "Ошибка", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (dateTimePickerTravelTo.Value.Date <= dateTimePickerTravelFrom.Value.Date)
            {
                MessageBox.Show("Конечная дата путешествия должна быть больше, чем начальная", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                int HotelDays = (dateTimePickerHotelTo.Value.Date - dateTimePickerHotelFrom.Value.Date).Days;
                decimal Price = Convert.ToDecimal(dataGridViewTransport.SelectedRows[0].Cells[5].Value) +
                    Convert.ToDecimal(dataGridViewRooms.SelectedRows[0].Cells[4].Value) * HotelDays;
                ContractBindingModel model = new ContractBindingModel
                {
                    Clientid = Program.Client.Id,
                    Hotelid = HotelId.Value,
                    Routeid = RouteId.Value,
                    Transportid = TransportId.Value,
                    Datefromhotel = dateTimePickerHotelFrom.Value,
                    Datetohotel = dateTimePickerHotelTo.Value,
                    Datefromtravel = dateTimePickerTravelFrom.Value,
                    Datetotravel = dateTimePickerTravelTo.Value,
                    Price = Price,
                    Countnumberhotel = 1
                };
                _logicC.CreateOrUpdate(model);
                MessageBox.Show("Успешно", "Сохранено",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.InnerException?.Message + "\n" + ex.Message, "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void buttonHotelRoom_Click(object sender, EventArgs e)
        {
            HotelId = Convert.ToInt32(dataGridViewRooms.SelectedRows[0].Cells[0].Value);
            MessageBox.Show("Успешно", "Сохранено",
            MessageBoxButtons.OK, MessageBoxIcon.Information);

             HotelId = Convert.ToInt32(dataGridViewRooms.SelectedRows[0].Cells[0].Value);

        }
    }
}
