using LabTwoOfSecondSession.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabThreeOfSecondSession.View.Pannels
{
    public partial class WeekdayParseControl : UserControl
    {
        public WeekdayParseControl()
        {
            InitializeComponent();
        }

        

        private void buttonParse_Click(object sender, EventArgs e)
        {
            string userText = textBoxForWeek.Text;

            Weekday parseDay;


            bool parseSuccsesful = Enum.TryParse<Weekday>(userText, ignoreCase: true, out parseDay);

            if (parseSuccsesful)
            {

                bool isNumber = true;
                foreach (char c in userText)
                {
                    if (!char.IsDigit(c))
                    {
                        isNumber = false;
                        break;
                    }
                }

                if (isNumber)
                {
                    replaceToInt.Text = "Нет такого дня недели";
                }
                else
                {
                    int numberOfDay = (int)parseDay;
                    replaceToInt.Text = $"Это день недели ({parseDay} = {numberOfDay})";
                }
            }
            else
            {
                replaceToInt.Text = "Нет такого дня недели";
            }
        }
    }
}
