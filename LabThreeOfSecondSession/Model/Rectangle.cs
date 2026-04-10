using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThreeOfSecondSession.Model
{
    public class Rectangle   // сделано public
    {
        private double _length;
        private double _width;
        private static int _allRectanglesCount;
        private readonly int _id;


        //public int Left => Center.X - (int)(Width / 2);
        //public int Top => Center.Y - (int)(Length / 2);

        public int Id
        {
            get { return _id; }
        }
        public Point2D Center { get; set; }
        public string Color { get; set; }

        public double Length
        {
            get { return _length; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Length));
                _length = value;
            }
        }

        public double Width
        {
            get { return _width; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Width));
                _width = value;
            }
        }

        public static int AllRectanglesCount
        {
            get { return _allRectanglesCount; }
        }

        // Конструктор с параметрами (использует свойства)
        public Rectangle(double length, double width, string color, int centerX, int centerY)
        {
            Length = length;
            Width = width;
            Color = color;
            Center = new Point2D(centerX, centerY);
            _id = ++_allRectanglesCount;
        }

        // Конструктор без параметров
        public Rectangle() { }
    }
}