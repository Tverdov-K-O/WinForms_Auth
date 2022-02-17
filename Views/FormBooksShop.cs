using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_Auth.Data;
using WinForms_Auth.Data.Entities;

namespace WinForms_Auth.Views
{
    public partial class FormBooksShop : Form
    {
        //private AppDbContext _db = new AppDbContext();
        Book selectedBook = null;
        #region Форма
        public FormBooksShop()
        {
            InitializeComponent();
            RefrashBooks();

        }
        //
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
            listBoxProducts.SelectedItem = Program._db.Books.OrderBy(s => s.Name).First() as Book;
            listBoxProducts_SelectedIndexChanged(null, null);
        }
        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAdmin = new FormAdmin();
            frmAdmin.ShowDialog();
        }
        private void profileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var f = new FormProfile(Program.Auth.currentUser);
            f.ShowDialog();
        }
        private void моиФаворитыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Program.Auth.currentUser.Books != null)
            {
                listBoxProducts.Items.Clear();
                listBoxProducts.Items.AddRange(Program.Auth.currentUser.Books.OrderBy(s => s.Name).ToArray());
                labelAllProducts.Text = "Мои фавориты";
            }
        }
        private void добавитьВФаворитыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            selectedBook = listBoxProducts.SelectedItem as Book;
            if (selectedBook != null)
            {
                Program.Auth.currentUser.Books.Add(selectedBook);
                Program._db.SaveChanges();
                MessageBox.Show($"Книга: {selectedBook.Name} добавлена в Фавориты!");
            }
            else
            {
                MessageBox.Show($"Выберите книгу!");
            }
        }
        private void всеКнигиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RefrashBooks();
            labelAllProducts.Text = "Все книги";
        }
        private void списокНовинокToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelAllProducts.Text = "Новинки";
            listBoxProducts.Items.Clear();
            listBoxProducts.Items.AddRange(Program._db.Books.Where(b => b.CreatedAt.Date == DateTime.Now.Date).OrderBy(s => s.Name).ToArray());
        }
        private void списокПопАвторовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelAllProducts.Text = "Книги поп. Авторов";
            listBoxProducts.Items.Clear();
            //var a = Program._db.Books
        }
        private void списокПопЖанровToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelAllProducts.Text = "Книги поп. Жанров";
            listBoxProducts.Items.Clear();
        }
        #endregion

        #region Книги
        private void RefrashBooks()
        {
            listBoxProducts.Items.Clear();
            listBoxProducts.Items.AddRange(Program._db.Books.OrderBy(s => s.Name).ToArray());
            selectedBook = null;
        }
        private void RefrashBookGenres()
        {
            if(selectedBook != null)
            {
                listBoxGenres.Items.Clear();
                listBoxGenres.Items.AddRange(selectedBook.Genres.ToArray());
            }
        }
        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBook = listBoxProducts.SelectedItem as Book;
            labelNameBook.Text = selectedBook.ToString();
            labelTomNumber.Text = selectedBook.TomNumber.ToString();
            labelCountPage2.Text = selectedBook.CountPage.ToString();
            labelFullNameAuthor.Text = selectedBook.NameAuthor;
            labelTruePrice.Text = selectedBook.Price.ToString();
            labelNamePublisher.Text = selectedBook.NamePublisher;
            labelDateCreateFromClass.Text = selectedBook.DateRelease.ToShortDateString();
            if(selectedBook.Discounts != null)
            {
                var temp = selectedBook.Discounts.Where(s => s.Start.Date <= DateTime.Now.Date && s.Finish.Date >= DateTime.Now.Date);
                if (temp.Count() != 0)
                    labelTrueDiscount.Text = temp.First().ToString();
                else
                    labelTrueDiscount.Text = "Скидка 0 %";
            }
            if (selectedBook.Avatar == null)
                pictureBoxBook.Image = null;
            else
            {
                MemoryStream ms = new MemoryStream(selectedBook.Avatar);
                Image image = Image.FromStream(ms);
                pictureBoxBook.Image = image;
            }
            RefrashBookGenres();

        }
        #endregion
       
    }
}
//SELECT COUNT(Products.Id), Category.Name FROM Users
//	JOIN ProductUser ON ProductUser.FansId = Users.Id
//	JOIN Products ON ProductUser.FavoritesId = Products.Id
//	JOIN Category ON Products.CategoryId = Category.Id
//GROUP BY Category.Name
