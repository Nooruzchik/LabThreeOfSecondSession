using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThreeOfSecondSession.Model
{
    internal class Rectangle
    {
        private double length;
        private double width;
        public string Color { get; set; }

        public double Length
        {
            get {  return length; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Длинна должна быть положительной");
                length = value;
            }
        }

        public double Width
        {
            get { return width; }
            set
            {
                if (value <= 0)
                    throw new Exception("Ширина должна быть положительной");
                width = value;
            }
        }

        // Конструктор с параметрами (инициализация через свойства!)
        public Rectangle(double length, double width, string color)
        {
            Length = length;
            Width = width;
            Color = color;
        }

        // Конструктор без параметров 
        public Rectangle()
        {
        }
    }
}
