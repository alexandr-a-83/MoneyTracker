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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAddTransaction_Click(object sender, EventArgs e)
        {
            decimal TransValue = Convert.ToDecimal(textBoxValue.Text);
            string TranDescription = textBoxDescription.Text;
            DateTime TransDate = dateTimePickerTransaction.Value;
            int TransType = 0;

            if (radioButtonPay.Checked)
            {
                TransType = 0;
            }

            if (radioButtonIncom.Checked)
            {
                TransType = 1;
            }

            DataSet1TableAdapters.TransactionsTableTableAdapter MyAdapter = 
                    new DataSet1TableAdapters.TransactionsTableTableAdapter();

            MyAdapter.InsertTransaction(TransValue, TranDescription, TransDate, Convert.ToBoolean(TransType));
            MessageBox.Show("Запись добавлена");
            
            textBoxValue.Clear();
            textBoxDescription.Clear();
            radioButtonPay.Checked = true;
            radioButtonIncom.Checked = false;

            this.transactionsTableTableAdapter.Fill(this.dataSet1.TransactionsTable);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.TransactionsTable' table. You can move, or remove it, as needed.
            this.transactionsTableTableAdapter.Fill(this.dataSet1.TransactionsTable);

        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            transactionsTableTableAdapter.Update(dataSet1);
            dataGridView1.EndEdit();

            this.transactionsTableTableAdapter.Fill(this.dataSet1.TransactionsTable);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonUpdatePassword_Click(object sender, EventArgs e)
        {
            if (textBoxNewPassword.Text != null 
                    && textBoxNewPassword.Text != Properties.Settings.Default.apppassword 
                    && textBoxNewPassword.Text == textBoxNewPasswordAgain.Text)
            {
                Properties.Settings.Default.apppassword = textBoxNewPassword.Text;
                Properties.Settings.Default.Save();
                MessageBox.Show("Пароль успешно обновлен");
            }
            else
            {
                MessageBox.Show("Пароль не был изменен");
            }


            textBoxNewPassword.Text = null;
            textBoxNewPasswordAgain.Text = null;
        }

        private void textBoxNewPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
