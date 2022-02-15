using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Auth.Views
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Retry;
            this.Close();
        }

        private void textBoxEmail_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("проверим мыло");
            var testUser = Program._db.Users.Where(
                u => u.Email == this.textBoxEmail.Text).Count();
            if(testUser > 0)
            {
                (sender as TextBox).BackColor = Color.Red;
                MessageBox.Show("пользователь с таким аресом зареган!");
            }
            else
            {
                (sender as TextBox).BackColor = Color.Green;
            }

        }

        private void textBoxPasswordConfurm_Leave(object sender, EventArgs e)
        {
            if(textBoxPassword.Text != textBoxPasswordConfurm.Text)
            {
                (sender as TextBox).BackColor = Color.Red;

            }
            else
            {
                (sender as TextBox).BackColor = Color.Green;
            }
        }
    }
}
