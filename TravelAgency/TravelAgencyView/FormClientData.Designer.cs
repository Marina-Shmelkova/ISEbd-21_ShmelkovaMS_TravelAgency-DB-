
namespace TravelAgencyView
{
    partial class FormClientData
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
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelFIO = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxPhonenumber = new System.Windows.Forms.TextBox();
            this.labelPhonenumber = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(136, 150);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(118, 20);
            this.dateTimePicker.TabIndex = 15;
            this.dateTimePicker.Value = new System.DateTime(2001, 7, 11, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Дата рождения:";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(136, 47);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(118, 20);
            this.textBoxName.TabIndex = 13;
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(57, 50);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(37, 13);
            this.labelFIO.TabIndex = 12;
            this.labelFIO.Text = "ФИО:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(81, 210);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 11;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // textBoxPhonenumber
            // 
            this.textBoxPhonenumber.Location = new System.Drawing.Point(136, 95);
            this.textBoxPhonenumber.Name = "textBoxPhonenumber";
            this.textBoxPhonenumber.Size = new System.Drawing.Size(118, 20);
            this.textBoxPhonenumber.TabIndex = 16;
            // 
            // labelPhonenumber
            // 
            this.labelPhonenumber.AutoSize = true;
            this.labelPhonenumber.Location = new System.Drawing.Point(32, 98);
            this.labelPhonenumber.Name = "labelPhonenumber";
            this.labelPhonenumber.Size = new System.Drawing.Size(96, 13);
            this.labelPhonenumber.TabIndex = 17;
            this.labelPhonenumber.Text = "Номер телефона:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(179, 210);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormClientData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 267);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelPhonenumber);
            this.Controls.Add(this.textBoxPhonenumber);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.buttonSave);
            this.Name = "FormClientData";
            this.Text = "Личные данные";
            this.Load += new System.EventHandler(this.FormClientData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxPhonenumber;
        private System.Windows.Forms.Label labelPhonenumber;
        private System.Windows.Forms.Button buttonCancel;
    }
}