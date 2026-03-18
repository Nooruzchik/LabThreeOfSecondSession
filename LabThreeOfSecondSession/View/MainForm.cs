using LabThreeOfSecondSession.Model;

namespace LabThreeOfSecondSession
{
    public partial class MainForm : Form
    {
        private Model.Rectangle[] _rectangles;
        private Model.Rectangle _currentRectangle;
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

                // Сброс цвета фона (если ранее был красным)
                textBoxLength.BackColor = Color.White;
                textBoxWidth.BackColor = Color.White;
            }
        }
    }
}
