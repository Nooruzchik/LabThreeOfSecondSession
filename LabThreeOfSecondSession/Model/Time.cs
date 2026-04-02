using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThreeOfSecondSession.Model
{
    internal class Time
    {
        private int hour;
        private int minute;
        private int second;

        public int Hour
        {
            get { return hour; }
            set
            {
                Validator.AssertValueInRange(value, 0, 23, nameof(Hour));
                hour = value;
            }
        }

        public int Minute
        {
            get { return minute; }
            set
            {
                Validator.AssertValueInRange(value, 0, 60, nameof(Minute));
                minute = value;
            }
        }

        public int Second
        {
            get { return  second; }
            set
            {
                Validator.AssertValueInRange(value, 0, 60, nameof(Second));
                second = value;
            }
        }
        // Конструктор с параметрами (нужен по пункту 7)
        public Time(int hour, int minute, int second)
        {
            Hour = hour;      
            Minute = minute;
            Second = second;
        }

        // Конструктор без параметров (нужен по пункту 8)
        public Time() { }
    }
}
