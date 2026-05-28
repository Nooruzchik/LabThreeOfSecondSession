using LabTwoOfSecondSession.Model.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThreeOfSecondSession.Model
{
    /// <summary>
    /// Хранит данные о книге.
    /// </summary>
    /// <summary>
    /// Представляет книгу с названием, автором, годом выпуска, количеством страниц и жанром.
    /// </summary>
    public class Book
    {
        private string _title;
        private int _year;
        private string _author;
        private int _pages;
        private Genre _genre;

        /// <summary>
        /// Возвращает и задаёт название книги. Не должно быть пустым и не более 100 символов.
        /// </summary>
        public string Title
        {
            get => _title;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Название не может быть пустым.");
                if (value.Length > 100)
                    throw new ArgumentException("Название не может превышать 100 символов.");
                _title = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт год выпуска. Не может превышать текущий год.
        /// </summary>
        public int Year
        {
            get => _year;
            set
            {
                int currentYear = DateTime.Now.Year;
                if (value < 0 || value > currentYear)
                    throw new ArgumentException($"Год выпуска должен быть от 0 до {currentYear}.");
                _year = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт автора. Не должно быть пустым.
        /// </summary>
        public string Author
        {
            get => _author;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Автор не может быть пустым.");
                _author = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт количество страниц. Должно быть строго положительным.
        /// </summary>
        public int Pages
        {
            get => _pages;
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Количество страниц должно быть положительным числом.");
                _pages = value;
            }
        }

        /// <summary>
        /// Возвращает и задаёт жанр книги.
        /// </summary>
        public Genre Genre
        {
            get => _genre;
            set => _genre = value;
        }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="Book"/>.
        /// </summary>
        /// <param name="title">Название книги.</param>
        /// <param name="year">Год выпуска.</param>
        /// <param name="author">Автор.</param>
        /// <param name="pages">Количество страниц.</param>
        /// <param name="genre">Жанр.</param>
        public Book(string title, int year, string author, int pages, Genre genre)
        {
            Title = title;
            Year = year;
            Author = author;
            Pages = pages;
            Genre = genre;
        }

        /// <summary>
        /// Возвращает строковое представление книги для отображения в списке.
        /// </summary>
        /// <returns>Формат: "Название / Автор / Жанр"</returns>
        public override string ToString()
        {
            return $"{Title} / {Author} / {Genre}";
        }
    }
}

