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

namespace LabThreeOfSecondSession.View.Pannels
{
    public partial class MoviesControl : UserControl
    {
        private Model.Film[] _movies;
        private Model.Film _currentMovie;
        public MoviesControl()
        {
            InitializeComponent();

            Random rand = new Random();

            _movies = new Model.Film[5]; // массив из 5 элементов для фильма
            string[] genres = { "хоррор", "боевик", "фэнтези", "научный" }; // массив цветов

            // цикл для генерации элементов фильма
            for (int i = 0; i < _movies.Length; i++)
            {
                int yearMade = rand.Next(1900, 2027);
                int duration = rand.Next(60, 200);
                double rating = Math.Round(rand.NextDouble() * 10, 1);
                string genre = genres[rand.Next(genres.Length)]; ;
                string name = "Name" + i;


                _movies[i] = new Model.Film(name, duration, yearMade, genre, rating);
            }

            // цикл нумерации фильмов
            for (int i = 0; i < _movies.Length; i++)
            {
                listBoxFilms.Items.Add($"Movie {i + 1}");
            }
        }

        /// <summary>
        /// обрабатывает изменение выбранного элемента в списке фильмов.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void FilmsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFilms.SelectedIndex >= 0)
            {
                // получаем выбранный прямоугольник из массива
                _currentMovie = _movies[listBoxFilms.SelectedIndex];

                // отображаем его значения в текстовых полях
                textBoxName.Text = _currentMovie.Name;
                textBoxYearMade.Text = _currentMovie.YearMade.ToString();
                textBoxGenre.Text = _currentMovie.Genre;
                textBoxDuration.Text = _currentMovie.Duration.ToString();
                textBoxRating.Text = _currentMovie.Rating.ToString();

                // сброс цвета фона 
                textBoxRating.BackColor = AppColors.ValidInputBackColor;
            }
        }

        /// <summary>
        /// обрабатывает изменение текста в поле ввода рейтинга фильма.
        /// </summary>
        
        private void textBoxRating_changed(object sender, EventArgs e)
        {
            if (_currentMovie == null) { return; }

            try
            {
                double newRating = Convert.ToDouble(textBoxRating.Text);

                if (newRating > 0 || newRating <= 10)
                {
                    _currentMovie.Rating = newRating;
                    textBoxRating.BackColor = AppColors.ValidInputBackColor;
                }

            }
            catch (FormatException)
            {
                textBoxRating.BackColor = AppColors.InvalidInputBackColor;
            }
            catch (ArgumentException)
            {
                textBoxRating.BackColor = AppColors.InvalidInputBackColor;
            }
            catch (Exception)
            {
                textBoxRating.BackColor = AppColors.InvalidInputBackColor;
            }
        }

        /// <summary>
        /// Метод поиска максимального рейтинга фильма
        /// </summary>
        /// <param name="movies"></param>
        /// <returns></returns>
        /// 
        private int FindMovieMaxRating(Model.Film[] movies)
        {
            // проверка на заполнение
            if (movies == null || movies.Length == 0)
                return -1;

            int maxIndex = 0; // индекс максимального рейтинга
            double maxRating = movies[0].Rating; // отображаем максимальный рейтинг

            for (int i = 1; i < movies.Length; i++)
            {
                if (movies[i].Rating > maxRating)
                {
                    maxRating = movies[i].Rating;
                    maxIndex = i; // перезаписываем индекс максивального элемента
                }
            }
            return maxIndex;
        }

        /// <summary>
        /// обработчик нажатие на кнопку поиска фильма с максимальным рейтингом
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void btnFindRating_click(object sender, EventArgs e)
        {
            int index = FindMovieMaxRating(_movies);

            if (index != -1)
            {
                listBoxFilms.SelectedIndex = index;
            }
            else
            {
                MessageBox.Show("Массив фильмов пуст!");
            }
        }
    }
}
