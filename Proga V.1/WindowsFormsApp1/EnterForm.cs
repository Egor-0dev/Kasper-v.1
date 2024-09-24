using System;
using System.Drawing;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EnterForm : Form
    {
        public EnterForm()
        {
            InitializeComponent();
        }

  

        private void Enter_Btn_Click(object sender, EventArgs e)
        {
            string username = Login_text.Text;
            string password = Password_text.Text;

           
            if (username == "admin" && password == "123")
            {
                this.Hide();


                MainForm main = new MainForm();
                main.ShowDialog();

                
                this.Close();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }
        }

        private void Registr_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrForm Rfrm = new RegistrForm();
            Rfrm.ShowDialog();
        }

        private void Login_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Enter_Btn_MouseEnter(object sender, EventArgs e)
        {
           
            Enter_Btn.Font = new Font(Enter_Btn.Font.FontFamily, 14, FontStyle.Bold);
            Enter_Btn.ForeColor = Color.Red; 


        }

        private void Enter_Btn_MouseLeave(object sender, EventArgs e)
        {
            
            Enter_Btn.Font = new Font(Enter_Btn.Font.FontFamily, 10, FontStyle.Regular);
            Enter_Btn.ForeColor = Color.Black; 
        }

       

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Registr_label_MouseEnter(object sender, EventArgs e)
        {
            Registr_label.Font = new Font(Registr_label.Font, FontStyle.Underline);

        }

        private void Registr_label_MouseLeave(object sender, EventArgs e)
        {
            Registr_label.Font = new Font(Registr_label.Font.FontFamily, Registr_label.Font.Size, FontStyle.Regular);

        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            Close.Font = new Font(Close.Font.FontFamily, 10, FontStyle.Bold);
            Close.ForeColor = Color.Red;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Close.Font = new Font(Close.Font.FontFamily, 8, FontStyle.Regular);
            Close.ForeColor = Color.Black;
        }

        private void EnterForm_Load(object sender, EventArgs e)
        {

        }
    }
}
    
