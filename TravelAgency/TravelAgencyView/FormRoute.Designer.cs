
namespace TravelAgencyView
{
    partial class FormRoute
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
            this.textBoxCityFrom = new System.Windows.Forms.TextBox();
            this.labelCityFrom = new System.Windows.Forms.Label();
            this.labelCityTo = new System.Windows.Forms.Label();
            this.textBoxCityTo = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonTransport = new System.Windows.Forms.Button();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxCityFrom
            // 
            this.textBoxCityFrom.Location = new System.Drawing.Point(146, 22);
            this.textBoxCityFrom.Name = "textBoxCityFrom";
            this.textBoxCityFrom.Size = new System.Drawing.Size(132, 20);
            this.textBoxCityFrom.TabIndex = 22;
            // 
            // labelCityFrom
            // 
            this.labelCityFrom.AutoSize = true;
            this.labelCityFrom.Location = new System.Drawing.Point(32, 25);
            this.labelCityFrom.Name = "labelCityFrom";
            this.labelCityFrom.Size = new System.Drawing.Size(79, 13);
            this.labelCityFrom.TabIndex = 21;
            this.labelCityFrom.Text = "Родной город:";
            // 
            // labelCityTo
            // 
            this.labelCityTo.AutoSize = true;
            this.labelCityTo.Location = new System.Drawing.Point(32, 66);
            this.labelCityTo.Name = "labelCityTo";
            this.labelCityTo.Size = new System.Drawing.Size(108, 13);
            this.labelCityTo.TabIndex = 23;
            this.labelCityTo.Text = "Город путешествия:";
            // 
            // textBoxCityTo
            // 
            this.textBoxCityTo.Location = new System.Drawing.Point(146, 63);
            this.textBoxCityTo.Name = "textBoxCityTo";
            this.textBoxCityTo.Size = new System.Drawing.Size(132, 20);
            this.textBoxCityTo.TabIndex = 24;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 130);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(337, 208);
            this.dataGridView.TabIndex = 25;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(388, 283);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(97, 23);
            this.buttonCancel.TabIndex = 27;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(388, 221);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(97, 23);
            this.buttonSave.TabIndex = 26;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonTransport
            // 
            this.buttonTransport.Location = new System.Drawing.Point(388, 154);
            this.buttonTransport.Name = "buttonTransport";
            this.buttonTransport.Size = new System.Drawing.Size(97, 23);
            this.buttonTransport.TabIndex = 29;
            this.buttonTransport.Text = "Передвижение";
            this.buttonTransport.UseVisualStyleBackColor = true;
            this.buttonTransport.Click += new System.EventHandler(this.buttonTransport_Click);
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(146, 104);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(132, 20);
            this.textBoxPrice.TabIndex = 30;
            this.textBoxPrice.TextChanged += new System.EventHandler(this.textBoxPrice_TextChanged);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(89, 107);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(36, 13);
            this.labelPrice.TabIndex = 31;
            this.labelPrice.Text = "Цена:";
            // 
            // FormRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 358);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.buttonTransport);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.textBoxCityTo);
            this.Controls.Add(this.labelCityTo);
            this.Controls.Add(this.textBoxCityFrom);
            this.Controls.Add(this.labelCityFrom);
            this.Name = "FormRoute";
            this.Text = "Создание направления путешествия";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCityFrom;
        private System.Windows.Forms.Label labelCityFrom;
        private System.Windows.Forms.Label labelCityTo;
        private System.Windows.Forms.TextBox textBoxCityTo;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonTransport;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Label labelPrice;
    }
}