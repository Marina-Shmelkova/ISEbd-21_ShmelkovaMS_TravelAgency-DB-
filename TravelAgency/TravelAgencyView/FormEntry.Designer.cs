
namespace TravelAgencyView
{
    partial class FormEntry
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSingOut = new System.Windows.Forms.Button();
            this.buttonSingIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSingOut
            // 
            this.buttonSingOut.Location = new System.Drawing.Point(163, 66);
            this.buttonSingOut.Name = "buttonSingOut";
            this.buttonSingOut.Size = new System.Drawing.Size(127, 23);
            this.buttonSingOut.TabIndex = 3;
            this.buttonSingOut.Text = "Зарегистрироваться";
            this.buttonSingOut.UseVisualStyleBackColor = true;
            this.buttonSingOut.Click += new System.EventHandler(this.buttonSingOut_Click);
            // 
            // buttonSingIn
            // 
            this.buttonSingIn.Location = new System.Drawing.Point(59, 66);
            this.buttonSingIn.Name = "buttonSingIn";
            this.buttonSingIn.Size = new System.Drawing.Size(75, 23);
            this.buttonSingIn.TabIndex = 2;
            this.buttonSingIn.Text = "Войти";
            this.buttonSingIn.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 162);
            this.Controls.Add(this.buttonSingOut);
            this.Controls.Add(this.buttonSingIn);
            this.Name = "FormMain";
            this.Text = "Вход";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSingOut;
        private System.Windows.Forms.Button buttonSingIn;
    }
}

