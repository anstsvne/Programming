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
    /// Осуществляет поиск фильма с наибольшим рейтингом.
    /// </summary>
    public partial class FilmsControl : UserControl
    {
        Film[] _films = new Film[5];
        Film _currentfilm = new Film();
        /// <summary>
        /// Создание массива из 5 фильмов со случайными значениями года выпуска, рейтинга и жанра.
        /// </summary>
        public FilmsControl()
        {
            InitializeComponent();
            Random random = new Random();
            string[] films_listboxItems = new string[5];
            string[] filmsTitles = new string[5]
                { "Pulp Fiction", "Kill Bill", "The Hatefull Eight", "Once Upon a Time in... Holywood", "Inglourious Basterds" };
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
        /// <summary>
        /// Поиск фильма с наибольшим рейтингом.
        /// </summary>
        /// <param name="_films">Массив фильмов.</param>
        /// <returns>Индекс фильма с наибольшим рейтингом.</returns>
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


        /// <summary>
        /// Отображение данных о выбранном фильме.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        ///  Изменение и сохранение названия фильма с его валидацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxTitle.BackColor = AppColors.StandartColor;
                string Title = textBoxTitle.Text;
                _currentfilm.Title = Title;
            }
            catch (Exception)
            {
                textBoxTitle.BackColor = AppColors.InvalidColor;
            }
        }

        /// <summary>
        /// Изменение и сохранение длительности фильма с её валидацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxDuration_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxDuration.BackColor = AppColors.StandartColor;
                int Duration = int.Parse(textBoxDuration.Text);
                _currentfilm.DurationMinutes = Duration;
            }
            catch (Exception)
            {
                textBoxDuration.BackColor = AppColors.InvalidColor;
            }
        }

        /// <summary>
        /// Изменение и сохранение года выпуска фильма с его валидацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxYear_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxYear.BackColor = AppColors.StandartColor;
                int Release = int.Parse(textBoxYear.Text);
                _currentfilm.ReleaseYear = Release;
            }
            catch (Exception)
            {
                textBoxYear.BackColor = AppColors.InvalidColor;
            }
        }

        /// <summary>
        ///  Изменение и сохранение жанра фильма с его валидацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxGenre_TextChanged(object sender, EventArgs e)
        {
            if (_currentfilm == null) return;
            string genre = textBoxGenre.Text;
            if (TryGetEnumValue<Genre>(genre, out Genre value))
            {
                _currentfilm.Genre = value;
                textBoxGenre.BackColor = AppColors.StandartColor;
            }
            else
            {
                textBoxGenre.BackColor = AppColors.InvalidColor;
            }
        }

        /// <summary>
        /// Изменение и сохранение рейтинга фильма с его валидацией.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxRating_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBoxRating.BackColor = AppColors.StandartColor;
                double Rating = double.Parse(textBoxRating.Text);
                _currentfilm.Rating = Rating;
            }
            catch (Exception)
            {
                textBoxRating.BackColor = AppColors.InvalidColor;
            }
        }

        /// <summary>
        /// Отображение фильма с наибольшим рейтингом.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFind1_Click(object sender, EventArgs e)
        {
            double FilmMaxRateIndex = FindFilmMaxRate(_films);
            listBoxMovie.SelectedIndex = (int)FilmMaxRateIndex;

        }
    }
}