using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForms_Auth.Views
{
    public partial class FormProfile : Form
    {
       public Data.Entities.User User;
        public FormProfile(Data.Entities.User user)
        {
            this.User = user;
            InitializeComponent();
            if(User.Name != null)
            {
                textBoxName.Text = user.Name;
                textBoxRole.Text = user.Role.Name;
            }
            if (Program.Auth.isAdmin) 
                textBoxRole.Enabled = true;
            else 
                textBoxRole.Enabled = false;
            renderAvatar();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            // в случае сохранения пользователя - забираю данные 
            this.User.Name = textBoxName.Text;
            SaveAvatar();
            Program._db.SaveChanges();
            this.Close();
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            //в случае отмены ничего не делаю 
            this.Close();
        }
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }
        private void renderAvatar()
        {
            if (User.Avatar == null)
            {
                return;
            }
            MemoryStream ms = new MemoryStream(User.Avatar);
            Image image = Image.FromStream(ms);
            pictureBoxAvatar.Image = image;
        }
        private void SaveAvatar()
        {
            MemoryStream ms = new MemoryStream();
            pictureBoxAvatar.Image.Save(ms, ImageFormat.Jpeg);
            User.Avatar = new byte[ms.Length];
            User.Avatar = ms.GetBuffer();
        }
        public static Image ScaleImage(Image source, int width, int height)
            {

                Image dest = new Bitmap(width, height);
                using (Graphics gr = Graphics.FromImage(dest))
                {
                    gr.FillRectangle(Brushes.White, 0, 0, width, height);  // Очищаем экран
                    gr.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

                    float srcwidth = source.Width;
                    float srcheight = source.Height;
                    float dstwidth = width;
                    float dstheight = height;

                    if (srcwidth <= dstwidth && srcheight <= dstheight)  // Исходное изображение меньше целевого
                    {
                        int left = (width - source.Width) / 2;
                        int top = (height - source.Height) / 2;
                        gr.DrawImage(source, left, top, source.Width, source.Height);
                    }
                    else if (srcwidth / srcheight > dstwidth / dstheight)  // Пропорции исходного изображения более широкие
                    {
                        float cy = srcheight / srcwidth * dstwidth;
                        float top = ((float)dstheight - cy) / 2.0f;
                        if (top < 1.0f) top = 0;
                        gr.DrawImage(source, 0, top, dstwidth, cy);
                    }
                    else  // Пропорции исходного изображения более узкие
                    {
                        float cx = srcwidth / srcheight * dstheight;
                        float left = ((float)dstwidth - cx) / 2.0f;
                        if (left < 1.0f) left = 0;
                        gr.DrawImage(source, left, 0, cx, dstheight);
                    }

                    return dest;
                }
            }
        private void btnChangeAvatar_Click(object sender, EventArgs e)
        {
            var f = new OpenFileDialog();
            if(f.ShowDialog() == DialogResult.OK)
            {
                
                pictureBoxAvatar.Image = ScaleImage(Image.FromFile(f.FileName), 200, 200);
           
            }
        }
    }
}
