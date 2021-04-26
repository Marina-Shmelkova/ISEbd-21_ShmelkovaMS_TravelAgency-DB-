﻿
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.labelTransport = new System.Windows.Forms.Label();
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
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(255, 344);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(97, 23);
            this.buttonCancel.TabIndex = 27;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(105, 344);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(97, 23);
            this.buttonSave.TabIndex = 26;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(12, 108);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(445, 209);
            this.dataGridView.TabIndex = 28;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(341, 56);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 29;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // labelTransport
            // 
            this.labelTransport.AutoSize = true;
            this.labelTransport.Location = new System.Drawing.Point(317, 22);
            this.labelTransport.Name = "labelTransport";
            this.labelTransport.Size = new System.Drawing.Size(124, 13);
            this.labelTransport.TabIndex = 33;
            this.labelTransport.Text = "Способ передвижения:";
            // 
            // FormRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 396);
            this.Controls.Add(this.labelTransport);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxCityTo);
            this.Controls.Add(this.labelCityTo);
            this.Controls.Add(this.textBoxCityFrom);
            this.Controls.Add(this.labelCityFrom);
            this.Name = "FormRoute";
            this.Text = "Создание направления путешествия";
            this.Load += new System.EventHandler(this.FormRoute_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCityFrom;
        private System.Windows.Forms.Label labelCityFrom;
        private System.Windows.Forms.Label labelCityTo;
        private System.Windows.Forms.TextBox textBoxCityTo;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label labelTransport;
    }
}