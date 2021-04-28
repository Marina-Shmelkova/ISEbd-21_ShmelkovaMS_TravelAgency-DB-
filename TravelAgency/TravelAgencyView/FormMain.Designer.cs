
namespace TravelAgencyView
{
    partial class FormMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.направленияОтдыхаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.транспортToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отелиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.номераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.типНомераToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.забронироватьПутешествиеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.маршрутыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проживаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.контрактыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.забронироватьПутешествиеToolStripMenuItem,
            this.маршрутыToolStripMenuItem,
            this.проживаниеToolStripMenuItem,
            this.контрактыToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(735, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.направленияОтдыхаToolStripMenuItem,
            this.транспортToolStripMenuItem,
            this.отелиToolStripMenuItem,
            this.номераToolStripMenuItem,
            this.типНомераToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // направленияОтдыхаToolStripMenuItem
            // 
            this.направленияОтдыхаToolStripMenuItem.Name = "направленияОтдыхаToolStripMenuItem";
            this.направленияОтдыхаToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.направленияОтдыхаToolStripMenuItem.Text = "Направления отдыха";
            this.направленияОтдыхаToolStripMenuItem.Click += new System.EventHandler(this.направленияОтдыхаToolStripMenuItem_Click);
            // 
            // транспортToolStripMenuItem
            // 
            this.транспортToolStripMenuItem.Name = "транспортToolStripMenuItem";
            this.транспортToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.транспортToolStripMenuItem.Text = "Транспорт";
            this.транспортToolStripMenuItem.Click += new System.EventHandler(this.транспортToolStripMenuItem_Click);
            // 
            // отелиToolStripMenuItem
            // 
            this.отелиToolStripMenuItem.Name = "отелиToolStripMenuItem";
            this.отелиToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.отелиToolStripMenuItem.Text = "Отели";
            this.отелиToolStripMenuItem.Click += new System.EventHandler(this.отелиToolStripMenuItem_Click);
            // 
            // номераToolStripMenuItem
            // 
            this.номераToolStripMenuItem.Name = "номераToolStripMenuItem";
            this.номераToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.номераToolStripMenuItem.Text = "Номера";
            this.номераToolStripMenuItem.Click += new System.EventHandler(this.номераToolStripMenuItem_Click);
            // 
            // типНомераToolStripMenuItem
            // 
            this.типНомераToolStripMenuItem.Name = "типНомераToolStripMenuItem";
            this.типНомераToolStripMenuItem.Size = new System.Drawing.Size(190, 22);
            this.типНомераToolStripMenuItem.Text = "Тип номера";
            this.типНомераToolStripMenuItem.Click += new System.EventHandler(this.типНомераToolStripMenuItem_Click);
            // 
            // забронироватьПутешествиеToolStripMenuItem
            // 
            this.забронироватьПутешествиеToolStripMenuItem.Name = "забронироватьПутешествиеToolStripMenuItem";
            this.забронироватьПутешествиеToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.забронироватьПутешествиеToolStripMenuItem.Text = "Забронировать путешествие";
            this.забронироватьПутешествиеToolStripMenuItem.Click += new System.EventHandler(this.забронироватьПутешествиеToolStripMenuItem_Click);
            // 
            // маршрутыToolStripMenuItem
            // 
            this.маршрутыToolStripMenuItem.Name = "маршрутыToolStripMenuItem";
            this.маршрутыToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.маршрутыToolStripMenuItem.Text = "Маршруты ";
            this.маршрутыToolStripMenuItem.Click += new System.EventHandler(this.МаршрутыToolStripMenuItem_Click);
            // 
            // проживаниеToolStripMenuItem
            // 
            this.проживаниеToolStripMenuItem.Name = "проживаниеToolStripMenuItem";
            this.проживаниеToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.проживаниеToolStripMenuItem.Text = "Проживание";
            this.проживаниеToolStripMenuItem.Click += new System.EventHandler(this.ПроживаниеToolStripMenuItem_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(0, 27);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(735, 355);
            this.dataGridView.TabIndex = 2;
            // 
            // контрактыToolStripMenuItem
            // 
            this.контрактыToolStripMenuItem.Name = "контрактыToolStripMenuItem";
            this.контрактыToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.контрактыToolStripMenuItem.Text = "Контракты";
            this.контрактыToolStripMenuItem.Click += new System.EventHandler(this.контрактыToolStripMenuItem_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 379);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMain";
            this.Text = "Главная форма клиента";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem направленияОтдыхаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem транспортToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отелиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem номераToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem забронироватьПутешествиеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem типНомераToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.ToolStripMenuItem маршрутыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проживаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem контрактыToolStripMenuItem;
    }
}