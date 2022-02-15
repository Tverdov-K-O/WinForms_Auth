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
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
            
        }

        private void FormAuth_Load(object sender, EventArgs e)
        {
            Helpers.Auth a = new Helpers.Auth();
            if (!a.Login())
            {
                MessageBox.Show("Доступ запрещен!");
                this.Close();
            }
            if (Program.Auth.isAdmin)
                adminToolStripMenuItem.Enabled = true;
            else
            {
                adminToolStripMenuItem.Visible = false;
                adminToolStripMenuItem.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.Auth.isAdmin) MessageBox.Show("Admin");
        }

        private void myProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FormProfile(Program.Auth.currentUser);
            f.ShowDialog();
        }
    }
}
