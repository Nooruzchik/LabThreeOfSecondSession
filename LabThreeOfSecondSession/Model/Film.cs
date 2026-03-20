
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThreeOfSecondSession.Model
{
    internal class Film
    {
        private int _duration;
        private int _yearMade;
        private double _rating;

        // Автосвойства для полей без ограничений
        public string Name { get; set; }
        public string Genre { get; set; }

        public int Duration
        {
            get { return _duration; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Продолжительность должна быть положительной");
                _duration = value;
            }
        }

        public int YearMade
        {
            get { return _yearMade; }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                    throw new ArgumentException("Год должен быть от 1900 до 2026");
                _yearMade = value;
            }
        }

        public double Rating
        {
            get { return _rating; }
            set
            {
                if (value >= 0 && value <= 10)
                {
                    _rating = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "Рейтинг должен быть от 0 до 10");
                }
            }
        }

        // Конструктор с параметрами
        public Film(string name, int duration, int yearMade, string genre, double rating)
        {
            Name = name;
            Duration = duration;
            YearMade = yearMade;
            Genre = genre;
            Rating = rating;
        }

        // Конструктор без параметров
        public Film() { }
    }
}
