using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThreeOfSecondSession.Model
{
    internal class Ring
    {
        private Point2D _center;
        private double _outerRadius;
        private double _innerRadius;

        // Центр кольца (свойство без валидации, т.к. это готовый объект Point2D)
        public Point2D Center
        {
            get => _center;
            set => _center = value ?? throw new ArgumentNullException(nameof(Center), "Center cannot be null.");
        }

        // Внешний радиус
        public double OuterRadius
        {
            get => _outerRadius;
            set
            {
                // Проверка на положительность (можно использовать Validator)
                Validator.AsserOnPositiveValue(value, nameof(OuterRadius));
                // Если внутренний радиус уже задан, проверяем, что внешний >= внутреннего
                if (value < _innerRadius)
                    throw new ArgumentException("OuterRadius must be greater than or equal to InnerRadius.", nameof(OuterRadius));
                _outerRadius = value;
            }
        }

        // Внутренний радиус
        public double InnerRadius
        {
            get => _innerRadius;
            set
            { 
                Validator.AsserOnPositiveValue(value, nameof(InnerRadius));
                if (value > _outerRadius)
                    throw new ArgumentException("InnerRadius cannot be greater than OuterRadius.", nameof(InnerRadius));
                _innerRadius = value;
            }
        }

        // Конструктор
        public Ring(Point2D center, double outerRadius, double innerRadius)
        {
            Center = center;
            _outerRadius = outerRadius; 
            OuterRadius = outerRadius; 
            InnerRadius = innerRadius;
        }

        // Свойство Area (только чтение, вычисляемое)
        public double Area
        {
            get
            {
                double outerArea = Math.PI * OuterRadius * OuterRadius;
                double innerArea = Math.PI * InnerRadius * InnerRadius;
                return outerArea - innerArea;
            }
        }
    }
}
