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
    public partial class EnumsListControl : UserControl
    {
        public EnumsListControl()
        {
            InitializeComponent();

            // выводит в listBox все названия классов 

            EnumsListBox.DisplayMember = "Name"; // выводит только имена перечислений вместо значений
            EnumsListBox.Items.Add(typeof(Colorix)); // вывод перечисления в EnumsListBox
            EnumsListBox.Items.Add(typeof(Weekday));
            EnumsListBox.Items.Add(typeof(EducationForm));
            EnumsListBox.Items.Add(typeof(Manufacture));
            EnumsListBox.Items.Add(typeof(Genre));
            EnumsListBox.Items.Add(typeof(Season));

        }

        /// <summary>
        /// вывод значений из пречислений во второй список ValuesListBox
        /// </summary>
        
        private void EnumsListBox_Changed(object sender, EventArgs e)
        {
            Type selectedEnum = EnumsListBox.SelectedItem as Type; // выбор из списака EnumsListBox

            if (selectedEnum != null) // проверка на выбор
            {
                Array enumValues = Enum.GetValues(selectedEnum); // создание списка для сохранения значений перечислений
                ValuesListBox.Items.Clear(); // очистка списка значений
                foreach (var value in enumValues)
                {
                    ValuesListBox.Items.Add(value); // вывод значений в ValuesListBox
                }
            }
        }

        /// <summary>
        /// вывод числового значения соответсвующего значения
        /// </summary>
        
        private void ValueListBox_Changed(object sender, EventArgs e)
        {
            var selectedValue = ValuesListBox.SelectedItem;
            if (selectedValue != null)
            {
                int numericValue = (int)selectedValue; // явное преобразование
                intValueReturn.Text = numericValue.ToString();
            }
        }

    }
}
