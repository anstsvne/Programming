using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Programming.Model.Classes;

namespace Programming.View.Panels
{
    /// <summary>
    /// Выполняет действия, в зависимости от выбранного времени года.
    /// </summary>
    public partial class SeasonControl : UserControl
    {
        public SeasonControl()
        {
            InitializeComponent();
            foreach (Season season in Enum.GetValues(typeof(Season)))
            {
                SeasonComboBox.Items.Add(season);
            }

        }
        private void SetBackColor(System.Drawing.Color color)
        {
            SeasonComboBox.BackColor = color;
            this.BackColor = color;
        }
        private void GoButton_Click_1(object sender, EventArgs e)
        {
            if (SeasonComboBox.SelectedItem == null)
            {
                SeasonComboBox.BackColor = AppColors.InvalidColor;
                return;
            }

            SeasonComboBox.BackColor = AppColors.StandartColor;
            switch (SeasonComboBox.SelectedItem)
            {
                case Season.Summer:
                    MessageBox.Show("Ура! Солнце!");
                    break;
                case Season.Autumn:
                    SetBackColor(GroupBoxSeasonHandle.BackColor = ColorTranslator.FromHtml("#e29c45"));
                    break;
                case Season.Winter:
                    MessageBox.Show("Бррр! Холодно!");
                    break;
                case Season.Spring:
                    SetBackColor(GroupBoxSeasonHandle.BackColor = ColorTranslator.FromHtml("#559c45"));
                    break;
            }

        }
    }
}