
namespace TravelAgencyView
{
    partial class FormRoom
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelType = new System.Windows.Forms.Label();
            this.labelView = new System.Windows.Forms.Label();
            this.labelDatearrival = new System.Windows.Forms.Label();
            this.labelDateofdeparture = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxView = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(199, 258);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(82, 258);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 17;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelType
            // 
            this.labelType.AutoSize = true;
            this.labelType.Location = new System.Drawing.Point(57, 31);
            this.labelType.Name = "labelType";
            this.labelType.Size = new System.Drawing.Size(70, 13);
            this.labelType.TabIndex = 19;
            this.labelType.Text = "Тип номера:";
            // 
            // labelView
            // 
            this.labelView.AutoSize = true;
            this.labelView.Location = new System.Drawing.Point(57, 72);
            this.labelView.Name = "labelView";
            this.labelView.Size = new System.Drawing.Size(70, 13);
            this.labelView.TabIndex = 20;
            this.labelView.Text = "Вид номера:";
            // 
            // labelDatearrival
            // 
            this.labelDatearrival.AutoSize = true;
            this.labelDatearrival.Location = new System.Drawing.Point(57, 117);
            this.labelDatearrival.Name = "labelDatearrival";
            this.labelDatearrival.Size = new System.Drawing.Size(75, 13);
            this.labelDatearrival.TabIndex = 21;
            this.labelDatearrival.Text = "Дата заезда:";
            // 
            // labelDateofdeparture
            // 
            this.labelDateofdeparture.AutoSize = true;
            this.labelDateofdeparture.Location = new System.Drawing.Point(55, 157);
            this.labelDateofdeparture.Name = "labelDateofdeparture";
            this.labelDateofdeparture.Size = new System.Drawing.Size(77, 13);
            this.labelDateofdeparture.TabIndex = 22;
            this.labelDateofdeparture.Text = "Дата выезда:";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(89, 214);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(36, 13);
            this.labelPrice.TabIndex = 23;
            this.labelPrice.Text = "Цена:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(153, 28);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(121, 21);
            this.comboBoxType.TabIndex = 24;
            // 
            // textBoxView
            // 
            this.textBoxView.Location = new System.Drawing.Point(153, 72);
            this.textBoxView.Name = "textBoxView";
            this.textBoxView.Size = new System.Drawing.Size(121, 20);
            this.textBoxView.TabIndex = 25;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(153, 211);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(121, 20);
            this.textBoxPrice.TabIndex = 28;
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Location = new System.Drawing.Point(156, 117);
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            this.dateTimePickerTo.Size = new System.Drawing.Size(118, 20);
            this.dateTimePickerTo.TabIndex = 29;
            this.dateTimePickerTo.Value = new System.DateTime(2001, 7, 11, 0, 0, 0, 0);
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Location = new System.Drawing.Point(156, 157);
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            this.dateTimePickerFrom.Size = new System.Drawing.Size(118, 20);
            this.dateTimePickerFrom.TabIndex = 30;
            this.dateTimePickerFrom.Value = new System.DateTime(2001, 7, 11, 0, 0, 0, 0);
            // 
            // FormRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 324);
            this.Controls.Add(this.dateTimePickerFrom);
            this.Controls.Add(this.dateTimePickerTo);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxView);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelDateofdeparture);
            this.Controls.Add(this.labelDatearrival);
            this.Controls.Add(this.labelView);
            this.Controls.Add(this.labelType);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormRoom";
            this.Text = "Создание номера";
            this.Load += new System.EventHandler(this.FormRoom_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelType;
        private System.Windows.Forms.Label labelView;
        private System.Windows.Forms.Label labelDatearrival;
        private System.Windows.Forms.Label labelDateofdeparture;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxView;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
    }
}