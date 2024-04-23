
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming.View.Panels
{
    public partial class EnumerationsControl : UserControl
    {
        public EnumerationsControl()
        {
            InitializeComponent();
        }
        private readonly Type[] _typeModel = new Type[]
        {
            typeof(Colour), typeof(EducationForm), typeof(Genre), typeof(Manufactures), typeof(Season),
            typeof(Weekday)
        };

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
            int selectedIndex = EnumsListBox.SelectedIndex;
            object[] values = Enum.GetValues(_typeModel[selectedIndex]).Cast<object>().ToArray();
            ValuesListBox.Items.Clear();
            ValuesListBox.Items.AddRange(values);
        }
        private void ValuesListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            IntTextBox.Text = ValuesListBox.SelectedIndex.ToString();
        }
    }
}
