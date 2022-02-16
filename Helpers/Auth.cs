using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_Auth.Views;

namespace WinForms_Auth.Helpers
{
    class Auth
    {
        FormRegister frmRegister = new FormRegister();
        FormLogin frmLogin = new FormLogin();
        public bool Login()
        {
            do
            {
                switch(frmLogin.ShowDialog())
                {
                    case System.Windows.Forms.DialogResult.OK:
                        TryLogin();
                        break;
                    case System.Windows.Forms.DialogResult.Retry:
                        SingIn();
                        break;
                    case System.Windows.Forms.DialogResult.Cancel:
                        return false;

                }

            }
            while (!Program.Auth.isLogin);
            return true;
        }
        private void SingIn()
        {
            switch (frmRegister.ShowDialog())
            {
                case System.Windows.Forms.DialogResult.OK:
                    TryRegister();
                    break;
                case System.Windows.Forms.DialogResult.Retry:
                    SingIn();
                    break;
                case System.Windows.Forms.DialogResult.Cancel:
                    return;

            }
        }
        private void TryLogin()
        {
            Data.Entities.User u = Program._db.Users
                .Where(u => 
                u.Email == frmLogin.textBoxLogin.Text && 
                u.Password == frmLogin.textBoxPassword.Text)
                .FirstOrDefault();
            if(u == null)
            {
                MessageBox.Show("Ошибка в данных");
                return;
            }
            Program.Auth.currentUser = u;
            Program.Auth.isLogin = true; 
        }
        private void TryRegister()
        {
            try
            {
                Data.Entities.User newUser = new Data.Entities.User
                {
                    Id = Guid.NewGuid(),
                    Name = frmRegister.textBox1.Text,
                    Email = frmRegister.textBoxEmail.Text,
                    Password = frmRegister.textBoxPassword.Text
                };
                Program._db.Add(newUser);
                Program._db.SaveChanges();
                Program._db.Entry(newUser).Reference("Role");
                Program._db.Entry(newUser).Collection("Roles");
                Program.Auth.currentUser = newUser;
                Program.Auth.isLogin = true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

    }
}
