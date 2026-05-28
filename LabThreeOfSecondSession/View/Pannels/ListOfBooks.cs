using LabThreeOfSecondSession.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabTwoOfSecondSession.Model.Enums;

namespace LabThreeOfSecondSession.View.Pannels
{
    
    public partial class ListOfBooks : UserControl
    {
        private List<Book> _books;
        private Book _currentBook;
        public ListOfBooks()
        {
            InitializeComponent();
            InitializeControl();
        }

        /// <summary>
        /// Инициализирует элемент управления: загружает данные, настраивает ComboBox, обновляет список.
        /// </summary>
        private void InitializeControl()
        {
            _books = FileStorage.LoadBooks();
            _currentBook = null;

            // Заполняем ComboBox жанрами из существующего enum Genre
            comboBoxGenre.DataSource = Enum.GetValues(typeof(Genre));
            comboBoxGenre.DropDownStyle = ComboBoxStyle.DropDownList;

            UpdateBooksList();
            ClearInputFields();
        }

        /// <summary>
        /// Обновляет список книг в ListBox с сортировкой по алфавиту.
        /// </summary>
        private void UpdateBooksList()
        {
            var sortedBooks = _books.OrderBy(b => b.Title).ToList();
            listOfBook.DataSource = null;
            listOfBook.DataSource = sortedBooks;
            listOfBook.DisplayMember = null;
        }

        /// <summary>
        /// Отображает данные книги в полях ввода.
        /// </summary>
        private void DisplayBook(Book book)
        {
            textBoxName.Text = book.Title;
            textBoxAutor.Text = book.Author;
            textBoxYearMade.Text = book.Year.ToString();
            textBoxCntPage.Text = book.Pages.ToString();
            comboBoxGenre.SelectedItem = book.Genre;
        }

        /// <summary>
        /// Очищает все поля ввода.
        /// </summary>
        private void ClearInputFields()
        {
            textBoxName.Text = "";
            textBoxAutor.Text = "";
            textBoxYearMade.Text = "";
            textBoxCntPage.Text = "";
            if (comboBoxGenre.Items.Count > 0)
                comboBoxGenre.SelectedIndex = 0;
        }

        /// <summary>
        /// Проверяет корректность введённых данных и подсвечивает поля.
        /// </summary>
        private bool ValidateFields()
        {
            bool isValid = true;

            // Валидация названия
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || textBoxName.Text.Length > 100)
            {
                textBoxName.BackColor = Color.LightPink;
                isValid = false;
            }
            else
            {
                textBoxName.BackColor = Color.White;
            }

            // Валидация автора
            if (string.IsNullOrWhiteSpace(textBoxAutor.Text))
            {
                textBoxAutor.BackColor = Color.LightPink;
                isValid = false;
            }
            else
            {
                textBoxAutor.BackColor = Color.White;
            }

            // Валидация года
            if (!int.TryParse(textBoxYearMade.Text, out int year) || year < 0 || year > DateTime.Now.Year)
            {
                textBoxYearMade.BackColor = Color.LightPink;
                isValid = false;
            }
            else
            {
                textBoxYearMade.BackColor = Color.White;
            }

            // Валидация страниц
            if (!int.TryParse(textBoxCntPage.Text, out int pages) || pages <= 0)
            {
                textBoxCntPage.BackColor = Color.LightPink;
                isValid = false;
            }
            else
            {
                textBoxCntPage.BackColor = Color.White;
            }

            return isValid;
        }

        /// <summary>
        /// Обработчик выбора книги в списке.
        /// </summary>
        private void listOFBook_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentBook = listOfBook.SelectedItem as Book;
            if (_currentBook != null)
            {
                DisplayBook(_currentBook);
            }
            else
            {
                ClearInputFields();
            }
        }

        /// <summary>
        /// Обработчик изменения текста в полях – вызывает валидацию.
        /// </summary>
        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        private void textBoxAutor_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        private void textBoxYearMade_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        private void textBoxCntPage_TextChanged(object sender, EventArgs e)
        {
            ValidateFields();
        }

        /// <summary>
        /// Добавляет новую книгу.
        /// </summary>
        private void btnAdd_click(object sender, EventArgs e)
        {
            if (!ValidateFields())
            {
                MessageBox.Show("Заполните все поля корректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Book newBook = new Book(
                    textBoxName.Text,
                    int.Parse(textBoxYearMade.Text),
                    textBoxAutor.Text,
                    int.Parse(textBoxCntPage.Text),
                    (Genre)comboBoxGenre.SelectedItem
                );

                _books.Add(newBook);
                FileStorage.SaveBooks(_books);
                UpdateBooksList();
                ClearInputFields();
                _currentBook = null;
                listOfBook.ClearSelected();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Редактирует текущую выбранную книгу.
        /// </summary>
        private void btnEdit_click(object sender, EventArgs e)
        {
            if (_currentBook == null)
            {
                MessageBox.Show("Выберите книгу для редактирования.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (!ValidateFields())
            {
                MessageBox.Show("Заполните все поля корректно.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _currentBook.Title = textBoxName.Text;
                _currentBook.Author = textBoxAutor.Text;
                _currentBook.Year = int.Parse(textBoxYearMade.Text);
                _currentBook.Pages = int.Parse(textBoxCntPage.Text);
                _currentBook.Genre = (Genre)comboBoxGenre.SelectedItem;

                FileStorage.SaveBooks(_books);
                UpdateBooksList();
                ClearInputFields();
                _currentBook = null;
                listOfBook.ClearSelected();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Удаляет текущую выбранную книгу.
        /// </summary>
        private void btnDelete_click(object sender, EventArgs e)
        {
            if (_currentBook == null)
            {
                MessageBox.Show("Выберите книгу для удаления.", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult result = MessageBox.Show($"Удалить книгу \"{_currentBook.Title}\"?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                _books.Remove(_currentBook);
                FileStorage.SaveBooks(_books);
                UpdateBooksList();
                ClearInputFields();
                _currentBook = null;
                listOfBook.ClearSelected();
            }
        }
    }
}

