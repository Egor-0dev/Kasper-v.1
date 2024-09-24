using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class RegistrForm : Form
    {
        public RegistrForm()
        {
            InitializeComponent();
        }

        private void Registr_label_Click(object sender, EventArgs e)
        {
           this.Close();
            RegistrForm Rfrm = new RegistrForm();   
            Rfrm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Password_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegistrForm_Load(object sender, EventArgs e)
        {

        }
    }
}
