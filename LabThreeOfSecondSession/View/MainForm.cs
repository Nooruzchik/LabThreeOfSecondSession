using LabThreeOfSecondSession.Model;
using LabTwoOfSecondSession.Model.Enums;
using Rectangle = LabThreeOfSecondSession.Model.Rectangle;  

namespace LabThreeOfSecondSession
{
    public partial class MainForm : Form
    {
        private Model.Rectangle[] _rectangles;
        private Model.Rectangle _currentRectangle;

        private Model.Film[] _movies;
        private Model.Film _currentMovie;

        private List<Rectangle> _rectangleList;
        private Rectangle _selectedRectangle;

        private List<Panel> _rectanglePanels;

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
                int centerX = rand.Next(1, 101);
                int centerY = rand.Next(1, 101);

                _rectangles[i] = new Model.Rectangle(length, width, color, centerX, centerY); // вызывает класс _rectangle
            }


            for (int i = 0; i < _rectangles.Length; i++) // цикл для нумерации прямоугольников
            {
                listBoxRectangles.Items.Add($"Rectangle {i + 1}"); // добавляет нумерованне прямоугольники в listbox
            }


            /*-------------------------------------------------*/

            _movies = new Model.Film[5]; // массив из 5 элементов для фильма
            string[] genres = { "хоррор", "боевик", "фэнтези", "научный" }; // массив цветов


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


            // ============== lab2 =========// 

            seasonComboBox.DataSource = Enum.GetValues(typeof(Season)); // выводит значания Season в comboBox



            /*=============== lab 4=========*/

            _rectangleList = new List<Rectangle>();
            _selectedRectangle = null;


            _rectanglePanels = new List<Panel>();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            EnumsListBox.DisplayMember = "Name"; // выводит только имена перечислений вместо значений
            EnumsListBox.Items.Add(typeof(Colorix)); // вывод перечисления в EnumsListBox
            EnumsListBox.Items.Add(typeof(Weekday));
            EnumsListBox.Items.Add(typeof(EducationForm));
            EnumsListBox.Items.Add(typeof(Manufacture));
            EnumsListBox.Items.Add(typeof(Genre));
            EnumsListBox.Items.Add(typeof(Season));
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
                textBoxCenterX.Text = _currentRectangle.Center.X.ToString();
                textBoxCenterY.Text = _currentRectangle.Center.Y.ToString();
                textBoxId.Text = _currentRectangle.Id.ToString();

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


        // ===================  lab 2 ==============//

        /// <summary>
        /// вывод значений из пречислений во второй список ValuesListBox
        /// </summary>
        private void EnumsListBox_Changed(object sender, EventArgs e)
        {
            Type selectedEnum = EnumsListBox.SelectedItem as Type; // выбор из списака EnumsListBox

            if (selectedEnum != null) // проверка на выбор
            {
                Array enumValues = Enum.GetValues(selectedEnum); // создание списка для сохранения значений перечислений
                ValuesListBox.Items.Clear(); // очистка списка значений
                foreach (var value in enumValues)
                {
                    ValuesListBox.Items.Add(value); // вывод значений в ValuesListBox
                }
            }
        }
        /// <summary>
        /// вывод числового значения соответсвующего значения
        /// </summary>
        private void ValueListBox_Changed(object sender, EventArgs e)
        {
            var selectedValue = ValuesListBox.SelectedItem;
            if (selectedValue != null)
            {
                int numericValue = (int)selectedValue; // явное преобразование
                intValueReturn.Text = numericValue.ToString();
            }
        }


