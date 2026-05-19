using LabThreeOfSecondSession.Model;
using LabThreeOfSecondSession.Model.Geometry;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rectangle = LabThreeOfSecondSession.Model.Geometry.Rectangle;

namespace LabThreeOfSecondSession.View.Pannels
{
    public partial class RectanglesControl : UserControl
    {
        private Rectangle[] _rectangles;
        private Rectangle _currentRectangle;
        public RectanglesControl()
        {
            InitializeComponent();

            Random rand = new Random(); // функция рандома
            _rectangles = new Rectangle[5]; // создание массива из 5 элементов 
            string[] colors = { "Orange", "White", "Pink", "Black", "Red", "Blue", "Yellow" }; // массив цветов

            for (int i = 0; i < _rectangles.Length; i++) // цикл для генерации элементов прямоугольника
            {
                double length = rand.Next(1, 101); // рандомная длину
                double width = rand.Next(1, 101); // задает рандомную ширину
                string color = colors[rand.Next(colors.Length)]; // берет рандомный цевт из массива
                int centerX = rand.Next(1, 101);
                int centerY = rand.Next(1, 101);

                _rectangles[i] = new Model.Geometry.Rectangle(length, width, color, centerX, centerY); // вызывает класс _rectangle
            }

            // цикл для нумерации прямоугольников
            for (int i = 0; i < _rectangles.Length; i++) 
            {
                // добавляет нумерованне прямоугольники в listbox
                listBoxRectangles.Items.Add($"Rectangle {i + 1}");
            }
        }

        /// <summary>
        /// обрабатывает изменение выбранного элемента в списке прямоугольников
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

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
                textBoxLength.BackColor = AppColors.ValidInputBackColor;
                textBoxWidth.BackColor = AppColors.ValidInputBackColor;
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
                textBoxLength.BackColor = AppColors.ValidInputBackColor;
            }
            catch (FormatException)
            {
                textBoxLength.BackColor = AppColors.InvalidInputBackColor;
            }
            catch (ArgumentException)
            {
                textBoxLength.BackColor = AppColors.InvalidInputBackColor;
            }
            catch (Exception)
            {
                textBoxLength.BackColor = AppColors.InvalidInputBackColor;
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
                textBoxWidth.BackColor = AppColors.ValidInputBackColor;
            }
            catch (FormatException)
            {
                textBoxWidth.BackColor = AppColors.InvalidInputBackColor;
            }
            catch (ArgumentException)
            {
                textBoxWidth.BackColor = AppColors.InvalidInputBackColor;
            }
            catch (Exception)
            {
                textBoxWidth.BackColor = AppColors.InvalidInputBackColor;
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
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
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
    }
}
