using LabThreeOfSecondSession.Model;
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
                    this.BackColor = AppColors.WinterColor;
                    MessageBox.Show("Бррр! Холодно!", "Время года", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case Season.spring:
                    this.BackColor = AppColors.SpringColor;
                    MessageBox.Show("День рождение", "Время года", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    break;
                case Season.summer:
                    this.BackColor = AppColors.SummerColor;
                    MessageBox.Show("Ура! Каникулы!", "Время года", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;

                case Season.autumn:
                    this.BackColor = AppColors.AutumnColor;
                    MessageBox.Show("Пора батрачить в универе", "Время года", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                default:
                    MessageBox.Show("Что-то пошло не так");
                    break;
            }
        }

        private void ComboBox_change(object sender, EventArgs e)
        {
            this.BackColor = AppColors.ValidInputBackColor;
        }
    }
}
