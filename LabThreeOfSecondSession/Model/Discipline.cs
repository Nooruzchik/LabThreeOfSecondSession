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
        private int _hours;
        private int _grade;
        public string DisciplineName;
        public string TeachersName;

        public int Hours
        {
            get { return _hours; }
            set
            {
                Validator.AssertOnPositiveValue(value, nameof(Hours));
                _hours = value;
            }
        }
        public int Grade
        {
            get { return _grade; }
            set
            {
                Validator.AssertValueInRange(value, 0, 5, nameof(Grade));
                _grade = value;
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
