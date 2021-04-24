
namespace TravelAgencyView
{
    partial class FormTransport
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
            this.labelRoutefrom = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxRoutefrom = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxRouteto = new System.Windows.Forms.TextBox();
            this.textBoxViewTransport = new System.Windows.Forms.TextBox();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelRoutefrom
            // 
            this.labelRoutefrom.AutoSize = true;
            this.labelRoutefrom.Location = new System.Drawing.Point(55, 48);
            this.labelRoutefrom.Name = "labelRoutefrom";
            this.labelRoutefrom.Size = new System.Drawing.Size(108, 13);
            this.labelRoutefrom.TabIndex = 0;
            this.labelRoutefrom.Text = "Город отправления:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Город прибытия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(71, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Вид транспорта:";
            // 
            // textBoxRoutefrom
            // 
            this.textBoxRoutefrom.Location = new System.Drawing.Point(169, 45);
            this.textBoxRoutefrom.Name = "textBoxRoutefrom";
            this.textBoxRoutefrom.Size = new System.Drawing.Size(132, 20);
            this.textBoxRoutefrom.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Цена билета:";
            // 
            // textBoxRouteto
            // 
            this.textBoxRouteto.Location = new System.Drawing.Point(169, 93);
            this.textBoxRouteto.Name = "textBoxRouteto";
            this.textBoxRouteto.Size = new System.Drawing.Size(132, 20);
            this.textBoxRouteto.TabIndex = 6;
            // 
            // textBoxViewTransport
            // 
            this.textBoxViewTransport.Location = new System.Drawing.Point(169, 147);
            this.textBoxViewTransport.Name = "textBoxViewTransport";
            this.textBoxViewTransport.Size = new System.Drawing.Size(132, 20);
            this.textBoxViewTransport.TabIndex = 7;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(169, 191);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(132, 20);
            this.textBoxPrice.TabIndex = 8;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(119, 254);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(226, 254);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Отменить";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // FormTransport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 324);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxViewTransport);
            this.Controls.Add(this.textBoxRouteto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxRoutefrom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelRoutefrom);
            this.Name = "FormTransport";
            this.Text = "Создание маршрута";
            this.Load += new System.EventHandler(this.FormTransport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelRoutefrom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxRoutefrom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxRouteto;
        private System.Windows.Forms.TextBox textBoxViewTransport;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
    }
}