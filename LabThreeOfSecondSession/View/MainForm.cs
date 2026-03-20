using LabThreeOfSecondSession.Model;

namespace LabThreeOfSecondSession
{
    public partial class MainForm : Form
    {
        private Model.Rectangle[] _rectangles;
        private Model.Rectangle _currentRectangle;

        private Model.Film[] _movies;
        private Model.Film _currentMovie;

        public MainForm()
        {
            InitializeComponent();

            Random rand = new Random(); // функция рандома
            _rectangles = new Model.Rectangle[5]; // создание массива из 5 элементов 
            string[] colors = { "Orange", "White", "Pink", "Black", "Red", "Blue", "Yellow" }; // массив цветов

            for (int i = 0; i < _rectangles.Length; i++) // цикл для генерации элементов прямоугольника
            {
                double length = rand.Next(1, 101); // рандомная длину
                double width = rand.Next(1, 101); // задает рандомную ширину
                string color = colors[rand.Next(colors.Length)]; // берет рандомный цевт из массива

                _rectangles[i] = new Model.Rectangle(length, width, color); // вызывает класс _rectangle
            }


            for (int i = 0; i < _rectangles.Length; i++) // цикл для нумерации прямоугольников
            {
                listBoxRectangles.Items.Add($"Rectangle {i + 1}"); // добавляет нумерованне прямоугольники в listbox
            }


            /*-------------------------------------------------*/
             
            _movies = new Model.Film[5]; // массив из 5 элементов для фильма
            string[] genres = { "хоррор" , "боевик" , "фэнтези" , "научный"}; // массив цветов


            for (int i = 0; i < _movies.Length; i++)  // цикл для генерации элементов фильма
            {
                int yearMade = rand.Next(1900, 2027);
                int duration = rand.Next(60, 200);
                double rating = Math.Round(rand.NextDouble() * 10, 1);
                string genre = genres[rand.Next(genres.Length)]; ;
                string name = "Name" + i;



                _movies[i] = new Model.Film(name, duration, yearMade, genre, rating);
            }

            for (int i = 0; i < _movies.Length; i++)
            {
                listBoxFilms.Items.Add($"Movie {i + 1}");
            }
        }



        private void RectangleListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRectangles.SelectedIndex >= 0)
            {
                // Получаем выбранный прямоугольник из массива
                _currentRectangle = _rectangles[listBoxRectangles.SelectedIndex];

                // Отображаем его значения в текстовых полях
                textBoxLength.Text = _currentRectangle.Length.ToString();
                textBoxWidth.Text = _currentRectangle.Width.ToString();
                textBoxColor.Text = _currentRectangle.Color;

                // Сброс цвета фона 
                textBoxLength.BackColor = Color.White;
                textBoxWidth.BackColor = Color.White;
            }
        }
        
        /// <summary>
        /// изменение цвета текстбокса с длиной
        /// </summary>
        private void textBoxLength_changed(object sender, EventArgs e)
        {
            if (_currentRectangle == null) { return; }

            // обрабатыаем случаи и ловим ошибки
            try
            {
                double newLength = Convert.ToDouble(textBoxLength.Text);

                _currentRectangle.Length = newLength;
                textBoxLength.BackColor = Color.White;
            }
            catch (FormatException)
            {
                textBoxLength.BackColor = Color.LightPink;
            }
            catch (ArgumentException)
            {
                textBoxLength.BackColor = Color.LightPink;
            }
            catch (Exception)
            {
                textBoxLength.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// изменение цвета текстбокса с шириной
        /// </summary>
        private void textBoxWidth_changed(object sender, EventArgs e)
        {
            if (_currentRectangle == null) { return; }

            try
            {
                double newWidth = Convert.ToDouble(textBoxWidth.Text);

                _currentRectangle.Width = newWidth;
                textBoxWidth.BackColor = Color.White;
            }
            catch (FormatException)
            {
                textBoxWidth.BackColor = Color.LightPink;
            }
            catch (ArgumentException)
            {
                textBoxWidth.BackColor = Color.LightPink;
            }
            catch (Exception)
            {
                textBoxWidth.BackColor = Color.LightPink;
            }
        }

        /// <summary>
        /// изменение цвета текстбокса с цветами
        /// </summary>
        private void textBoxColor_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                _currentRectangle.Color = textBoxColor.Text;
            }
        }

        /// <summary>
        /// ищет максимальный элемент с максимальной шириной
        /// </summary>
        /// <returns>возващает индекс максильной ширины элемента</returns>
        private int FindRectangleWithMaxWidth(Model.Rectangle[] rectangles)
        {
            if (rectangles == null || rectangles.Length == 0)
                return -1;

            int maxIndex = 0;
            double maxWidth = rectangles[0].Width;

            for (int i = 1; i < rectangles.Length; i++)
            {
                if (rectangles[i].Width > maxWidth)
                {
                    maxWidth = rectangles[i].Width;
                    maxIndex = i;
                }
            }
            return maxIndex;
        }
        /// <summary>
        /// обработчик нажатия на кнопку find
        /// </summary>
        private void btnFind_click(object sender, EventArgs e)
        {
            int index = FindRectangleWithMaxWidth(_rectangles);
            if (index != -1)
            {
                listBoxRectangles.SelectedIndex = index;
            }
            else
            {
                MessageBox.Show("Массив прямоугольников пуст!");
            }
        }
        /*----------------------------------------------------------------------- */
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
                textBoxRating.BackColor = Color.White;
            }
        }

        private void textBoxRating_changed(object sender, EventArgs e)
        {
            if (_currentMovie == null) { return; }

            try
            {
                double newRating = Convert.ToDouble(textBoxRating.Text);

                //_currentMovie.Rating = newRating;
                //textBoxRating.BackColor = Color.White;

                if (newRating > 0 || newRating <= 10)
                {
                    _currentMovie.Rating = newRating;
                    textBoxRating.BackColor = Color.White;
                }

                //if (newRating > 10)
                //{
                //    textBoxRating.BackColor = Color.LightPink;
                //}
            }
            catch (FormatException)
            {
                textBoxRating.BackColor = Color.LightPink;
            }
            catch (ArgumentException)
            {
                textBoxRating.BackColor = Color.LightPink;
            }
            catch (Exception)
            {
                textBoxRating.BackColor = Color.LightPink;
            }
        }
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
