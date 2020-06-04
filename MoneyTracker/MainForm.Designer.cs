namespace MoneyTracker
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.textBoxValue = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerTransaction = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonPay = new System.Windows.Forms.RadioButton();
            this.radioButtonIncom = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.transactionValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transTypeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.counterIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transactionsTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new MoneyTracker.DataSet1();
            this.buttonAddTransaction = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.transactionsTableTableAdapter = new MoneyTracker.DataSet1TableAdapters.TransactionsTableTableAdapter();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.buttonUpdatePassword = new System.Windows.Forms.Button();
            this.textBoxNewPasswordAgain = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxValue
            // 
            this.textBoxValue.Location = new System.Drawing.Point(66, 54);
            this.textBoxValue.Name = "textBoxValue";
            this.textBoxValue.Size = new System.Drawing.Size(131, 22);
            this.textBoxValue.TabIndex = 0;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(66, 127);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(659, 40);
            this.textBoxDescription.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Сумма транзакции";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание";
            // 
            // dateTimePickerTransaction
            // 
            this.dateTimePickerTransaction.Location = new System.Drawing.Point(66, 211);
            this.dateTimePickerTransaction.Name = "dateTimePickerTransaction";
            this.dateTimePickerTransaction.Size = new System.Drawing.Size(200, 22);
            this.dateTimePickerTransaction.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата";
            // 
            // radioButtonPay
            // 
            this.radioButtonPay.AutoSize = true;
            this.radioButtonPay.Checked = true;
            this.radioButtonPay.Location = new System.Drawing.Point(66, 251);
            this.radioButtonPay.Name = "radioButtonPay";
            this.radioButtonPay.Size = new System.Drawing.Size(79, 21);
            this.radioButtonPay.TabIndex = 6;
            this.radioButtonPay.TabStop = true;
            this.radioButtonPay.Text = "Оплата";
            this.radioButtonPay.UseVisualStyleBackColor = true;
            // 
            // radioButtonIncom
            // 
            this.radioButtonIncom.AutoSize = true;
            this.radioButtonIncom.Location = new System.Drawing.Point(186, 251);
            this.radioButtonIncom.Name = "radioButtonIncom";
            this.radioButtonIncom.Size = new System.Drawing.Size(102, 21);
            this.radioButtonIncom.TabIndex = 7;
            this.radioButtonIncom.Text = "Получение";
            this.radioButtonIncom.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.transactionValueDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.transDateDataGridViewTextBoxColumn,
            this.transTypeDataGridViewCheckBoxColumn,
            this.counterIDDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.transactionsTableBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(66, 313);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(659, 368);
            this.dataGridView1.TabIndex = 8;
            // 
            // transactionValueDataGridViewTextBoxColumn
            // 
            this.transactionValueDataGridViewTextBoxColumn.DataPropertyName = "TransactionValue";
            this.transactionValueDataGridViewTextBoxColumn.HeaderText = "TransactionValue";
            this.transactionValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transactionValueDataGridViewTextBoxColumn.Name = "transactionValueDataGridViewTextBoxColumn";
            this.transactionValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // transDateDataGridViewTextBoxColumn
            // 
            this.transDateDataGridViewTextBoxColumn.DataPropertyName = "TransDate";
            this.transDateDataGridViewTextBoxColumn.HeaderText = "TransDate";
            this.transDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transDateDataGridViewTextBoxColumn.Name = "transDateDataGridViewTextBoxColumn";
            this.transDateDataGridViewTextBoxColumn.Width = 125;
            // 
            // transTypeDataGridViewCheckBoxColumn
            // 
            this.transTypeDataGridViewCheckBoxColumn.DataPropertyName = "TransType";
            this.transTypeDataGridViewCheckBoxColumn.HeaderText = "TransType";
            this.transTypeDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.transTypeDataGridViewCheckBoxColumn.Name = "transTypeDataGridViewCheckBoxColumn";
            this.transTypeDataGridViewCheckBoxColumn.Width = 125;
            // 
            // counterIDDataGridViewTextBoxColumn
            // 
            this.counterIDDataGridViewTextBoxColumn.DataPropertyName = "CounterID";
            this.counterIDDataGridViewTextBoxColumn.HeaderText = "CounterID";
            this.counterIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.counterIDDataGridViewTextBoxColumn.Name = "counterIDDataGridViewTextBoxColumn";
            this.counterIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.counterIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // transactionsTableBindingSource
            // 
            this.transactionsTableBindingSource.DataMember = "TransactionsTable";
            this.transactionsTableBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonAddTransaction
            // 
            this.buttonAddTransaction.Location = new System.Drawing.Point(561, 211);
            this.buttonAddTransaction.Name = "buttonAddTransaction";
            this.buttonAddTransaction.Size = new System.Drawing.Size(164, 24);
            this.buttonAddTransaction.TabIndex = 9;
            this.buttonAddTransaction.Text = "Добравить транзакцию";
            this.buttonAddTransaction.UseVisualStyleBackColor = true;
            this.buttonAddTransaction.Click += new System.EventHandler(this.buttonAddTransaction_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 293);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Мои транзакции";
            // 
            // transactionsTableTableAdapter
            // 
            this.transactionsTableTableAdapter.ClearBeforeFill = true;
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(561, 283);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(164, 24);
            this.buttonUpdate.TabIndex = 11;
            this.buttonUpdate.Text = "Обновить";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Location = new System.Drawing.Point(566, 34);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(159, 17);
            this.labelNewPassword.TabIndex = 13;
            this.labelNewPassword.Text = "Введите новый пароль";
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.Location = new System.Drawing.Point(561, 54);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.PasswordChar = '*';
            this.textBoxNewPassword.Size = new System.Drawing.Size(164, 22);
            this.textBoxNewPassword.TabIndex = 12;
            this.textBoxNewPassword.TextChanged += new System.EventHandler(this.textBoxNewPassword_TextChanged);
            // 
            // buttonUpdatePassword
            // 
            this.buttonUpdatePassword.Location = new System.Drawing.Point(561, 82);
            this.buttonUpdatePassword.Name = "buttonUpdatePassword";
            this.buttonUpdatePassword.Size = new System.Drawing.Size(164, 24);
            this.buttonUpdatePassword.TabIndex = 14;
            this.buttonUpdatePassword.Text = "Обновить пароль";
            this.buttonUpdatePassword.UseVisualStyleBackColor = true;
            this.buttonUpdatePassword.Click += new System.EventHandler(this.buttonUpdatePassword_Click);
            // 
            // textBoxNewPasswordAgain
            // 
            this.textBoxNewPasswordAgain.Location = new System.Drawing.Point(391, 54);
            this.textBoxNewPasswordAgain.Name = "textBoxNewPasswordAgain";
            this.textBoxNewPasswordAgain.PasswordChar = '*';
            this.textBoxNewPasswordAgain.Size = new System.Drawing.Size(164, 22);
            this.textBoxNewPasswordAgain.TabIndex = 15;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(791, 693);
            this.Controls.Add(this.textBoxNewPasswordAgain);
            this.Controls.Add(this.buttonUpdatePassword);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAddTransaction);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.radioButtonIncom);
            this.Controls.Add(this.radioButtonPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTimePickerTransaction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxValue);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Мои транзакции";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxValue;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerTransaction;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButtonPay;
        private System.Windows.Forms.RadioButton radioButtonIncom;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonAddTransaction;
        private System.Windows.Forms.Label label4;
        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource transactionsTableBindingSource;
        private DataSet1TableAdapters.TransactionsTableTableAdapter transactionsTableTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn transactionValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn transTypeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn counterIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.Button buttonUpdatePassword;
        private System.Windows.Forms.TextBox textBoxNewPasswordAgain;
    }
}