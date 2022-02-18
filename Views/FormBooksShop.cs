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
        Book selectedBook = null;

        bool searchByName = true;
        bool searchByAuthor = false;
        bool searchByGenre = false;

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
                this.Close();
            }
            else if (Program.Auth.isAdmin)
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
            if(listBoxProducts.Items.Count == 0)
            {
                MessageBox.Show("Сегодня новинок нет :(");
            }
        }
        private void поискПоНазваниюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchByName = true;
            searchByGenre = false;
            searchByAuthor = false;
            labelSearch2.Text = "Названию";
        }
        private void поискПоАвторуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchByAuthor = true;
            searchByGenre = false;
            searchByName = false;
            labelSearch2.Text = "Автору";
            searchByAuthorsOrGenres();
        }
        private void поискПоЖарнуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchByGenre = true;
            searchByName = false;
            searchByAuthor = false;
            labelSearch2.Text = "Жанру";
            searchByAuthorsOrGenres();
        }
        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            if (searchByName == true)
            {
                listBoxBookSearch.Items.Clear();
                listBoxBookSearch.Items.AddRange(Program._db.Books.Where(b => b.Name.Contains(textBoxSearch.Text)).ToArray());
            }
            if (searchByAuthor)
            {
                listBoxBookSearch.Items.Clear();
                listBoxBookSearch.Items.AddRange(Program._db.Books.Where(b => b.NameAuthor.Contains(textBoxSearch.Text)).ToArray());
            }
            if (searchByGenre)
            {
                listBoxBookSearch.Items.Clear();
                var SearchGenre = Program._db.Genres.Where(g => g.Name.Contains(textBoxSearch.Text)).FirstOrDefault(); 
                listBoxBookSearch.Items.AddRange(Program._db.Books.Where(b=>b.Genres.Contains(SearchGenre)).ToArray());
            }
        }
        private void labelSearch_MouseEnter(object sender, EventArgs e)
        {
            labelSearch.ContextMenuStrip.Show(new Point(MousePosition.X, MousePosition.Y));
        }
        private void FormBooksShop_MouseEnter(object sender, EventArgs e)
        {
            labelSelectSearch.Visible = true;
        }
        private void FormBooksShop_MouseLeave(object sender, EventArgs e)
        {
            labelSelectSearch.Visible = false;
        }
        private void listBoxBookSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBook = listBoxBookSearch.SelectedItem as Book;
            RefrashSelectBook();
        }
        private void searchByAuthorsOrGenres()
        {
            contextMenuStripSearchByAuthorGenres.Items.Clear();
            if (searchByGenre)
            {
                foreach (var item in Program._db.Genres)
                    contextMenuStripSearchByAuthorGenres.Items.Add(new ToolStripMenuItem { Name = item.Name, Text = item.Name });

                contextMenuStripSearchByAuthorGenres.Show(MousePosition.X, MousePosition.Y);

                foreach (var item in contextMenuStripSearchByAuthorGenres.Items)
                {
                    var temp = (item as ToolStripMenuItem);
                    temp.Click += Temp_Click;
                }
            }
            else if (searchByAuthor)
            {
                foreach (var item in Program._db.Books)
                    contextMenuStripSearchByAuthorGenres.Items.Add(new ToolStripMenuItem { Name = item.NameAuthor, Text = item.NameAuthor });

                contextMenuStripSearchByAuthorGenres.Show(MousePosition.X, MousePosition.Y);

                foreach (var item in contextMenuStripSearchByAuthorGenres.Items)
                {
                    var temp = (item as ToolStripMenuItem);
                    temp.Click += Temp_Click;
                }
            }
        }
        private void Temp_Click(object sender, EventArgs e)
        {
            var temp = sender as ToolStripMenuItem;
            textBoxSearch.Text = temp.Name;
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
        private void RefrashSelectBook()
        {
            if (selectedBook != null)
            {
                labelNameBook.Text = selectedBook.ToString();
                labelTomNumber.Text = selectedBook.TomNumber.ToString();
                labelCountPage2.Text = selectedBook.CountPage.ToString();
                labelFullNameAuthor.Text = selectedBook.NameAuthor;
                labelTruePrice.Text = selectedBook.Price.ToString();
                labelNamePublisher.Text = selectedBook.NamePublisher;
                labelDateCreateFromClass.Text = selectedBook.DateRelease.ToShortDateString();
                if (selectedBook.Discounts != null)
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
        }
        private void listBoxProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedBook = listBoxProducts.SelectedItem as Book;
            RefrashSelectBook();
        }
        #endregion

   
    }
}
