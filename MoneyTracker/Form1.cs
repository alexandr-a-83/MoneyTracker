using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyTracker
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxPassword.Text == Properties.Settings.Default.apppassword)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();

            }
            else
            {
                textBoxPassword.Text = "";
                MessageBox.Show("ACCESS DENIED");
            }
            
        
        }
    }
}
