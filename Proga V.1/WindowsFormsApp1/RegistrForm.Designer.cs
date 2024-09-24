namespace WindowsFormsApp1
{
    partial class RegistrForm
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
            this.Enter_Btn = new System.Windows.Forms.Button();
            this.Login_text = new System.Windows.Forms.TextBox();
            this.Password_text = new System.Windows.Forms.TextBox();
            this.Close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Enter_Btn
            // 
            this.Enter_Btn.Location = new System.Drawing.Point(280, 428);
            this.Enter_Btn.Name = "Enter_Btn";
            this.Enter_Btn.Size = new System.Drawing.Size(254, 71);
            this.Enter_Btn.TabIndex = 1;
            this.Enter_Btn.Text = "Зарегистрироваться";
            this.Enter_Btn.UseVisualStyleBackColor = true;
            // 
            // Login_text
            // 
            this.Login_text.Location = new System.Drawing.Point(293, 200);
            this.Login_text.Name = "Login_text";
            this.Login_text.Size = new System.Drawing.Size(228, 20);
            this.Login_text.TabIndex = 2;
            this.Login_text.TextChanged += new System.EventHandler(this.Login_text_TextChanged);
            // 
            // Password_text
            // 
            this.Password_text.Location = new System.Drawing.Point(293, 275);
            this.Password_text.Name = "Password_text";
            this.Password_text.Size = new System.Drawing.Size(228, 20);
            this.Password_text.TabIndex = 3;
            this.Password_text.TextChanged += new System.EventHandler(this.Password_text_TextChanged);
            // 
            // Close
            // 
            this.Close.Location = new System.Drawing.Point(742, 12);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(34, 25);
            this.Close.TabIndex = 9;
            this.Close.Text = "X";
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // RegistrForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.Close);
            this.Controls.Add(this.Password_text);
            this.Controls.Add(this.Login_text);
            this.Controls.Add(this.Enter_Btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrForm";
            this.Text = "RegistrForm";
            this.Load += new System.EventHandler(this.RegistrForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enter_Btn;
        private System.Windows.Forms.TextBox Login_text;
        private System.Windows.Forms.TextBox Password_text;
        private System.Windows.Forms.Button Close;
    }
}