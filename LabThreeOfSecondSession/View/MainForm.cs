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

            Random rand = new Random();
            _rectangles = new Model.Rectangle[5];


            for (int i = 0; i < _rectangles.Length; i++)
            {
                double length = rand.Next(1, 101);
                double width = rand.Next(1, 101);
                string color = "color" + i;

                _rectangles[i] = new Model.Rectangle(length, width, color);
            }


            for (int i = 0; i < _rectangles.Length; i++)
            {
                listBoxRectangles.Items.Add($"Rectangle {i + 1}");
            }


            /*-------------------*/

            _movies = new Model.Film[5];

            for (int i = 0; i < _movies.Length; i++)
            {
                int yearMade = rand.Next(1900, 2027);
                int duration = rand.Next(60, 301);
                double rating = rand.Next(0, 11);
                string genre = "Genre" + i;
                string name = "Name" + i;



                _movies[i] = new Model.Film(name, duration,yearMade, genre, rating);
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

        private void textBoxLength_changed(object sender, EventArgs e)
        {
            if (_currentRectangle == null) { return; }

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

        private void textBoxColor_TextChanged(object sender, EventArgs e)
        {
            if (_currentRectangle != null)
            {
                _currentRectangle.Color = textBoxColor.Text;
            }
        }

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



    }
}
