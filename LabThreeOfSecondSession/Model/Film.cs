
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
                Validator.AssertOnPositiveValue(value, nameof(Duration));
                _duration = value;
            }
        }

        public int YearMade
        {
            get { return _yearMade; }
            set
            {
                Validator.AssertValueInRange(value, 1900, DateTime.Now.Year, nameof(YearMade));
                _yearMade = value;
            }
        }

        public double Rating
        {
            get { return _rating; }
            set
            {
                

                Validator.AssertValueInRange(value, 0, 10, nameof(Rating));
                _rating = value;
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
