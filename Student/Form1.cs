using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{

    public partial class Form1 : Form
    {
        private List<Student> _students = new List<Student>();
        private Student _currentStudent;
        private string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data.txt");
        private bool ignoreChanges = false;
        public Form1()
        {
            InitializeComponent();
            LoadStudentList();
            DisplayStudentList();
            SortStudents();
            FullNameLabel.Text = "";
            IdLabel.Text = "";
            GroupLabel.Text = "";
            FacultyLabel.Text = "";
            EducationFormLabel.Text = "";
            FacultyComboBox.DataSource = Enum.GetValues(typeof(Faculty));
            EducationFormComboBox.DataSource = Enum.GetValues(typeof (EducationForm));
            // Путь к файлу с данными

        }

        private void StudentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = StudentListBox.SelectedIndex;

            // Если выбранный индекс действителен
            if (selectedIndex != -1)
            {
                // Обновляем текущего студента
                _currentStudent = _students[selectedIndex];

                // Обновляем поля ввода с данными выбранным студентом
                FullNameTextBox.Text = _currentStudent.FullName;
                GroupTextBox.Text = _currentStudent.Group;
                FacultyComboBox.Text = _currentStudent.Faculty.ToString();
                EducationFormComboBox.Text = _currentStudent.EducationForm.ToString();

            }
            else
            {
                // Сбрасываем текущего студента, если ничего не выбрано
                _currentStudent = null;
                FullNameTextBox.Text = string.Empty;
                GroupTextBox.Text = string.Empty;
                FacultyComboBox.SelectedIndex = -1;
                EducationFormComboBox.SelectedIndex = -1;
            }
        }

        private void FullNameTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                FullNameTextBox.BackColor = AppColors.StandartColor;
                string fullname = FullNameTextBox.Text;

                // Проверяем, инициализирован ли _currentSudent
                if (_currentStudent == null)
                {
                    _currentStudent = new Student();
                }
                FullNameLabel.Text = "";
                _currentStudent.FullName = fullname;
                SortStudents();
                // Сохраняем список студентов в файл
                SaveStudentList();

                // Отображаем обновленный список студентов в ListBox
                DisplayStudentList();

            }
            catch (Exception ex)
            {
                FullNameTextBox.BackColor = AppColors.InvalidColor;
                FullNameLabel.Text = ex.Message;
            }
        }

        private void GroupTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                GroupTextBox.BackColor = AppColors.StandartColor;
                string group = GroupTextBox.Text;

                // Проверяем, инициализирован ли _currentStudent
                if (_currentStudent == null)
                {
                    _currentStudent = new Student();
                }
                FullNameLabel.Text = "";
                _currentStudent.Group = group;
                SortStudents();
                // Сохраняем список студентов в файл
                SaveStudentList();

                // Отображаем обновленный список студентов в ListBox
                DisplayStudentList();

            }
            catch (Exception ex)
            {
                GroupTextBox.BackColor = AppColors.InvalidColor;
                GroupLabel.Text = ex.Message;
            }
        }

        private void FacultyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = StudentListBox.SelectedIndex;

            try
            {
                if (selectedIndex != -1 && Enum.TryParse(FacultyComboBox.SelectedItem?.ToString(), out Faculty faculty))
                {
                    Student selectedStudent = _students[selectedIndex];
                    selectedStudent.Faculty = faculty;
                    FacultyLabel.Text = "";
                    StudentListBox.Items[selectedIndex] = selectedStudent;

                    // Сортируем список студентов после изменения данных
                    SortStudents();

                    SaveStudentList();
                    DisplayStudentList();
                }
            }
            catch (Exception ex)
            {
                FacultyComboBox.BackColor = AppColors.InvalidColor;
                FacultyLabel.Text = ex.Message;
            }
        }
        private void EducationFormComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = StudentListBox.SelectedIndex;

            try
            {
                if (selectedIndex != -1 && Enum.TryParse(EducationFormComboBox.SelectedItem?.ToString(), out EducationForm educationform))
                {
                    Student selectedStudent = _students[selectedIndex];
                    selectedStudent.EducationForm = educationform;
                    EducationFormLabel.Text = "";
                    StudentListBox.Items[selectedIndex] = selectedStudent;

                    // Сортируем список студентов после изменения данных
                    SortStudents();

                    SaveStudentList();
                    DisplayStudentList();
                }
            }
            catch (Exception ex)
            {
                EducationFormComboBox.BackColor = AppColors.InvalidColor;
                EducationFormLabel.Text = ex.Message;
            }
        }
        private void LoadStudentList()
        {
            if (File.Exists(filePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(filePath);

                    foreach (string line in lines)
                    {
                        // Парсим каждую строку в объект Student и добавляем его в список
                        string[] parts = line.Split(',');
                        Student student = new Student
                        {
                            FullName = parts[0],
                            Id = int.Parse(parts[1]),
                            Group = parts[2],
                            Faculty = (Faculty)Enum.Parse(typeof(Faculty), parts[3]),
                            EducationForm = (EducationForm)Enum.Parse(typeof(EducationForm), parts[4])
                        };
                        _students.Add(student);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при чтении файла: " + ex.Message);
                }
            }
        }
        private void SaveStudentList()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (Student student in _students)
                    {
                        // Записываем каждого студента в файл в формате "Полное имя,Номер зачетки,Группа,Факультет,Форма обучения"
                        writer.WriteLine($"{student.FullName},{student.Id},{student.Group},{student.Faculty}, {student.EducationForm}");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
            }
        }
        private void SortStudents()
        {
            // Сортируем список студентов
            var sortedStudents = _students.OrderBy(song => song.FullName).ToList();

            // Очищаем BindingList и добавляем отсортированных студентов
            _students.Clear();
            foreach (var student in sortedStudents)
            {
                _students.Add(student);
            }
        }
        private void DisplayStudentList()
        {
            // Очищаем ListBox перед добавлением обновленных данных
            StudentListBox.Items.Clear();

            // Добавляем каждого студента из списка в ListBox
            foreach (Student student in _students)
            {
                StudentListBox.Items.Add($"Full Name: {student.FullName},Group: {student.Group}, Faculty:{student.Faculty}");
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            var newStudent = new Student
            {
                FullName = FullNameTextBox.Text,
                Group = GroupTextBox.Text,
                Id = int.Parse(IdTextBox.Text),
                Faculty = (Faculty)FacultyComboBox.SelectedItem,
                EducationForm = (EducationForm)EducationFormComboBox.SelectedItem
            };

            _students.Add(newStudent);
            SortStudents();
            ignoreChanges = true;
            FullNameTextBox.Clear();
            GroupTextBox.Clear();
            IdTextBox.Clear();
            FacultyComboBox.SelectedIndex = -1;
            EducationFormComboBox.SelectedIndex = -1;
            ignoreChanges = false;
            FullNameLabel.Text = "";
            GroupLabel.Text = "";
            IdLabel.Text = "";
            FacultyLabel.Text = "";
            EducationFormLabel.Text = "";
            StudentListBox.ClearSelected();

            SaveStudentList();

            // Отображаем обновленный список студентов в ListBox
            DisplayStudentList();

            // Очищаем поля ввода после добавления студента
            ClearInputFields();
        }
        /// <summary>
        /// Осуществляет удаление объекта класса Student.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
    }

    private void DeleteButton_Click(object sender, EventArgs e)
        {
        int selectedIndex = SongsListBox.SelectedIndex;
        // Проверяем, выбран ли какой-либо элемент в ListBox
        if (selectedIndex != -1)
        {
            // Получаем индекс выбранной песни


            // Удаляем песню из списка
            _songs.RemoveAt(selectedIndex);
            SortSongs();
            // Сохраняем список песен в файл
            SaveSongList();

            // Отображаем обновленный список песен в ListBox
            DisplaySongList();

            ClearInputFields();
            SongNameErrorlabel.Text = "";
            ArtistNameErrorlabel.Text = "";
            DurationErrorlabel.Text = "";
            GenreErrorlabel.Text = "";
        }
        else
        {
            MessageBox.Show("Выберите песню для удаления.");
        }
    }
    /// <summary>
    /// Осуществляет очищение значений из TextBox и ComboBox.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>A
}

private void ClearSelectedButton_Click(object sender, EventArgs e)
        {

        }
    }
}

