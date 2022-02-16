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
using WinForms_Auth.Data.Entities;

namespace WinForms_Auth.Views
{
    public partial class FormAdmin : Form
    {
        Book Book = null;
        Genre selectedGenre = null;
        Book selectedBook = null;
        public FormAdmin()
        {
            InitializeComponent();
            RefrashGenres();
            RefrashBooks();
            radioBtnAdd.Checked = true;
        }
        #region Жанры
        private void btnAddGenre_Click(object sender, EventArgs e)
        {
            if (selectedGenre == null)
                Program._db.Add(new Genre { Name = textBoxGenre.Text });
            else
                selectedGenre.Name = textBoxGenre.Text;
            Program._db.SaveChanges();
            RefrashGenres();
        }
        private void btnDelGenre_Click(object sender, EventArgs e)
        {
            if (listBoxGenres.SelectedItem == null)
            {
                MessageBox.Show("нет выделенного жанра");
                return;
            }
            try
            {
                Program._db.Remove(listBoxGenres.SelectedItem as Genre);
                Program._db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            RefrashGenres();
        }
        private void RefrashGenres()
        {
            listBoxGenres.Items.Clear();
            listBoxGenres.Items.AddRange(Program._db.Genres.OrderBy(s => s.Name).ToArray());
            textBoxGenre.Text = "";
            selectedGenre = null;
        }
        private void listBoxGenres_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedGenre = listBoxGenres.SelectedItem as Genre;
            if(selectedGenre != null)
                textBoxGenre.Text = selectedGenre.Name;
        }
        private void listBoxGenres_DoubleClick(object sender, EventArgs e)
        {
            textBoxGenre.Text = "";
            listBoxGenres.SelectedItem = null;
            selectedGenre = null;
        }
        #endregion

        #region Книги
        private void RefrashBooks()
        {
            listBoxBooks.Items.Clear();
            listBoxBooks.Items.AddRange(Program._db.Books.OrderBy(s => s.Name).ToArray());
            selectedBook = null;
        }
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            if (radioBtnAdd.Checked == true)
            {
                Book = new Book
                {
                    Id = Guid.NewGuid(),
                    Name = textBoxBookName.Text,
                    NameAuthor = textBoxNameAuthor.Text,
                    NamePublisher = textBoxNamePublisher.Text,
                    Price = Convert.ToDouble(textBoxPrice.Text),
                    CountPage = Convert.ToInt32(textBoxCountPage.Text),
                    TomNumber = Convert.ToInt32(numericUpDownTomNumber.Value),
                    CreatedAt = dateTimePickerCreateAt.Value
                };
                SaveAvatar(Book);
                Program._db.Books.Add(Book);

            }
            else if (radioBtnEdit.Checked == true)
            {
                selectedBook.Name = textBoxBookName.Text;
                selectedBook.NameAuthor = textBoxNameAuthor.Text;
                selectedBook.NamePublisher = textBoxNamePublisher.Text;
                selectedBook.Price = Convert.ToDouble(textBoxPrice.Text);
                selectedBook.CountPage = Convert.ToInt32(textBoxCountPage.Text);
                selectedBook.TomNumber = Convert.ToInt32(numericUpDownTomNumber.Value);
                selectedBook.CreatedAt = dateTimePickerCreateAt.Value;
                SaveAvatar(selectedBook);
            }
            Program._db.SaveChanges();
            RefrashBooks();
        }
        private void btnDelBook_Click(object sender, EventArgs e)
        {
            if(selectedBook != null)
            {
                Program._db.Books.Remove(selectedBook);
                Program._db.SaveChanges();
                RefrashBooks();
            }
        }
        private void listBoxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            radioBtnAdd.Checked = false;
            selectedBook = listBoxBooks.SelectedItem as Book;
            if (selectedBook != null)
            {
                textBoxSelectedBook.Text = selectedBook.Name;
                textBoxBookName.Text = selectedBook.Name;
                textBoxNameAuthor.Text = selectedBook.NameAuthor;
                textBoxNamePublisher.Text = selectedBook.NamePublisher;
                textBoxCountPage.Text = selectedBook.CountPage.ToString();
                textBoxPrice.Text = selectedBook.Price.ToString();
                numericUpDownTomNumber.Value = selectedBook.TomNumber;
                if (selectedBook.Avatar == null)
                    pictureBoxBookAvatar.Image = null;
                else
                {
                    MemoryStream ms = new MemoryStream(selectedBook.Avatar);
                    Image image = Image.FromStream(ms);
                    pictureBoxBookAvatar.Image = image;
                }
                radioBtnEdit.Checked = true;
            }
            RefrashBookGenres();
        }
        private void listBoxBooks_DoubleClick(object sender, EventArgs e)
        {
            textBoxSelectedBook.Text = "";
            listBoxBooks.SelectedItem = null;
            listBoxBookGenres.Items.Clear();
            selectedBook = null;
        }
        private void btnAddAvatar_Click(object sender, EventArgs e)
        {
            var f = new OpenFileDialog();
            if (f.ShowDialog() == DialogResult.OK)
            {
                pictureBoxBookAvatar.Image = FormProfile.ScaleImage(Image.FromFile(f.FileName), 200, 200);
            }
        }
        private void SaveAvatar(Book b)
        {
            MemoryStream ms = new MemoryStream();
            pictureBoxBookAvatar.Image.Save(ms, ImageFormat.Jpeg);
            b.Avatar = new byte[ms.Length];
            b.Avatar = ms.GetBuffer();
        }
        private void radioBtnEdit_CheckedChanged(object sender, EventArgs e)
        {
            if (selectedBook == null)
            {
                MessageBox.Show("Выберите Книгу");
                radioBtnEdit.Checked = false;
                return;
            }
        }
        private void radioBtnAdd_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSelectedBook.Text = "";
            textBoxGenre.Text = "";
            textBoxBookName.Text = "";
            textBoxNameAuthor.Text = "";
            textBoxNamePublisher.Text = "";
            textBoxPrice.Text = "";
            textBoxCountPage.Text = "";
            numericUpDownTomNumber.Value = 0;
            pictureBoxBookAvatar.Image = null;
            selectedBook = null;
            selectedGenre = null;
        }
        #endregion

        #region Книги-Жанры
        private void btnAddBookGenre_Click(object sender, EventArgs e)
        {
            if (selectedBook == null)
            {
                MessageBox.Show("Выберите Книгу");
                return;
            }
            else if (selectedGenre == null)
            {
                MessageBox.Show("Выберите Жанр");
                return;
            }
            selectedBook.Genres.Add(selectedGenre);
            Program._db.SaveChanges();
            RefrashBookGenres();
        }
        private void RefrashBookGenres()
        {
            if (selectedBook != null)
            {
                listBoxBookGenres.Items.Clear();
                listBoxBookGenres.Items.AddRange(selectedBook.Genres.OrderBy(s => s.Name).ToArray());
            }
        }
        private void btnDelBookGenre_Click(object sender, EventArgs e)
        {
            if(listBoxBookGenres != null && selectedBook != null)
            {
                Program._db.Books
                    .Where(s=> s.Id == selectedBook.Id)
                    .First()
                    .Genres.Remove(listBoxBookGenres.SelectedItem as Genre);
            }
            Program._db.SaveChanges();
            RefrashBookGenres();
        }


        #endregion


       
    }
}
