namespace MoneyTracker
{
    partial class FormLogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите пароль";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(80, 157);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(279, 22);
            this.textBoxPassword.TabIndex = 1;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(237, 197);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(122, 42);
            this.buttonLogin.TabIndex = 2;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MoneyTracker.Properties.Resources._lock;
            this.pictureBox1.Location = new System.Drawing.Point(174, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 89);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(447, 265);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Login to money tracker";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

