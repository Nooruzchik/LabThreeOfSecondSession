using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabThreeOfSecondSession.Model
{
    internal class Contact
    {
        private string name;
        private string number;
        private string email;

        public string Number
        {
            get { return number; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                
                    throw new Exception("Номер не может быть пустым");
                
                number = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Имя не может быть пустым");
                name = value;
            }
        }
        public string Email
        {
            get { return email; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new Exception("Потча не может быть пустым");
                email = value;

                if (!value.Contains("@") || !value.Contains("."))
                {
                    throw new Exception("Некорентная почта");
                }
            }
        }

        public Contact(string name, string number, string email)
        {
            Name = name;
            Number = number;
            Email = email;
        }

        public Contact()
        {
        }

    }
}
