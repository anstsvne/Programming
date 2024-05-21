using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    public class Student
    {
        private static List<int> IdInUse = new List<int>();
        /// <summary>
        /// Полное имя для каждого объекта класса.
        /// </summary>
        private string _fullName;
        /// <summary>
        /// Группа для каждого объекта класса.
        /// </summary>
        private string _group;
        /// <summary>
        /// Уникальный id для каждого объекта класса.
        /// </summary>
        private int _id;
        /// <summary>
        /// Факультет из перечисления Faculty
        /// </summary>
        private Faculty _faculty;
        /// <summary>
        /// Форму обучения из перечисления EducationForm
        /// </summary>
        private EducationForm _educationForm;
        /// <summary>
        /// Возвращает и задаёт полное имя. Не может быть пустым полем.
        /// </summary>
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                int strLength = value.Length;
                Validator.AssertValueLength(strLength, 1, 200, nameof(FullName));
                _fullName = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт группу. Не может быть пустым полем.
        /// </summary>
        public string Group
        {
            get
            {
                return _group;
            }
            set
            {
                int strLength = value.Length;
                Validator.AssertValueLength(strLength, 1, 10, nameof(Group));
                _group = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт длительность песни в секундах. Должно быть целым числом, больше 0.
        /// </summary>
        public int Id
        {
            get
            {
                if (_id == 0) _id = GenerateId();

                return _id;
            }
            set
            {
                if (_id == 0 && (value > 100000) & (value < 999999)) _id = value;
            }
        }
        private int GenerateId()
        {
            var rand = new Random();
            var output = 0;
            do
            {
                output = rand.Next(100000, 999999);
            } while (IdInUse.Contains(output));

            return output;
        }
        /// <summary>
        /// Возвращает и задаёт факультет из перечисления Faculty. 
        /// </summary>
        public Faculty Faculty
        {
            get
            {
                return _faculty;
            }
            set
            {
                _faculty = value;
            }
        }
        /// <summary>
        /// Возвращает и задаёт форму обучения из перечисления EducationForm. 
        /// </summary>
        public EducationForm EducationForm
        {
            get
            {
                return _educationForm;
            }
            set
            {
                _educationForm = value;
            }
        }
        /// <summary>
        /// Создаёт экзмепляр класса <see cref="Song"/>
        /// </summary>
        /// <param name="fullName">Полное имя.Не может бытьп пустым.</param>
        /// <param name="group">Группа. Не может быть пустым.</param>
        /// <param name="id">Уникальный id. Должно быть целым числом, больше 0. Не может быть пустым</param>
        /// <param name="faculty">Факультет. Должен быть выбран из перечисления Faculty.</param>
        /// <param name="educationForm">Форма обучения. Должен быть выбран из перечисления EducationForm.</param>
        public Student(string fullName, string group, int id, Faculty faculty, EducationForm educationForm)
        {
            FullName = fullName;
            Group = group;
            Id = id;
            Faculty = faculty;
            EducationForm = educationForm;
        }
        public Student() { }
    }
}
