using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThreeOfSecondSession.Model
{
    public static class Validator
    {
        public static void AsserOnPositiveValue(int value, string propertyName)
        {
            if (value <= 0)
                throw new ArgumentException($"{propertyName} must be positive.", propertyName);
        }

        public static void AsserOnPositiveValue(double value, string propertyName)
        {
            if (value <= 0)
                throw new ArgumentException($"{propertyName} must be positive.", propertyName);
        }

        public static void AssertValueInRange(int value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
                throw new ArgumentException($"{propertyName} должно быть от {min} до {max}.", propertyName);
        }
        public static void AssertValueInRange(double value, int min, int max, string propertyName)
        {
            if (value < min || value > max)
                throw new ArgumentException($"{propertyName} должно быть от {min} до {max}.", propertyName);
        }
    }
}
