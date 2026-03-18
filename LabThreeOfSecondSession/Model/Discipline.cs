using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace LabThreeOfSecondSession.Model
{
    internal class Discipline
    {
        private int hours;
        private int grade;
        public string DisciplineName;
        public string TeachersName;

        public int Hours
        {
            get { return hours; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Количество часов не может быть отрицательным");
                hours = value;
            }
        }
        public int Grade
        {
            get { return grade; }
            set
            {
                if (value < 0 || value > 5)
                    throw new ArgumentException("Оценка должна быть от 0 до 5");
                grade = value;
            }
        }

        // Конструктор с параметрами
        public Discipline(int hours, int grade, string disciplineName, string teachersName)
        {
            Hours = hours;
            Grade = grade;
            DisciplineName = disciplineName;
            TeachersName = teachersName;
        }

        // Конструктор без параметров 
        public Discipline()
        {
        }
    }
}
