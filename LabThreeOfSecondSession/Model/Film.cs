
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThreeOfSecondSession.Model
{
    internal class Film
    {
        private int duration;
        private int yearMade;
        private double rating;

        // Автосвойства для полей без ограничений
        public string Name { get; set; }
        public string Genre { get; set; }

        public int Duration
        {
            get { return duration; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Продолжительность должна быть положительной");
                duration = value;
            }
        }

        public int YearMade
        {
            get { return yearMade; }
            set
            {
                if (value < 1900 || value > DateTime.Now.Year)
                    throw new ArgumentException("Год должен быть от 1900 до 2026");
                yearMade = value;
            }
        }

        public double Rating
        {
            get { return rating; }
            set
            {
                if (value <= 0.0 && value > 10.0)
                    throw new ArgumentException("Рейтинг должен быть от 0 до 10");
                rating = value;
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
