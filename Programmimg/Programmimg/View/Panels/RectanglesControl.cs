using Programming.Model.Classes;
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
    /// Осуществляет поиск прямоугольника с наибольшей шириной.
    /// </summary>
    public partial class RectanglesControl : UserControl
    {

        Rectangle[] _rectangles = new Rectangle[5];
        Rectangle _currentRectangle = new Rectangle();
        
        /// <summary>
        /// Создание 5 прямоугольников со случайными значениями.
        /// </summary>
        public RectanglesControl()
        {
            InitializeComponent();
            Random random = new Random();
            string[] rectangle_listboxItems = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Colour randcolor = (Colour)random.Next(1, 7);
                Rectangle rectangle = new Rectangle(random.Next(3, 118), random.Next(3, 320), randcolor);
                _rectangles[i] = rectangle;
                rectangle_listboxItems[i] = ($"Rectangle {i + 1}");
            }
            listBoxRectangles.Items.AddRange(rectangle_listboxItems);
        }

        /// <summary>
        /// Изменение и сохранение значений длины с их валидацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxLenght_TextChanged(object sender, EventArgs e)
        {
            int index = listBoxRectangles.Items.IndexOf(_currentRectangle);
            try
            {
                textBoxLenght.BackColor = AppColors.StandartColor;
                int length = int.Parse(textBoxLenght.Text);
                _currentRectangle.Length = length;

            }
            catch (Exception)
            {
                textBoxLenght.BackColor = AppColors.InvalidColor;
            }

        }

        /// <summary>
        /// Отображение параметров выбранного прямоугольника в ТекстБоксах.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBoxRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRectangles.SelectedIndex == -1) return;
            _currentRectangle = _rectangles[listBoxRectangles.SelectedIndex];
            textBoxLenght.Text = _currentRectangle.Length.ToString();
            textBoxWidth.Text = _currentRectangle.Width.ToString();
            textBoxColor.Text = _currentRectangle.Color.ToString();
            xcentertxtbox.Text = _currentRectangle.Center.coord_X.ToString();
            ycentertxtbox.Text = _currentRectangle.Center.coord_Y.ToString();
            idtxtbox.Text = _currentRectangle.ID.ToString();
        }

        /// <summary>
        /// Метод для поиска прямоугольника с наибольшей шириной.
        /// </summary>
        /// <param name="rectangles"> Массив прямоугольников. </param>
        /// <returns>  Индекс прямоугольника с наибольшей шириной. </returns>
        private int FindRectangleWithMaxWidth(Rectangle[] rectangles)
        {
            double MaxWidth = rectangles[0].Width;
            int MaxWidthIndex = 0;
            for (int i = 0; i < 5; i++)
            {
                if (rectangles[i].Width > MaxWidth)
                {
                    MaxWidth = rectangles[i].Width;
                    MaxWidthIndex = i;
                }
            }
            return MaxWidthIndex;
        }

        /// <summary>
        /// Метод для отображения в ЛистБоксе прямоугольника с наибольшей шириной.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFind_Click(object sender, EventArgs e)
        {
            int RectangleMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            listBoxRectangles.SelectedIndex = RectangleMaxWidthIndex;
        }


        /// <summary>
        /// Изменение и сохранение значений ширины с их валидацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxWidth_TextChanged_1(object sender, EventArgs e)
        {
            int index = listBoxRectangles.Items.IndexOf(_currentRectangle);
            try
            {
                textBoxWidth.BackColor = AppColors.StandartColor;
                int width = int.Parse(textBoxWidth.Text);
                _currentRectangle.Width = width;
            }
            catch (Exception)
            {
                textBoxWidth.BackColor = AppColors.InvalidColor;
            }
        }
    }
}
