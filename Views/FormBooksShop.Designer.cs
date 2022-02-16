
namespace WinForms_Auth.Views
{
    partial class FormBooksShop
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.profileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.моиФаворитыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокНовинокToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПопАвторовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокПопЖанровToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.panelBook = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTrueDiscount = new System.Windows.Forms.Label();
            this.labelDiscount = new System.Windows.Forms.Label();
            this.labelTruePrice = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelCountPage2 = new System.Windows.Forms.Label();
            this.labelCountPage = new System.Windows.Forms.Label();
            this.labelTomNumber = new System.Windows.Forms.Label();
            this.labelTom = new System.Windows.Forms.Label();
            this.labelDateCreateFromClass = new System.Windows.Forms.Label();
            this.labelDateCreateBook = new System.Windows.Forms.Label();
            this.labelNamePublisher = new System.Windows.Forms.Label();
            this.labelGenres = new System.Windows.Forms.Label();
            this.listBoxGenres = new System.Windows.Forms.ListBox();
            this.labelPublisherName = new System.Windows.Forms.Label();
            this.labelFullNameAuthor = new System.Windows.Forms.Label();
            this.labelNameAuthor = new System.Windows.Forms.Label();
            this.labelNameBook = new System.Windows.Forms.Label();
            this.pictureBoxBook = new System.Windows.Forms.PictureBox();
            this.labelAllProducts = new System.Windows.Forms.Label();
            this.Lable = new System.Windows.Forms.Label();
            this.listBoxBookSearch = new System.Windows.Forms.ListBox();
            this.listBoxProducts = new System.Windows.Forms.ListBox();
            this.contextMenuStripBooks = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.добавитьВФаворитыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelSearch = new System.Windows.Forms.Label();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.всеКнигиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.panelBook.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).BeginInit();
            this.contextMenuStripBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profileToolStripMenuItem1,
            this.всеКнигиToolStripMenuItem,
            this.моиФаворитыToolStripMenuItem,
            this.списокНовинокToolStripMenuItem,
            this.списокПопАвторовToolStripMenuItem,
            this.списокПопЖанровToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // profileToolStripMenuItem1
            // 
            this.profileToolStripMenuItem1.Name = "profileToolStripMenuItem1";
            this.profileToolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.profileToolStripMenuItem1.Text = "Профиль";
            this.profileToolStripMenuItem1.Click += new System.EventHandler(this.profileToolStripMenuItem1_Click);
            // 
            // моиФаворитыToolStripMenuItem
            // 
            this.моиФаворитыToolStripMenuItem.Name = "моиФаворитыToolStripMenuItem";
            this.моиФаворитыToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.моиФаворитыToolStripMenuItem.Text = "Мои Фавориты";
            this.моиФаворитыToolStripMenuItem.Click += new System.EventHandler(this.моиФаворитыToolStripMenuItem_Click);
            // 
            // списокНовинокToolStripMenuItem
            // 
            this.списокНовинокToolStripMenuItem.Name = "списокНовинокToolStripMenuItem";
            this.списокНовинокToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.списокНовинокToolStripMenuItem.Text = "Список Новинок";
            // 
            // списокПопАвторовToolStripMenuItem
            // 
            this.списокПопАвторовToolStripMenuItem.Name = "списокПопАвторовToolStripMenuItem";
            this.списокПопАвторовToolStripMenuItem.Size = new System.Drawing.Size(136, 20);
            this.списокПопАвторовToolStripMenuItem.Text = "Список поп. Авторов";
            // 
            // списокПопЖанровToolStripMenuItem
            // 
            this.списокПопЖанровToolStripMenuItem.Name = "списокПопЖанровToolStripMenuItem";
            this.списокПопЖанровToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.списокПопЖанровToolStripMenuItem.Text = "Список поп. Жанров";
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "Admin";
            this.adminToolStripMenuItem.Click += new System.EventHandler(this.adminToolStripMenuItem_Click);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(800, 2);
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(800, 26);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip);
            // 
            // panelBook
            // 
            this.panelBook.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelBook.Controls.Add(this.panel2);
            this.panelBook.Controls.Add(this.labelCountPage2);
            this.panelBook.Controls.Add(this.labelCountPage);
            this.panelBook.Controls.Add(this.labelTomNumber);
            this.panelBook.Controls.Add(this.labelTom);
            this.panelBook.Controls.Add(this.labelDateCreateFromClass);
            this.panelBook.Controls.Add(this.labelDateCreateBook);
            this.panelBook.Controls.Add(this.labelNamePublisher);
            this.panelBook.Controls.Add(this.labelGenres);
            this.panelBook.Controls.Add(this.listBoxGenres);
            this.panelBook.Controls.Add(this.labelPublisherName);
            this.panelBook.Controls.Add(this.labelFullNameAuthor);
            this.panelBook.Controls.Add(this.labelNameAuthor);
            this.panelBook.Controls.Add(this.labelNameBook);
            this.panelBook.Controls.Add(this.pictureBoxBook);
            this.panelBook.Location = new System.Drawing.Point(227, 57);
            this.panelBook.Name = "panelBook";
            this.panelBook.Size = new System.Drawing.Size(348, 304);
            this.panelBook.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.PaleGreen;
            this.panel2.Controls.Add(this.labelTrueDiscount);
            this.panel2.Controls.Add(this.labelDiscount);
            this.panel2.Controls.Add(this.labelTruePrice);
            this.panel2.Controls.Add(this.labelPrice);
            this.panel2.Location = new System.Drawing.Point(8, 150);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(172, 82);
            this.panel2.TabIndex = 14;
            // 
            // labelTrueDiscount
            // 
            this.labelTrueDiscount.AutoSize = true;
            this.labelTrueDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTrueDiscount.Location = new System.Drawing.Point(78, 48);
            this.labelTrueDiscount.Name = "labelTrueDiscount";
            this.labelTrueDiscount.Size = new System.Drawing.Size(19, 21);
            this.labelTrueDiscount.TabIndex = 3;
            this.labelTrueDiscount.Text = "0";
            // 
            // labelDiscount
            // 
            this.labelDiscount.AutoSize = true;
            this.labelDiscount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDiscount.Location = new System.Drawing.Point(5, 48);
            this.labelDiscount.Name = "labelDiscount";
            this.labelDiscount.Size = new System.Drawing.Size(65, 21);
            this.labelDiscount.TabIndex = 2;
            this.labelDiscount.Text = "Скидка:";
            // 
            // labelTruePrice
            // 
            this.labelTruePrice.AutoSize = true;
            this.labelTruePrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTruePrice.Location = new System.Drawing.Point(78, 16);
            this.labelTruePrice.Name = "labelTruePrice";
            this.labelTruePrice.Size = new System.Drawing.Size(19, 21);
            this.labelTruePrice.TabIndex = 1;
            this.labelTruePrice.Text = "0";
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(20, 16);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(50, 21);
            this.labelPrice.TabIndex = 0;
            this.labelPrice.Text = "Цена:";
            // 
            // labelCountPage2
            // 
            this.labelCountPage2.AutoSize = true;
            this.labelCountPage2.Location = new System.Drawing.Point(71, 69);
            this.labelCountPage2.Name = "labelCountPage2";
            this.labelCountPage2.Size = new System.Drawing.Size(13, 15);
            this.labelCountPage2.TabIndex = 13;
            this.labelCountPage2.Text = "0";
            // 
            // labelCountPage
            // 
            this.labelCountPage.AutoSize = true;
            this.labelCountPage.Location = new System.Drawing.Point(8, 69);
            this.labelCountPage.Name = "labelCountPage";
            this.labelCountPage.Size = new System.Drawing.Size(57, 15);
            this.labelCountPage.TabIndex = 12;
            this.labelCountPage.Text = "Кол. Стр:";
            // 
            // labelTomNumber
            // 
            this.labelTomNumber.AutoSize = true;
            this.labelTomNumber.Location = new System.Drawing.Point(71, 45);
            this.labelTomNumber.Name = "labelTomNumber";
            this.labelTomNumber.Size = new System.Drawing.Size(13, 15);
            this.labelTomNumber.TabIndex = 11;
            this.labelTomNumber.Text = "0";
            // 
            // labelTom
            // 
            this.labelTom.AutoSize = true;
            this.labelTom.Location = new System.Drawing.Point(32, 45);
            this.labelTom.Name = "labelTom";
            this.labelTom.Size = new System.Drawing.Size(32, 15);
            this.labelTom.TabIndex = 10;
            this.labelTom.Text = "Том:";
            // 
            // labelDateCreateFromClass
            // 
            this.labelDateCreateFromClass.AutoSize = true;
            this.labelDateCreateFromClass.Location = new System.Drawing.Point(106, 271);
            this.labelDateCreateFromClass.Name = "labelDateCreateFromClass";
            this.labelDateCreateFromClass.Size = new System.Drawing.Size(31, 15);
            this.labelDateCreateFromClass.TabIndex = 9;
            this.labelDateCreateFromClass.Text = "0.0.0";
            // 
            // labelDateCreateBook
            // 
            this.labelDateCreateBook.AutoSize = true;
            this.labelDateCreateBook.Location = new System.Drawing.Point(12, 271);
            this.labelDateCreateBook.Name = "labelDateCreateBook";
            this.labelDateCreateBook.Size = new System.Drawing.Size(88, 15);
            this.labelDateCreateBook.TabIndex = 8;
            this.labelDateCreateBook.Text = "Дата создания:";
            // 
            // labelNamePublisher
            // 
            this.labelNamePublisher.AutoSize = true;
            this.labelNamePublisher.Location = new System.Drawing.Point(103, 245);
            this.labelNamePublisher.Name = "labelNamePublisher";
            this.labelNamePublisher.Size = new System.Drawing.Size(88, 15);
            this.labelNamePublisher.TabIndex = 7;
            this.labelNamePublisher.Text = "NamePublisher";
            // 
            // labelGenres
            // 
            this.labelGenres.AutoSize = true;
            this.labelGenres.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGenres.Location = new System.Drawing.Point(248, 157);
            this.labelGenres.Name = "labelGenres";
            this.labelGenres.Size = new System.Drawing.Size(41, 17);
            this.labelGenres.TabIndex = 6;
            this.labelGenres.Text = "Жанр";
            // 
            // listBoxGenres
            // 
            this.listBoxGenres.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.listBoxGenres.FormattingEnabled = true;
            this.listBoxGenres.ItemHeight = 15;
            this.listBoxGenres.Location = new System.Drawing.Point(198, 177);
            this.listBoxGenres.Name = "listBoxGenres";
            this.listBoxGenres.Size = new System.Drawing.Size(147, 109);
            this.listBoxGenres.TabIndex = 5;
            // 
            // labelPublisherName
            // 
            this.labelPublisherName.AutoSize = true;
            this.labelPublisherName.Location = new System.Drawing.Point(13, 245);
            this.labelPublisherName.Name = "labelPublisherName";
            this.labelPublisherName.Size = new System.Drawing.Size(84, 15);
            this.labelPublisherName.TabIndex = 4;
            this.labelPublisherName.Text = "Издательство:";
            // 
            // labelFullNameAuthor
            // 
            this.labelFullNameAuthor.AutoSize = true;
            this.labelFullNameAuthor.Location = new System.Drawing.Point(71, 91);
            this.labelFullNameAuthor.Name = "labelFullNameAuthor";
            this.labelFullNameAuthor.Size = new System.Drawing.Size(34, 15);
            this.labelFullNameAuthor.TabIndex = 3;
            this.labelFullNameAuthor.Text = "ФИО";
            // 
            // labelNameAuthor
            // 
            this.labelNameAuthor.AutoSize = true;
            this.labelNameAuthor.Location = new System.Drawing.Point(22, 91);
            this.labelNameAuthor.Name = "labelNameAuthor";
            this.labelNameAuthor.Size = new System.Drawing.Size(43, 15);
            this.labelNameAuthor.TabIndex = 2;
            this.labelNameAuthor.Text = "Автор:";
            // 
            // labelNameBook
            // 
            this.labelNameBook.AutoSize = true;
            this.labelNameBook.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNameBook.Location = new System.Drawing.Point(13, 14);
            this.labelNameBook.Name = "labelNameBook";
            this.labelNameBook.Size = new System.Drawing.Size(73, 17);
            this.labelNameBook.TabIndex = 1;
            this.labelNameBook.Text = "Namebook";
            // 
            // pictureBoxBook
            // 
            this.pictureBoxBook.BackColor = System.Drawing.Color.BurlyWood;
            this.pictureBoxBook.Location = new System.Drawing.Point(198, 0);
            this.pictureBoxBook.Name = "pictureBoxBook";
            this.pictureBoxBook.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxBook.TabIndex = 0;
            this.pictureBoxBook.TabStop = false;
            // 
            // labelAllProducts
            // 
            this.labelAllProducts.AutoSize = true;
            this.labelAllProducts.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelAllProducts.Location = new System.Drawing.Point(12, 34);
            this.labelAllProducts.Name = "labelAllProducts";
            this.labelAllProducts.Size = new System.Drawing.Size(78, 20);
            this.labelAllProducts.TabIndex = 4;
            this.labelAllProducts.Text = "Все книги";
            // 
            // Lable
            // 
            this.Lable.AutoSize = true;
            this.Lable.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Lable.Location = new System.Drawing.Point(369, 34);
            this.Lable.Name = "Lable";
            this.Lable.Size = new System.Drawing.Size(50, 20);
            this.Lable.TabIndex = 5;
            this.Lable.Text = "Книга";
            // 
            // listBoxBookSearch
            // 
            this.listBoxBookSearch.BackColor = System.Drawing.Color.PeachPuff;
            this.listBoxBookSearch.FormattingEnabled = true;
            this.listBoxBookSearch.ItemHeight = 15;
            this.listBoxBookSearch.Location = new System.Drawing.Point(588, 57);
            this.listBoxBookSearch.Name = "listBoxBookSearch";
            this.listBoxBookSearch.Size = new System.Drawing.Size(200, 304);
            this.listBoxBookSearch.TabIndex = 6;
            // 
            // listBoxProducts
            // 
            this.listBoxProducts.BackColor = System.Drawing.Color.AntiqueWhite;
            this.listBoxProducts.ContextMenuStrip = this.contextMenuStripBooks;
            this.listBoxProducts.FormattingEnabled = true;
            this.listBoxProducts.ItemHeight = 15;
            this.listBoxProducts.Location = new System.Drawing.Point(12, 57);
            this.listBoxProducts.Name = "listBoxProducts";
            this.listBoxProducts.Size = new System.Drawing.Size(200, 304);
            this.listBoxProducts.TabIndex = 0;
            this.listBoxProducts.SelectedIndexChanged += new System.EventHandler(this.listBoxProducts_SelectedIndexChanged);
            // 
            // contextMenuStripBooks
            // 
            this.contextMenuStripBooks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьВФаворитыToolStripMenuItem});
            this.contextMenuStripBooks.Name = "contextMenuStripBooks";
            this.contextMenuStripBooks.Size = new System.Drawing.Size(195, 26);
            // 
            // добавитьВФаворитыToolStripMenuItem
            // 
            this.добавитьВФаворитыToolStripMenuItem.Name = "добавитьВФаворитыToolStripMenuItem";
            this.добавитьВФаворитыToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.добавитьВФаворитыToolStripMenuItem.Text = "Добавить в Фавориты";
            this.добавитьВФаворитыToolStripMenuItem.Click += new System.EventHandler(this.добавитьВФаворитыToolStripMenuItem_Click);
            // 
            // labelSearch
            // 
            this.labelSearch.AutoSize = true;
            this.labelSearch.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelSearch.Location = new System.Drawing.Point(588, 34);
            this.labelSearch.Name = "labelSearch";
            this.labelSearch.Size = new System.Drawing.Size(58, 20);
            this.labelSearch.TabIndex = 7;
            this.labelSearch.Text = "Поиск:";
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(652, 32);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(136, 23);
            this.textBoxSearch.TabIndex = 8;
            // 
            // всеКнигиToolStripMenuItem
            // 
            this.всеКнигиToolStripMenuItem.Name = "всеКнигиToolStripMenuItem";
            this.всеКнигиToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.всеКнигиToolStripMenuItem.Text = "Все книги";
            this.всеКнигиToolStripMenuItem.Click += new System.EventHandler(this.всеКнигиToolStripMenuItem_Click);
            // 
            // FormBooksShop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 372);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.labelSearch);
            this.Controls.Add(this.listBoxProducts);
            this.Controls.Add(this.listBoxBookSearch);
            this.Controls.Add(this.Lable);
            this.Controls.Add(this.labelAllProducts);
            this.Controls.Add(this.panelBook);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormBooksShop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBookshop";
            this.Load += new System.EventHandler(this.FormBookshop_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.panelBook.ResumeLayout(false);
            this.panelBook.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBook)).EndInit();
            this.contextMenuStripBooks.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem profileToolStripMenuItem1;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Panel panelBook;
        private System.Windows.Forms.PictureBox pictureBoxBook;
        private System.Windows.Forms.Label labelAllProducts;
        private System.Windows.Forms.Label labelNameAuthor;
        private System.Windows.Forms.Label labelNameBook;
        private System.Windows.Forms.Label labelFullNameAuthor;
        private System.Windows.Forms.Label labelDateCreateFromClass;
        private System.Windows.Forms.Label labelDateCreateBook;
        private System.Windows.Forms.Label labelNamePublisher;
        private System.Windows.Forms.Label labelGenres;
        private System.Windows.Forms.ListBox listBoxGenres;
        private System.Windows.Forms.Label labelPublisherName;
        private System.Windows.Forms.Label labelTomNumber;
        private System.Windows.Forms.Label labelTom;
        private System.Windows.Forms.ToolStripMenuItem списокНовинокToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПопАвторовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокПопЖанровToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelTrueDiscount;
        private System.Windows.Forms.Label labelDiscount;
        private System.Windows.Forms.Label labelTruePrice;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelCountPage2;
        private System.Windows.Forms.Label labelCountPage;
        private System.Windows.Forms.Label Lable;
        private System.Windows.Forms.ListBox listBoxBookSearch;
        private System.Windows.Forms.ListBox listBoxProducts;
        private System.Windows.Forms.Label labelSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моиФаворитыToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripBooks;
        private System.Windows.Forms.ToolStripMenuItem добавитьВФаворитыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem всеКнигиToolStripMenuItem;
    }
}