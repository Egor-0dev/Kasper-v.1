namespace WindowsFormsApp1
{
    partial class EnterForm
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
            this.Enter_Btn = new System.Windows.Forms.Button();
            this.Login_text = new System.Windows.Forms.TextBox();
            this.Password_text = new System.Windows.Forms.TextBox();
            this.Close = new System.Windows.Forms.Button();
            this.Registr_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Enter_Btn
            // 
            this.Enter_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Enter_Btn.Location = new System.Drawing.Point(270, 426);
            this.Enter_Btn.Name = "Enter_Btn";
            this.Enter_Btn.Size = new System.Drawing.Size(254, 71);
            this.Enter_Btn.TabIndex = 0;
            this.Enter_Btn.Text = "Войти";
            this.Enter_Btn.UseVisualStyleBackColor = true;
            this.Enter_Btn.Click += new System.EventHandler(this.Enter_Btn_Click);
            this.Enter_Btn.MouseEnter += new System.EventHandler(this.Enter_Btn_MouseEnter);
            this.Enter_Btn.MouseLeave += new System.EventHandler(this.Enter_Btn_MouseLeave);
            // 
            // Login_text
            // 
            this.Login_text.Location = new System.Drawing.Point(285, 142);
            this.Login_text.Name = "Login_text";
            this.Login_text.Size = new System.Drawing.Size(228, 20);
            this.Login_text.TabIndex = 1;
            this.Login_text.TextChanged += new System.EventHandler(this.Login_text_TextChanged);
            // 
            // Password_text
            // 
            this.Password_text.Location = new System.Drawing.Point(285, 236);
            this.Password_text.Name = "Password_text";
            this.Password_text.Size = new System.Drawing.Size(228, 20);
            this.Password_text.TabIndex = 2;
            // 
            // Close
            // 
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Location = new System.Drawing.Point(754, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(34, 25);
            this.Close.TabIndex = 3;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // Registr_label
            // 
            this.Registr_label.AutoSize = true;
            this.Registr_label.Location = new System.Drawing.Point(354, 512);
            this.Registr_label.Name = "Registr_label";
            this.Registr_label.Size = new System.Drawing.Size(72, 13);
            this.Registr_label.TabIndex = 6;
            this.Registr_label.Text = "Регистрация";
            this.Registr_label.Click += new System.EventHandler(this.Registr_label_Click);
            this.Registr_label.MouseEnter += new System.EventHandler(this.Registr_label_MouseEnter);
            this.Registr_label.MouseLeave += new System.EventHandler(this.Registr_label_MouseLeave);
            // 
            // EnterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Registr_label);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Password_text);
            this.Controls.Add(this.Login_text);
            this.Controls.Add(this.Enter_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnterForm";
            this.Load += new System.EventHandler(this.EnterForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enter_Btn;
        private System.Windows.Forms.TextBox Login_text;
        private System.Windows.Forms.TextBox Password_text;
        private System.Windows.Forms.Button Close;
        private System.Windows.Forms.Label Registr_label;
    }
}

