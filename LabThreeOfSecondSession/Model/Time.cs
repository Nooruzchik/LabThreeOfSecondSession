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
                if (value < 0 || value > 23)
                    throw new Exception("Укажите часы от 0 до 23");
                hour = value;
            }
        }

        public int Minute
        {
            get { return minute; }
            set
            {
                if (value < 0 || value > 60)
                    throw new Exception("Минут только 60");
                minute = value;
            }
        }

        public int Second
        {
            get { return  second; }
            set
            {
                if (value < 0 || value > 60)
                    throw new Exception("Секунд только 60");
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
