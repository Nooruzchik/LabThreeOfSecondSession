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

namespace LabThreeOfSecondSession.View
{
    public partial class RectanglesCollisionControl : UserControl
    {
        private List<Rectangle> _rectangleList;
        private Rectangle _selectedRectangle;

        private List<Panel> _rectanglePanels;
        
        public RectanglesCollisionControl()
        {
            InitializeComponent();

            _rectangleList = new List<Rectangle>();
            _selectedRectangle = null;
            _rectanglePanels = new List<Panel>();

        }

        /// <summary>
        /// метод для выбора прямоугольника из списка listBox
        /// </summary>
        
        private void RectangleListBoxNew_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRectanglesNew.SelectedIndex == -1 || _rectangleList.Count == 0)
            {
                _selectedRectangle = null;
                return;
            }


            int selectedIndex = listBoxRectanglesNew.SelectedIndex;
            _selectedRectangle = _rectangleList[selectedIndex];

            UpdateRectangleInfo(_selectedRectangle);
        }

        /// <summary>
        /// метод добавления новых прямоугольников в список listBox
        /// </summary>

        private void btnAdd_click(object sender, EventArgs e)
        {
            Rectangle newRect = RectangleFactory.Randomize(CanvasPanel.Width, CanvasPanel.Height);

            // Добавляем в список
            _rectangleList.Add(newRect);

            string displayString = $"{newRect.Id}:(X= {newRect.Center.X}; Y= {newRect.Center.Y}; W= {newRect.Width}; H= {newRect.Length})";
            listBoxRectanglesNew.Items.Add(displayString);


            DrawRectangles(); // вывоз метода отображения прямоугольника
            FindCollisions(); // вывоз метода поиска пересечения
        }

        /// <summary>
        /// метод удаления прямоугольников из списка listBox
        /// </summary>

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

            DrawRectangles(); // вывоз метода отображения прямоугольника
            FindCollisions(); // вывоз метода поиска пересече
        }

        /// <summary>
        ///  метод обновления listBox
        /// </summary>
        private void UpdateListBoxItem()
        {
            if (listBoxRectanglesNew.SelectedIndex == -1) return;
            if (_selectedRectangle == null) return;

            int index = listBoxRectanglesNew.SelectedIndex;

            string newDisplayString = $"{_selectedRectangle.Id}:(X= {_selectedRectangle.Center.X}; Y= {_selectedRectangle.Center.Y}; W= {_selectedRectangle.Width}; H= {_selectedRectangle.Length})";

            listBoxRectanglesNew.Items[index] = newDisplayString;
        }

        /// <summary>
        /// метод изменения Ширины прямоугольника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void textBoxWidth2_TextChanged(object sender, EventArgs e)
        {
            if (_selectedRectangle == null) return;

            try
            {
                double newWidth = Convert.ToDouble(textBoxWidth2.Text);
                _selectedRectangle.Width = newWidth;
                textBoxWidth2.BackColor = AppColors.ValidInputBackColor;

                UpdateListBoxItem(); // вызов метода обновления списка прямоугольников
                DrawRectangles(); // вывоз метода отображения прямоугольника
                FindCollisions(); // вывоз метода поиска пересече
            }
            catch
            {
                textBoxWidth2.BackColor = AppColors.InvalidInputBackColor;
            }
        }

        /// <summary>
        /// метод изменения высоты прямоугольника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        
        private void textBoxHeight2_TextChanged(object sender, EventArgs e)
        {
            if (_selectedRectangle == null) return;

            try
            {
                double newHeight = Convert.ToDouble(textBoxHeight2.Text);
                _selectedRectangle.Length = newHeight;
                textBoxHeight2.BackColor = AppColors.ValidInputBackColor;

                UpdateListBoxItem(); // вызов метода обновления списка прямоугольников
                DrawRectangles(); // вывоз метода отображения прямоугольника
                FindCollisions(); // вывоз метода поиска пересече
            }
            catch
            {
                textBoxHeight2.BackColor = AppColors.InvalidInputBackColor;
            }
        }

        /// <summary>
        /// метод изменения координаты по X
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void textBoxPosX_TextChanged(object sender, EventArgs e)
        {
            if (_selectedRectangle == null) return;

            try
            {
                int newX = Convert.ToInt32(textBoxPosX.Text);
                _selectedRectangle.Center = new Point2D(newX, _selectedRectangle.Center.Y);
                textBoxPosX.BackColor = AppColors.ValidInputBackColor;

                UpdateListBoxItem();
                DrawRectangles();
                FindCollisions();
            }
            catch
            {
                textBoxPosX.BackColor = AppColors.InvalidInputBackColor;
            }
        }


        /// <summary>
        /// метод изменения координаты по Y
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxPosY_TextChanged(object sender, EventArgs e)
        {
            if (_selectedRectangle == null) return;

            try
            {
                int newY = Convert.ToInt32(textBoxPosY.Text);
                _selectedRectangle.Center = new Point2D(_selectedRectangle.Center.X, newY);
                textBoxPosY.BackColor = AppColors.ValidInputBackColor;

                UpdateListBoxItem();
                DrawRectangles();
                FindCollisions();
            }
            catch
            {
                textBoxPosY.BackColor = AppColors.InvalidInputBackColor;
            }
        }


        /// <summary>
        /// очищает все поля ввода информации о прямоугольнике
        /// </summary>

        private void ClearRectangleInfo()
        {
            textBoxHeight2.Text = "";
            textBoxWidth2.Text = "";
            textBoxPosX.Text = "";
            textBoxPosY.Text = "";
            textBoxIdNew.Text = "";

            textBoxHeight2.BackColor = AppColors.ValidInputBackColor;
            textBoxWidth2.BackColor = AppColors.ValidInputBackColor;
            textBoxPosX.BackColor = AppColors.ValidInputBackColor;
            textBoxPosY.BackColor = AppColors.ValidInputBackColor;
        }

        /// <summary>
        /// обновляет поля ввода информацией о выбранном прямоугольнике
        /// </summary>
        /// <param name="rectangle"></param>

        private void UpdateRectangleInfo(Rectangle rectangle)
        {
            if (rectangle == null)
            {
                ClearRectangleInfo();
                return;
            }

            textBoxHeight2.Text = rectangle.Length.ToString();
            textBoxWidth2.Text = rectangle.Width.ToString();
            textBoxPosX.Text = rectangle.Center.X.ToString();
            textBoxPosY.Text = rectangle.Center.Y.ToString();
            textBoxIdNew.Text = rectangle.Id.ToString();

            textBoxHeight2.BackColor = AppColors.ValidInputBackColor;
            textBoxWidth2.BackColor = AppColors.ValidInputBackColor; ;
            textBoxPosX.BackColor = AppColors.ValidInputBackColor;
            textBoxPosY.BackColor = AppColors.ValidInputBackColor;
        }

        /// <summary>
        /// метод отрисовки прямоугольников
        /// </summary>
        private void DrawRectangles()
        {
            CanvasPanel.Controls.Clear();
            _rectanglePanels.Clear();

            // Проходим по всем прямоугольникам в списке
            foreach (var rect in _rectangleList)
            {
                // Вычисляем координаты верхнего левого угла
                int left = rect.Center.X - (int)(rect.Width / 2);
                int top = rect.Center.Y - (int)(rect.Length / 2);


                Panel panel = new Panel
                {
                    Location = new Point(left, top),
                    Width = (int)rect.Width,
                    Height = (int)rect.Length,
                    BackColor = Color.FromArgb(127, 127, 255, 127),
                    BorderStyle = BorderStyle.FixedSingle
                };

                CanvasPanel.Controls.Add(panel);


                _rectanglePanels.Add(panel);
            }
        }
        /// <summary>
        /// метод поиска пересечений прямоугольников
        /// </summary>
        private void FindCollisions()
        {
            foreach (var panel in _rectanglePanels)
            {
                panel.BackColor = AppColors.NonCollisionRectangleColor;
            }

            for (int i = 0; i < _rectangleList.Count; i++)
            {
                for (int j = i + 1; j < _rectangleList.Count; j++)
                {
                    if (CollisionManager.IsCollision(_rectangleList[i], _rectangleList[j]))
                    {
                        _rectanglePanels[i].BackColor = AppColors.CollisionRectangleColor;
                        _rectanglePanels[j].BackColor = AppColors.CollisionRectangleColor;
                    }
                }
            }
        }

    }
}