        private void buttonParse_Click(object sender, MouseEventArgs e)
        {
            string userText = textBoxForWeek.Text;

            Weekday parseDay;


            bool parseSuccsesful = Enum.TryParse<Weekday>(userText, ignoreCase: true, out parseDay);

            if (parseSuccsesful)
            {

                bool isNumber = true;
                foreach (char c in userText)
                {
                    if (!char.IsDigit(c))
                    {
                        isNumber = false;
                        break;
                    }
                }

                if (isNumber)
                {
                    replaceToInt.Text = "Нет такого дня недели";
                }
                else
                {
                    int numberOfDay = (int)parseDay;
                    replaceToInt.Text = $"Это день недели ({parseDay} = {numberOfDay})";
                }
            }
            else
            {
                replaceToInt.Text = "Нет такого дня недели";
            }
        }
        /// <summary>
        ///  функция для покраски формы
        /// </summary>
        private void goButton_click(object sender, EventArgs e)
        {
            Season selectedSeason = (Season)seasonComboBox.SelectedItem;

            switch (selectedSeason)
            {
                case Season.winter:
                    tabPage3.BackColor = Color.FromArgb(80, 152, 215);
                    MessageBox.Show("Бррр! Холодно!", "Время года", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case Season.spring:
                    tabPage3.BackColor = Color.FromArgb(85, 156, 69);
                    break;
                case Season.summer:
                    tabPage3.BackColor = Color.FromArgb(236, 228, 61);
                    MessageBox.Show("Ура! Каникулы!", "Время года", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case Season.autumn:
                    tabPage3.BackColor = Color.FromArgb(226, 156, 59);
                    MessageBox.Show("Пора батрачить в универе", "Время года", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("Что-то пошло не так");
                    break;
            }
        }

        private void ComboBox_change(object sender, EventArgs e)
        {
            tabPage1.BackColor = Color.White;
        }

        private void RectangleListBoxNew_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRectanglesNew.SelectedIndex == -1 || _rectangleList.Count == 0)
            {
                _selectedRectangle = null;
                return;
            }


            int selectedIndex = listBoxRectanglesNew.SelectedIndex;
            _selectedRectangle = _rectangleList[selectedIndex];


            textBoxHeight2.Text = _selectedRectangle.Length.ToString();
            textBoxWidth2.Text = _selectedRectangle.Width.ToString();
            textBoxPosX.Text = _selectedRectangle.Center.X.ToString();
            textBoxPosY.Text = _selectedRectangle.Center.Y.ToString();
            textBoxIdNew.Text = _selectedRectangle.Id.ToString();

           
            textBoxLength.BackColor = Color.White;
            textBoxWidth.BackColor = Color.White;
        }

        private void btnAdd_click(object sender, EventArgs e)
        {
            Random rand = new Random();

            double length = rand.Next(30, 101);
            double width = rand.Next(30, 101);
            string color = "Green";
            int centerX = rand.Next(50, 400);
            int centerY = rand.Next(50, 400);


            Rectangle newRect = new Rectangle(length, width, color, centerX, centerY);

            // Добавляем в список
            _rectangleList.Add(newRect);

            // Добавляем в ListBox
            string displayString = $"{newRect.Id}:(X= {centerX}; Y= {centerY}; W= {width}; H= {length})";
            listBoxRectanglesNew.Items.Add(displayString);


            DrawRectangles();    
            FindCollisions();
        }

        private void btnDel_click(object sender, EventArgs e)
        {
            if (listBoxRectanglesNew.SelectedIndex == -1)
                return;  

            if (_rectangleList.Count == 0)
                return;  

            int selectedIndex = listBoxRectanglesNew.SelectedIndex;

            // Удаляем из списка прямоугольников
            _rectangleList.RemoveAt(selectedIndex);

            // Удаляем из ListBox
            listBoxRectanglesNew.Items.RemoveAt(selectedIndex);

            _selectedRectangle = null;


            if (_rectangleList.Count == 0)
            {
                ClearRectangleInfo();
            }
            else
            {
                listBoxRectanglesNew.SelectedIndex = 0;
            }

            DrawRectangles();
            FindCollisions();
        }

        private void UpdateListBoxItem()
        {
            if (listBoxRectanglesNew.SelectedIndex == -1) return;
            if (_selectedRectangle == null) return;

            int index = listBoxRectanglesNew.SelectedIndex;

            string newDisplayString = $"{_selectedRectangle.Id}:(X= {_selectedRectangle.Center.X}; Y= {_selectedRectangle.Center.Y}; W= {_selectedRectangle.Width}; H= {_selectedRectangle.Length})";

            listBoxRectanglesNew.Items[index] = newDisplayString;
        }

        private void textBoxWidth2_TextChanged(object sender, EventArgs e)
        {
            if (_selectedRectangle == null) return;

            try
            {
                double newWidth = Convert.ToDouble(textBoxWidth2.Text);
                _selectedRectangle.Width = newWidth;
                textBoxWidth2.BackColor = Color.White;

                UpdateListBoxItem();
                DrawRectangles();
                FindCollisions();
            }
            catch
            {
                textBoxWidth2.BackColor = Color.LightPink;
            }
        }

        private void textBoxHeight2_TextChanged(object sender, EventArgs e)
        {
            if (_selectedRectangle == null) return;

            try
            {
                double newHeight = Convert.ToDouble(textBoxHeight2.Text);
                _selectedRectangle.Length = newHeight;
                textBoxHeight2.BackColor = Color.White;

                UpdateListBoxItem();
                DrawRectangles();
                FindCollisions();
            }
            catch
            {
                textBoxHeight2.BackColor = Color.LightPink;
            }
        }

        private void textBoxPosX_TextChanged(object sender, EventArgs e)
        {
            if (_selectedRectangle == null) return;

            try
            {
                int newX = Convert.ToInt32(textBoxPosX.Text);
                _selectedRectangle.Center = new Point2D(newX, _selectedRectangle.Center.Y);
                textBoxPosX.BackColor = Color.White;

                UpdateListBoxItem();
                DrawRectangles();
                FindCollisions();
            }
            catch
            {
                textBoxPosX.BackColor = Color.LightPink;
            }
        }

        private void textBoxPosY_TextChanged(object sender, EventArgs e)
        {
            if (_selectedRectangle == null) return;

            try
            {
                int newY = Convert.ToInt32(textBoxPosY.Text);
                _selectedRectangle.Center = new Point2D(_selectedRectangle.Center.X, newY);
                textBoxPosY.BackColor = Color.White;

                UpdateListBoxItem();
                DrawRectangles();
                FindCollisions();
            }
            catch
            {
                textBoxPosY.BackColor = Color.LightPink;
            }
        }

        private void ClearRectangleInfo()
        {
            textBoxHeight2.Text = "";
            textBoxWidth2.Text = "";
            textBoxPosX.Text = "";
            textBoxPosY.Text = "";
            textBoxIdNew.Text = "";

            textBoxHeight2.BackColor = Color.White;
            textBoxWidth2.BackColor = Color.White;
            textBoxPosX.BackColor = Color.White;
            textBoxPosY.BackColor = Color.White;
        }


        private void DrawRectangles()
        {
            // Очищаем канву от старых панелей
            CanvasPanel.Controls.Clear();
            _rectanglePanels.Clear();

            // Проходим по всем прямоугольникам в списке
            foreach (var rect in _rectangleList)
            {
                // Вычисляем координаты верхнего левого угла
                int left = rect.Center.X - (int)(rect.Width / 2);
                int top = rect.Center.Y - (int)(rect.Length / 2);

                // Создаём новую панель
                Panel panel = new Panel
                {
                    Location = new Point(left, top),
                    Width = (int)rect.Width,
                    Height = (int)rect.Length,
                    BackColor = Color.FromArgb(127, 127, 255, 127),  // зелёный полупрозрачный
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Добавляем панель на канву
                CanvasPanel.Controls.Add(panel);

                // Сохраняем в список для дальнейшего управления
                _rectanglePanels.Add(panel);
            }
        }

        private void FindCollisions()
        {
            // Сначала красим все панели в зелёный
            foreach (var panel in _rectanglePanels)
            {
                panel.BackColor = Color.FromArgb(127, 127, 255, 127); // зелёный
            }

            // Двойной цикл для проверки всех пар прямоугольников
            for (int i = 0; i < _rectangleList.Count; i++)
            {
                for (int j = i + 1; j < _rectangleList.Count; j++)  // j = i+1, чтобы не сравнивать с самим собой
                {
                    // Используем CollisionManager для проверки пересечения
                    if (CollisionManager.IsCollision(_rectangleList[i], _rectangleList[j]))
                    {
                        // Если пересекаются - красим оба в красный
                        _rectanglePanels[i].BackColor = Color.FromArgb(127, 255, 127, 127); // красный
                        _rectanglePanels[j].BackColor = Color.FromArgb(127, 255, 127, 127);
                    }
                }
            }
        }
    }
}
