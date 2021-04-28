
namespace TravelAgencyView
{
    partial class FormAdminTravelReservation
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
            this.buttonHotelRoom = new System.Windows.Forms.Button();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewRooms = new System.Windows.Forms.DataGridView();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerHotelTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerHotelFrom = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTravelTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerTravelFrom = new System.Windows.Forms.DateTimePicker();
            this.buttonTransport = new System.Windows.Forms.Button();
            this.buttonRoute = new System.Windows.Forms.Button();
            this.dataGridViewRoute = new System.Windows.Forms.DataGridView();
            this.dataGridViewTransport = new System.Windows.Forms.DataGridView();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.buttonClient = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoute)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHotelRoom
            // 
            this.buttonHotelRoom.Location = new System.Drawing.Point(542, 432);
            this.buttonHotelRoom.Name = "buttonHotelRoom";
            this.buttonHotelRoom.Size = new System.Drawing.Size(90, 40);
            this.buttonHotelRoom.TabIndex = 37;
            this.buttonHotelRoom.Text = "Выбрать проживание";
            this.buttonHotelRoom.UseVisualStyleBackColor = true;
            this.buttonHotelRoom.Click += new System.EventHandler(this.buttonHotelRoom_Click);
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Вид ";
            this.Column4.Name = "Column4";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Тип номера";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Отель";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "id";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
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
            this.dataGridViewRooms.Location = new System.Drawing.Point(487, 211);
            this.dataGridViewRooms.Name = "dataGridViewRooms";
            this.dataGridViewRooms.Size = new System.Drawing.Size(444, 212);
            this.dataGridViewRooms.TabIndex = 36;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Цена";
            this.Column5.Name = "Column5";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(388, 333);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 35;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(388, 375);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 34;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Даты заселения/ выселения в отель:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Даты путешествия:";
            // 
            // dateTimePickerHotelTo
            // 
            this.dateTimePickerHotelTo.Location = new System.Drawing.Point(386, 170);
            this.dateTimePickerHotelTo.Name = "dateTimePickerHotelTo";
            this.dateTimePickerHotelTo.Size = new System.Drawing.Size(118, 20);
            this.dateTimePickerHotelTo.TabIndex = 31;
            // 
            // dateTimePickerHotelFrom
            // 
            this.dateTimePickerHotelFrom.Location = new System.Drawing.Point(386, 131);
            this.dateTimePickerHotelFrom.Name = "dateTimePickerHotelFrom";
            this.dateTimePickerHotelFrom.Size = new System.Drawing.Size(118, 20);
            this.dateTimePickerHotelFrom.TabIndex = 30;
            // 
            // dateTimePickerTravelTo
            // 
            this.dateTimePickerTravelTo.Location = new System.Drawing.Point(386, 86);
            this.dateTimePickerTravelTo.Name = "dateTimePickerTravelTo";
            this.dateTimePickerTravelTo.Size = new System.Drawing.Size(118, 20);
            this.dateTimePickerTravelTo.TabIndex = 29;
            // 
            // dateTimePickerTravelFrom
            // 
            this.dateTimePickerTravelFrom.Location = new System.Drawing.Point(388, 46);
            this.dateTimePickerTravelFrom.Name = "dateTimePickerTravelFrom";
            this.dateTimePickerTravelFrom.Size = new System.Drawing.Size(116, 20);
            this.dateTimePickerTravelFrom.TabIndex = 28;
            // 
            // buttonTransport
            // 
            this.buttonTransport.Location = new System.Drawing.Point(39, 429);
            this.buttonTransport.Name = "buttonTransport";
            this.buttonTransport.Size = new System.Drawing.Size(123, 23);
            this.buttonTransport.TabIndex = 27;
            this.buttonTransport.Text = "Выбрать транспорт";
            this.buttonTransport.UseVisualStyleBackColor = true;
            this.buttonTransport.Click += new System.EventHandler(this.buttonTransport_Click);
            // 
            // buttonRoute
            // 
            this.buttonRoute.Location = new System.Drawing.Point(81, 171);
            this.buttonRoute.Name = "buttonRoute";
            this.buttonRoute.Size = new System.Drawing.Size(121, 23);
            this.buttonRoute.TabIndex = 26;
            this.buttonRoute.Text = " Выбрать маршрут";
            this.buttonRoute.UseVisualStyleBackColor = true;
            this.buttonRoute.Click += new System.EventHandler(this.buttonRoute_Click);
            // 
            // dataGridViewRoute
            // 
            this.dataGridViewRoute.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewRoute.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRoute.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewRoute.Name = "dataGridViewRoute";
            this.dataGridViewRoute.Size = new System.Drawing.Size(353, 150);
            this.dataGridViewRoute.TabIndex = 25;
            // 
            // dataGridViewTransport
            // 
            this.dataGridViewTransport.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewTransport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTransport.Location = new System.Drawing.Point(12, 200);
            this.dataGridViewTransport.Name = "dataGridViewTransport";
            this.dataGridViewTransport.Size = new System.Drawing.Size(353, 223);
            this.dataGridViewTransport.TabIndex = 24;
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Location = new System.Drawing.Point(578, 19);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.Size = new System.Drawing.Size(353, 143);
            this.dataGridViewClient.TabIndex = 38;
            // 
            // buttonClient
            // 
            this.buttonClient.Location = new System.Drawing.Point(707, 171);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(129, 23);
            this.buttonClient.TabIndex = 39;
            this.buttonClient.Text = "Выбрать клиента";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // FormAdminTravelReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(952, 483);
            this.Controls.Add(this.buttonClient);
            this.Controls.Add(this.dataGridViewClient);
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
            this.Name = "FormAdminTravelReservation";
            this.Text = "FormAdminTravelReservation";
            this.Load += new System.EventHandler(this.FormTravelReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRoute)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTransport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonHotelRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridViewRooms;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerHotelTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerHotelFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTravelTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerTravelFrom;
        private System.Windows.Forms.Button buttonTransport;
        private System.Windows.Forms.Button buttonRoute;
        private System.Windows.Forms.DataGridView dataGridViewRoute;
        private System.Windows.Forms.DataGridView dataGridViewTransport;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.Button buttonClient;
    }
}