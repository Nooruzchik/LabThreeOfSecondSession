using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LabThreeOfSecondSession.Model
{
    internal class Contact
    {
        private string _name;
        private string _surname;
        private string _number;
        private string _email;

        public string Number
        {
            get { return _number; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                
                    throw new Exception("Номер не может быть пустым");
                
                _number = value;
            }
        }


        private void AssertStringContainsOnlyLetters(string value, string propertyName)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException($"{propertyName} не может быть пустым", propertyName);
            if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
                throw new ArgumentException($"{propertyName} must contain only English letters.", propertyName);
        }

        public string Name
        {
            get { return _name; }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Surname));
                //if (string.IsNullOrWhiteSpace(value))
                //    throw new Exception("Имя не может быть пустым");
                _name = value;
            }
        }

        public string Surname
        {
            get { return _surname; }
            set
            {
                AssertStringContainsOnlyLetters(value, nameof(Surname));
                //if (string.IsNullOrWhiteSpace(value))
                //    throw new Exception("Имя не может быть пустым");
                _surname = value;
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Потча не может быть пустым");
                _email = value;

                if (!value.Contains("@") || !value.Contains("."))
                {
                    throw new Exception("Некорентная почта");
                }
            }
        }
        public Contact(string name, string number, string email, string surname)
        {
            Name = name;
            Number = number;
            Email = email;
            Surname = surname;
        }

        public Contact()
        {
        }

    }
}
