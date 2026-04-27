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
    public partial class SeasonsControl : UserControl
    {
        public SeasonsControl()
        {
            InitializeComponent();

            seasonComboBox.DataSource = Enum.GetValues(typeof(Season)); // выводит значания Season в comboBox
        }

        /// <summary>
        ///  функция для покраски формы
        /// </summary>
        private void goButton_click(object sender, EventArgs e)
        {
            Season selectedSeason = (Season)seasonComboBox.SelectedItem;

            switch (selectedSeason)
            {
                case Season.winter:
                    //tabPage3.BackColor = Color.FromArgb(80, 152, 215);
                    MessageBox.Show("Бррр! Холодно!", "Время года", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case Season.spring:
                    //tabPage3.BackColor = Color.FromArgb(85, 156, 69);
                    MessageBox.Show("День рождение", "Время года", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case Season.summer:
                    //tabPage3.BackColor = Color.FromArgb(236, 228, 61);
                    MessageBox.Show("Ура! Каникулы!", "Время года", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case Season.autumn:
                    //tabPage3.BackColor = Color.FromArgb(226, 156, 59);
                    MessageBox.Show("Пора батрачить в универе", "Время года", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("Что-то пошло не так");
                    break;
            }
        }

        private void ComboBox_change(object sender, EventArgs e)
        {
            //tabPage3.BackColor = Color.White;
        }
    }
}
