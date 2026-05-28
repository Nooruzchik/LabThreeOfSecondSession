namespace LabThreeOfSecondSession.View.Pannels
{
    partial class ListOfBooks
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox = new GroupBox();
            btnEdit = new Button();
            btnDelete = new Button();
            btnAdd = new Button();
            groupBox2 = new GroupBox();
            genre = new Label();
            pageCount = new Label();
            autor = new Label();
            yearOfMade = new Label();
            comboBoxGenre = new ComboBox();
            textBoxCntPage = new TextBox();
            nameOfBook = new Label();
            textBoxAutor = new TextBox();
            textBoxYearMade = new TextBox();
            textBoxName = new TextBox();
            listOfBook = new ListBox();
            groupBox.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox
            // 
            groupBox.Controls.Add(btnEdit);
            groupBox.Controls.Add(btnDelete);
            groupBox.Controls.Add(btnAdd);
            groupBox.Controls.Add(groupBox2);
            groupBox.Controls.Add(listOfBook);
            groupBox.Dock = DockStyle.Fill;
            groupBox.Location = new Point(0, 0);
            groupBox.Name = "groupBox";
            groupBox.Size = new Size(725, 573);
            groupBox.TabIndex = 0;
            groupBox.TabStop = false;
            groupBox.Text = "Список книг";
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(478, 347);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(75, 49);
            btnEdit.TabIndex = 5;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(371, 347);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 49);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "DEL";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(270, 347);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 49);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(genre);
            groupBox2.Controls.Add(pageCount);
            groupBox2.Controls.Add(autor);
            groupBox2.Controls.Add(yearOfMade);
            groupBox2.Controls.Add(comboBoxGenre);
            groupBox2.Controls.Add(textBoxCntPage);
            groupBox2.Controls.Add(nameOfBook);
            groupBox2.Controls.Add(textBoxAutor);
            groupBox2.Controls.Add(textBoxYearMade);
            groupBox2.Controls.Add(textBoxName);
            groupBox2.Location = new Point(270, 47);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(430, 275);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Подробная информация";
            // 
            // genre
            // 
            genre.AutoSize = true;
            genre.Location = new Point(22, 219);
            genre.Name = "genre";
            genre.Size = new Size(38, 15);
            genre.TabIndex = 8;
            genre.Text = "Жанр";
            // 
            // pageCount
            // 
            pageCount.AutoSize = true;
            pageCount.Location = new Point(22, 173);
            pageCount.Name = "pageCount";
            pageCount.Size = new Size(94, 15);
            pageCount.TabIndex = 7;
            pageCount.Text = "Кол-во страниц";
            // 
            // autor
            // 
            autor.AutoSize = true;
            autor.Location = new Point(22, 128);
            autor.Name = "autor";
            autor.Size = new Size(40, 15);
            autor.TabIndex = 6;
            autor.Text = "Автор";
            // 
            // yearOfMade
            // 
            yearOfMade.AutoSize = true;
            yearOfMade.Location = new Point(22, 86);
            yearOfMade.Name = "yearOfMade";
            yearOfMade.Size = new Size(75, 15);
            yearOfMade.TabIndex = 5;
            yearOfMade.Text = "Год выпуска";
            // 
            // comboBoxGenre
            // 
            comboBoxGenre.FormattingEnabled = true;
            comboBoxGenre.Location = new Point(143, 216);
            comboBoxGenre.Name = "comboBoxGenre";
            comboBoxGenre.Size = new Size(185, 23);
            comboBoxGenre.TabIndex = 4;
            // 
            // textBoxCntPage
            // 
            textBoxCntPage.Location = new Point(143, 170);
            textBoxCntPage.Name = "textBoxCntPage";
            textBoxCntPage.Size = new Size(185, 23);
            textBoxCntPage.TabIndex = 3;
            textBoxCntPage.TextChanged += textBoxCntPage_TextChanged;
            // 
            // nameOfBook
            // 
            nameOfBook.AutoSize = true;
            nameOfBook.Location = new Point(22, 45);
            nameOfBook.Name = "nameOfBook";
            nameOfBook.Size = new Size(59, 15);
            nameOfBook.TabIndex = 0;
            nameOfBook.Text = "Название";
            // 
            // textBoxAutor
            // 
            textBoxAutor.Location = new Point(143, 125);
            textBoxAutor.Name = "textBoxAutor";
            textBoxAutor.Size = new Size(185, 23);
            textBoxAutor.TabIndex = 2;
            textBoxAutor.TextChanged += textBoxAutor_TextChanged;
            // 
            // textBoxYearMade
            // 
            textBoxYearMade.Location = new Point(143, 83);
            textBoxYearMade.Name = "textBoxYearMade";
            textBoxYearMade.Size = new Size(185, 23);
            textBoxYearMade.TabIndex = 1;
            textBoxYearMade.TextChanged += textBoxYearMade_TextChanged;
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(143, 42);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(185, 23);
            textBoxName.TabIndex = 0;
            textBoxName.TextChanged += textBoxName_TextChanged;
            // 
            // listOfBook
            // 
            listOfBook.FormattingEnabled = true;
            listOfBook.ItemHeight = 15;
            listOfBook.Location = new Point(18, 47);
            listOfBook.Name = "listOfBook";
            listOfBook.Size = new Size(231, 349);
            listOfBook.TabIndex = 1;
            listOfBook.SelectedIndexChanged += listOFBook_SelectedIndexChanged;
            // 
            // ListOfBooks
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox);
            Name = "ListOfBooks";
            Size = new Size(725, 573);
            groupBox.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox;
        private ListBox listOfBook;
        private Label nameOfBook;
        private GroupBox groupBox2;
        private ComboBox comboBoxGenre;
        private TextBox textBoxCntPage;
        private TextBox textBoxAutor;
        private TextBox textBoxYearMade;
        private TextBox textBoxName;
        private Label yearOfMade;
        private Label genre;
        private Label pageCount;
        private Label autor;
        private Button btnDelete;
        private Button btnAdd;
        private Button btnEdit;
    }
}
