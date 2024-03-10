using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programmimg
{
    public partial class MainForm : Form
    {
        Rectangle[] _rectangles = new Rectangle[5];
        Rectangle _currentRectangle = new Rectangle();
        Film[] _films = new Film[5];
        Film _currentfilm = new Film();
        public MainForm()
        {
            InitializeComponent();
            object[] SeasonValues = Enum.GetValues(typeof(Season)).Cast<object>().ToArray();
            SeasonComboBox.Items.AddRange(SeasonValues);
            Random random = new Random();
            string[] rectangle_listboxItems = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Color randcolor = (Color)random.Next(1, 7);
                Rectangle rectangle = new Rectangle(random.Next(3, 118), random.Next(3, 320), randcolor);
                _rectangles[i] = rectangle;
                rectangle_listboxItems[i] = ($"Rectangle {i + 1}");
            }
            listBoxRectangles.Items.AddRange(rectangle_listboxItems);
            string[] films_listboxItems = new string[5];
            string[] filmsTitles = new string[5] { "Batman", "Avengers: Final", "The GodFather", "Joker", "Ghostbusters" };
            for (int i = 0; i < 5; i++)
            {
                int durationMinutes = random.Next(20, 280);
                int releaseYear = random.Next(1900, DateTime.Now.Year + 1);
                double rating = Math.Round(random.NextDouble() * 10, 1);
                Film film = new Film(filmsTitles[i], durationMinutes, releaseYear, Genre.Action, rating);
                _films[i] = film;
                films_listboxItems[i] = ($"Movie {i + 1}");
            }
            listBoxMovie.Items.AddRange(films_listboxItems);
        }
        static private bool TryGetEnumValue<T>(string itemName, out T value) where T : struct
        {
            if (Enum.TryParse<T>(itemName, true, out value))
            {
                return true;
            }
            value = default;
            return false;
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValuesListBox.Items.Clear();
            switch (EnumsListBox.SelectedIndex) { 
            case 0:
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Color)).Cast<object>().ToArray());
                    break;
                case 1:
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(EducationForm)).Cast<object>().ToArray());
                    break;
                case 2:
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Genre)).Cast<object>().ToArray());
                    break;
                case 3:
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Manufactures)).Cast<object>().ToArray());
                    break;
                case 4:
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Season)).Cast<object>().ToArray());
                    break;
                case 5:
                    ValuesListBox.Items.AddRange(Enum.GetValues(typeof(Weekday)).Cast<object>().ToArray());
                    break;
            }
        }
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntTextBox.Text = ValuesListBox.SelectedIndex.ToString();
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
        private void GoButton_Click(object sender, EventArgs e)
        {
           

        }
        private void SetBackColor(System.Drawing.Color color)
        {
            EnumerationGroupBox.BackColor = color;
            WeekdayGroupBox.BackColor = color;
            SeasonComboBox.BackColor = color;
            this.BackColor = color;
        }
        private void GoButton_Click_1(object sender, EventArgs e)
        {
            if (SeasonComboBox.SelectedItem == null)
            {
                SeasonComboBox.BackColor = System.Drawing.Color.LightPink;
                return;
            }

            SeasonComboBox.BackColor = System.Drawing.Color.White;
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
        private void textBoxLenght_TextChanged(object sender, EventArgs e)
        {
            int index = listBoxRectangles.Items.IndexOf(_currentRectangle);
            try
            {
                textBoxLenght.BackColor = System.Drawing.Color.White;
                int length = int.Parse(textBoxLenght.Text);
                _currentRectangle.Length = length;

            }
            catch (Exception)
            {
                textBoxLenght.BackColor = System.Drawing.Color.LightPink;
            }

        }
        private void listBoxRectangles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRectangles.SelectedIndex == -1) return;
            _currentRectangle = _rectangles[listBoxRectangles.SelectedIndex];
            textBoxLenght.Text = _currentRectangle.Length.ToString();
            textBoxWidth.Text = _currentRectangle.Width.ToString();
            textBoxColor.Text = _currentRectangle.Color.ToString();
        }
        private void textBoxWidth_TextChanged(object sender, EventArgs e)
        {
            int index = listBoxRectangles.Items.IndexOf(_currentRectangle);
            try
            {
                textBoxWidth.BackColor = System.Drawing.Color.White;
                int width = int.Parse(textBoxWidth.Text);
                _currentRectangle.Width = width;
            }
            catch (Exception)
            {
                textBoxWidth.BackColor = System.Drawing.Color.LightPink;
            }

        }
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
        private void buttonFind_Click(object sender, EventArgs e)
        {
            int RectangleMaxWidthIndex = FindRectangleWithMaxWidth(_rectangles);
            listBoxRectangles.SelectedIndex = RectangleMaxWidthIndex;
        }
        private int FindFilmMaxRate(Film[] _films)
        {
            double MaxRate = _films[0].Rating;
            int MaxRateIndex = 0;
            for (int i = 0; i < 5; i++)
            {
                if (_films[i].Rating > MaxRate)
                {
                    MaxRate = _films[i].Rating;
                    MaxRateIndex = i;
                }
            }
            return MaxRateIndex;
        }

        private void listBoxMovie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxMovie.SelectedIndex == -1) return;
            _currentfilm = _films[listBoxMovie.SelectedIndex];
            textBoxTitle.Text = _currentfilm.Title.ToString();
            textBoxDuration.Text = _currentfilm.DurationMinutes.ToString();
            textBoxYear.Text = _currentfilm.ReleaseYear.ToString();
            textBoxGenre.Text = _currentfilm.Genre.ToString();
            textBoxRating.Text = _currentfilm.Rating.ToString();
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxTitle.BackColor = System.Drawing.Color.White;
                string Title = textBoxTitle.Text;
                _currentfilm.Title = Title;
            }
            catch (Exception)
            {
                textBoxTitle.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void textBoxDuration_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxDuration.BackColor = System.Drawing.Color.White;
                int Duration = int.Parse(textBoxDuration.Text);
                _currentfilm.DurationMinutes = Duration;
            }
            catch (Exception)
            {
                textBoxDuration.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxYear.BackColor = System.Drawing.Color.White;
                int Release = int.Parse(textBoxYear.Text);
                _currentfilm.ReleaseYear = Release;
            }
            catch (Exception)
            {
                textBoxYear.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void textBoxGenre_TextChanged(object sender, EventArgs e)
        {
            if (_currentfilm == null) return;
            string genre = textBoxGenre.Text;
            if (TryGetEnumValue<Genre>(genre, out Genre value))
            {
                _currentfilm.Genre = value;
                textBoxGenre.BackColor = System.Drawing.Color.White;
            }
            else
            {
                textBoxGenre.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void textBoxRating_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxRating.BackColor = System.Drawing.Color.White;
                double Rating = double.Parse(textBoxRating.Text);
                _currentfilm.Rating = Rating;
            }
            catch (Exception)
            {
                textBoxRating.BackColor = System.Drawing.Color.LightPink;
            }
        }

        private void buttonFind1_Click(object sender, EventArgs e)
        {
            double FilmMaxRateIndex = FindFilmMaxRate(_films);
            listBoxMovie.SelectedIndex = (int)FilmMaxRateIndex;
            
        }
    }
}   
