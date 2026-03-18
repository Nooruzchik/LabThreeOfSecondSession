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

        public string Color { get; set; }

        public double Length
        {
            get { return _length; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Длина должна быть положительной");
                _length = value;
            }
        }

        public double Width
        {
            get { return _width; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Ширина должна быть положительной");
                _width = value;
            }
        }

        // Конструктор с параметрами (использует свойства)
        public Rectangle(double length, double width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }

        // Конструктор без параметров
        public Rectangle() { }
    }
}