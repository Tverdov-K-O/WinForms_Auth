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
    public partial class FormBooksShop : Form
    {
        public FormBooksShop()
        {
            InitializeComponent();
        }

        private void FormBookshop_Load(object sender, EventArgs e)
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

        private void profileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = new FormProfile(Program.Auth.currentUser);
            f.ShowDialog();
        }
    }
}
