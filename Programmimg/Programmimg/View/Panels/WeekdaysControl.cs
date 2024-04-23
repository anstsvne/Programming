using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programmimg.View.Panels
{
    /// <summary>
    /// Проверяет, является ли введенное значение днём недели, обращаясь к перечислению <see cref="Weekday"/>.
    /// </summary>
    public partial class WeekdaysControl : UserControl
    {
        public WeekdaysControl()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string ParsingText = ParsingTextBox.Text;
            Weekday ParsedDay;

            if (!int.TryParse(ParsingText, out _) && Enum.TryParse<Weekday>(ParsingText, true, out ParsedDay))
            {
                int WeekdayOrder = (int)ParsedDay;
                ParsedValueLabel.Text = $"Это день недели ({ParsedDay} = {WeekdayOrder})";
            }
            else
            {
                ParsedValueLabel.Text = "Нет такого дня недели!!!!";
            }
        }
    }

}
