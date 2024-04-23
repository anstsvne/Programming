namespace Programming.View.Panels
{
    partial class EnumerationsControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.ChooseEnumerationLabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.EnumerationGroupBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // IntTextBox
            // 
            this.IntTextBox.Location = new System.Drawing.Point(799, 122);
            this.IntTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IntTextBox.Name = "IntTextBox";
            this.IntTextBox.Size = new System.Drawing.Size(196, 31);
            this.IntTextBox.TabIndex = 19;
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(795, 82);
            this.IntValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(99, 25);
            this.IntValueLabel.TabIndex = 18;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ChooseValueLabel
            // 
            this.ChooseValueLabel.AutoSize = true;
            this.ChooseValueLabel.Location = new System.Drawing.Point(387, 82);
            this.ChooseValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChooseValueLabel.Name = "ChooseValueLabel";
            this.ChooseValueLabel.Size = new System.Drawing.Size(150, 25);
            this.ChooseValueLabel.TabIndex = 17;
            this.ChooseValueLabel.Text = "Choose value:";
            // 
            // ChooseEnumerationLabel
            // 
            this.ChooseEnumerationLabel.AutoSize = true;
            this.ChooseEnumerationLabel.Location = new System.Drawing.Point(43, 82);
            this.ChooseEnumerationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChooseEnumerationLabel.Name = "ChooseEnumerationLabel";
            this.ChooseEnumerationLabel.Size = new System.Drawing.Size(217, 25);
            this.ChooseEnumerationLabel.TabIndex = 16;
            this.ChooseEnumerationLabel.Text = "Choose enumeration:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 25;
            this.ValuesListBox.Location = new System.Drawing.Point(391, 122);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(322, 479);
            this.ValuesListBox.TabIndex = 15;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.ItemHeight = 25;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Colors",
            "EducationForm",
            "Genre",
            "Manufacturing",
            "Season",
            "Weekday"});
            this.EnumsListBox.Location = new System.Drawing.Point(47, 122);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(306, 479);
            this.EnumsListBox.TabIndex = 14;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // EnumerationGroupBox
            // 
            this.EnumerationGroupBox.Location = new System.Drawing.Point(19, 15);
            this.EnumerationGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.EnumerationGroupBox.Name = "EnumerationGroupBox";
            this.EnumerationGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.EnumerationGroupBox.Size = new System.Drawing.Size(1106, 631);
            this.EnumerationGroupBox.TabIndex = 20;
            this.EnumerationGroupBox.TabStop = false;
            this.EnumerationGroupBox.Text = "Enumeration";
            // 
            // EnumerationsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.IntTextBox);
            this.Controls.Add(this.IntValueLabel);
            this.Controls.Add(this.ChooseValueLabel);
            this.Controls.Add(this.ChooseEnumerationLabel);
            this.Controls.Add(this.ValuesListBox);
            this.Controls.Add(this.EnumsListBox);
            this.Controls.Add(this.EnumerationGroupBox);
            this.Name = "EnumerationsControl";
            this.Size = new System.Drawing.Size(1145, 666);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox IntTextBox;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.Label ChooseValueLabel;
        private System.Windows.Forms.Label ChooseEnumerationLabel;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.GroupBox EnumerationGroupBox;
    }
}
