
namespace WinForms_Auth.Views
{
    partial class FormRegister
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelRegistration = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPassword2 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxPasswordConfurm = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Info;
            this.textBox1.Location = new System.Drawing.Point(107, 96);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(165, 23);
            this.textBox1.TabIndex = 0;
            // 
            // labelRegistration
            // 
            this.labelRegistration.AutoSize = true;
            this.labelRegistration.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelRegistration.Location = new System.Drawing.Point(107, 32);
            this.labelRegistration.Name = "labelRegistration";
            this.labelRegistration.Size = new System.Drawing.Size(122, 25);
            this.labelRegistration.TabIndex = 1;
            this.labelRegistration.Text = "Регистрация";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelName.Location = new System.Drawing.Point(36, 99);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(42, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Имя:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(36, 128);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(54, 20);
            this.labelEmail.TabIndex = 3;
            this.labelEmail.Text = "Почта:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(36, 168);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(65, 20);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Пароль:";
            // 
            // labelPassword2
            // 
            this.labelPassword2.AutoSize = true;
            this.labelPassword2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPassword2.Location = new System.Drawing.Point(36, 197);
            this.labelPassword2.Name = "labelPassword2";
            this.labelPassword2.Size = new System.Drawing.Size(65, 20);
            this.labelPassword2.TabIndex = 5;
            this.labelPassword2.Text = "Пароль:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxEmail.Location = new System.Drawing.Point(107, 125);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(165, 23);
            this.textBoxEmail.TabIndex = 6;
            this.textBoxEmail.Leave += new System.EventHandler(this.textBoxEmail_Leave);
            // 
            // textBoxPasswordConfurm
            // 
            this.textBoxPasswordConfurm.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxPasswordConfurm.Location = new System.Drawing.Point(107, 198);
            this.textBoxPasswordConfurm.Name = "textBoxPasswordConfurm";
            this.textBoxPasswordConfurm.Size = new System.Drawing.Size(165, 23);
            this.textBoxPasswordConfurm.TabIndex = 7;
            this.textBoxPasswordConfurm.Leave += new System.EventHandler(this.textBoxPasswordConfurm_Leave);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxPassword.Location = new System.Drawing.Point(107, 168);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(165, 23);
            this.textBoxPassword.TabIndex = 8;
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.Salmon;
            this.btnRegistration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistration.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistration.Location = new System.Drawing.Point(21, 258);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(167, 42);
            this.btnRegistration.TabIndex = 9;
            this.btnRegistration.Text = "Зарегистрироваться";
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.Location = new System.Drawing.Point(207, 257);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(110, 43);
            this.btnLogin.TabIndex = 10;
            this.btnLogin.Text = "Войти";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(336, 317);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.btnRegistration);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxPasswordConfurm);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.labelPassword2);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelRegistration);
            this.Controls.Add(this.textBox1);
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelRegistration;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPassword2;
        private System.Windows.Forms.Button btnRegistration;
        private System.Windows.Forms.Button btnLogin;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox textBoxEmail;
        public System.Windows.Forms.TextBox textBoxPasswordConfurm;
        public System.Windows.Forms.TextBox textBoxPassword;
    }
}