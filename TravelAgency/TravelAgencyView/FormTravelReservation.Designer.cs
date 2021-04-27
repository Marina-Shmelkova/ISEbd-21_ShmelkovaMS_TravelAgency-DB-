
namespace TravelAgencyView
{
    partial class FormTravelReservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewTransport = new System.Windows.Forms.DataGridView();
            this.dataGridViewRoute = new System.Windows.Forms.DataGridView();
            this.buttonRoute = new System.Windows.Forms.Button();
            this.buttonTransport = new System.Windows.Forms.Button();
            this.dateTimePickerTravelFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTravelTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHotelFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHotelTo = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.buttonHotelRoom = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTransport
            // 
            this.dataGridViewTransport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTransport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransport.Location = new System.Drawing.Point(16, 194);
            this.dataGridViewTransport.Name = "dataGridViewTransport";
            this.dataGridViewTransport.Size = new System.Drawing.Size(353, 223);
            this.dataGridViewTransport.TabIndex = 0;
            // 
            // dataGridViewRoute
            // 
            this.dataGridViewRoute.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewRoute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoute.Location = new System.Drawing.Point(16, 12);
            this.dataGridViewRoute.Name = "dataGridViewRoute";
            this.dataGridViewRoute.Size = new System.Drawing.Size(353, 150);
            this.dataGridViewRoute.TabIndex = 1;
            // 
            // buttonRoute
            // 
            this.buttonRoute.Location = new System.Drawing.Point(375, 17);
            this.buttonRoute.Name = "buttonRoute";
            this.buttonRoute.Size = new System.Drawing.Size(121, 23);
            this.buttonRoute.TabIndex = 2;
            this.buttonRoute.Text = " Выбрать маршрут";
            this.buttonRoute.UseVisualStyleBackColor = true;
            this.buttonRoute.Click += new System.EventHandler(this.buttonRoute_Click);
            // 
            // buttonTransport
            // 
            this.buttonTransport.Location = new System.Drawing.Point(375, 200);
            this.buttonTransport.Name = "buttonTransport";
            this.buttonTransport.Size = new System.Drawing.Size(123, 23);
            this.buttonTransport.TabIndex = 3;
            this.buttonTransport.Text = "Выбрать транспорт";
            this.buttonTransport.UseVisualStyleBackColor = true;
            this.buttonTransport.Click += new System.EventHandler(this.buttonTransport_Click);
            // 
            // dateTimePickerTravelFrom
            // 
            this.dateTimePickerTravelFrom.Location = new System.Drawing.Point(392, 88);
            this.dateTimePickerTravelFrom.Name = "dateTimePickerTravelFrom";
            this.dateTimePickerTravelFrom.Size = new System.Drawing.Size(159, 20);
            this.dateTimePickerTravelFrom.TabIndex = 4;
            // 
            // dateTimePickerTravelTo
            // 
            this.dateTimePickerTravelTo.Location = new System.Drawing.Point(390, 128);
            this.dateTimePickerTravelTo.Name = "dateTimePickerTravelTo";
            this.dateTimePickerTravelTo.Size = new System.Drawing.Size(161, 20);
            this.dateTimePickerTravelTo.TabIndex = 5;
            // 
            // dateTimePickerHotelFrom
            // 
            this.dateTimePickerHotelFrom.Location = new System.Drawing.Point(607, 40);
            this.dateTimePickerHotelFrom.Name = "dateTimePickerHotelFrom";
            this.dateTimePickerHotelFrom.Size = new System.Drawing.Size(163, 20);
            this.dateTimePickerHotelFrom.TabIndex = 6;
            // 
            // dateTimePickerHotelTo
            // 
            this.dateTimePickerHotelTo.Location = new System.Drawing.Point(607, 79);
            this.dateTimePickerHotelTo.Name = "dateTimePickerHotelTo";
            this.dateTimePickerHotelTo.Size = new System.Drawing.Size(163, 20);
            this.dateTimePickerHotelTo.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(390, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Даты путешествия:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(568, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Даты заселения/ выселения в отель:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(392, 313);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 21;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(392, 355);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // dataGridViewRooms
            // 
            this.dataGridViewRooms.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridViewRooms.Location = new System.Drawing.Point(504, 194);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.Size = new System.Drawing.Size(444, 212);
            this.dataGridViewRooms.TabIndex = 22;
            // 
            // buttonHotelRoom
            // 
            this.buttonHotelRoom.Location = new System.Drawing.Point(630, 142);
            this.buttonHotelRoom.Name = "buttonHotelRoom";
            this.buttonHotelRoom.Size = new System.Drawing.Size(90, 40);
            this.buttonHotelRoom.TabIndex = 23;
            this.buttonHotelRoom.Text = "Выбрать проживание";
            this.buttonHotelRoom.UseVisualStyleBackColor = true;
            this.buttonHotelRoom.Click += new System.EventHandler(this.buttonHotelRoom_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Отель";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Тип номера";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Вид ";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Цена";
            this.Column5.Name = "Column5";
            // 
            // FormTravelReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 446);
            this.Controls.Add(this.buttonHotelRoom);
            this.Controls.Add(this.dataGridViewRooms);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePickerHotelTo);
            this.Controls.Add(this.dateTimePickerHotelFrom);
            this.Controls.Add(this.dateTimePickerTravelTo);
            this.Controls.Add(this.dateTimePickerTravelFrom);
            this.Controls.Add(this.buttonTransport);
            this.Controls.Add(this.buttonRoute);
            this.Controls.Add(this.dataGridViewRoute);
            this.Controls.Add(this.dataGridViewTransport);
            this.Name = "FormTravelReservation";
            this.Text = "FormTravelReservation";
            this.Load += new System.EventHandler(this.FormTravelReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTransport;
        private System.Windows.Forms.DataGridView dataGridViewRoute;
        private System.Windows.Forms.Button buttonRoute;
        private System.Windows.Forms.Button buttonTransport;
        private System.Windows.Forms.DateTimePicker dateTimePickerTravelFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTravelTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerHotelFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerHotelTo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.Button buttonHotelRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}