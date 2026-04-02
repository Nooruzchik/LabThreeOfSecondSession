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
    }
}
