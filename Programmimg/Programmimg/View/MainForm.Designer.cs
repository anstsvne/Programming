namespace Programmimg
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ParseButtonClick = new System.Windows.Forms.Button();
            this.ParsingTextBox = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.ChooseEnumerationLabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.ParsedValueLabel = new System.Windows.Forms.Label();
            this.WeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumerationGroupBox = new System.Windows.Forms.GroupBox();
            this.GroupBoxSeasonHandle = new System.Windows.Forms.GroupBox();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.ChooseSeasonLabel = new System.Windows.Forms.Label();
            this.GoButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.GroupBoxSeasonHandle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(770, 510);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.GroupBoxSeasonHandle);
            this.tabPage2.Controls.Add(this.ParsedValueLabel);
            this.tabPage2.Controls.Add(this.ParseButtonClick);
            this.tabPage2.Controls.Add(this.ParsingTextBox);
            this.tabPage2.Controls.Add(this.TypeLabel);
            this.tabPage2.Controls.Add(this.IntTextBox);
            this.tabPage2.Controls.Add(this.IntValueLabel);
            this.tabPage2.Controls.Add(this.ChooseValueLabel);
            this.tabPage2.Controls.Add(this.ChooseEnumerationLabel);
            this.tabPage2.Controls.Add(this.ValuesListBox);
            this.tabPage2.Controls.Add(this.EnumsListBox);
            this.tabPage2.Controls.Add(this.WeekdayGroupBox);
            this.tabPage2.Controls.Add(this.EnumerationGroupBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(762, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Enums";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // ParseButtonClick
            // 
            this.ParseButtonClick.Location = new System.Drawing.Point(261, 391);
            this.ParseButtonClick.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ParseButtonClick.Name = "ParseButtonClick";
            this.ParseButtonClick.Size = new System.Drawing.Size(56, 20);
            this.ParseButtonClick.TabIndex = 10;
            this.ParseButtonClick.Text = "Parse";
            this.ParseButtonClick.UseVisualStyleBackColor = true;
            this.ParseButtonClick.Click += new System.EventHandler(this.button1_Click);
            // 
            // ParsingTextBox
            // 
            this.ParsingTextBox.Location = new System.Drawing.Point(22, 391);
            this.ParsingTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ParsingTextBox.Name = "ParsingTextBox";
            this.ParsingTextBox.Size = new System.Drawing.Size(215, 20);
            this.ParsingTextBox.TabIndex = 9;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(20, 370);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(115, 13);
            this.TypeLabel.TabIndex = 8;
            this.TypeLabel.Text = "Type value for parsing:";
            // 
            // IntTextBox
            // 
            this.IntTextBox.Location = new System.Drawing.Point(398, 61);
            this.IntTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IntTextBox.Name = "IntTextBox";
            this.IntTextBox.Size = new System.Drawing.Size(100, 20);
            this.IntTextBox.TabIndex = 7;
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(396, 40);
            this.IntValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(51, 13);
            this.IntValueLabel.TabIndex = 6;
            this.IntValueLabel.Text = "Int value:";
            this.IntValueLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // ChooseValueLabel
            // 
            this.ChooseValueLabel.AutoSize = true;
            this.ChooseValueLabel.Location = new System.Drawing.Point(192, 40);
            this.ChooseValueLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChooseValueLabel.Name = "ChooseValueLabel";
            this.ChooseValueLabel.Size = new System.Drawing.Size(75, 13);
            this.ChooseValueLabel.TabIndex = 5;
            this.ChooseValueLabel.Text = "Choose value:";
            // 
            // ChooseEnumerationLabel
            // 
            this.ChooseEnumerationLabel.AutoSize = true;
            this.ChooseEnumerationLabel.Location = new System.Drawing.Point(20, 40);
            this.ChooseEnumerationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ChooseEnumerationLabel.Name = "ChooseEnumerationLabel";
            this.ChooseEnumerationLabel.Size = new System.Drawing.Size(107, 13);
            this.ChooseEnumerationLabel.TabIndex = 4;
            this.ChooseEnumerationLabel.Text = "Choose enumeration:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.Location = new System.Drawing.Point(194, 61);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(163, 251);
            this.ValuesListBox.TabIndex = 1;
            this.ValuesListBox.SelectedIndexChanged += new System.EventHandler(this.ValuesListBox_SelectedIndexChanged);
            // 
            // EnumsListBox
            // 
            this.EnumsListBox.FormattingEnabled = true;
            this.EnumsListBox.Items.AddRange(new object[] {
            "Colors",
            "EducationForm",
            "Genre",
            "Manufacturing",
            "Season",
            "Weekday"});
            this.EnumsListBox.Location = new System.Drawing.Point(22, 61);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(155, 251);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // ParsedValueLabel
            // 
            this.ParsedValueLabel.AutoSize = true;
            this.ParsedValueLabel.Location = new System.Drawing.Point(20, 426);
            this.ParsedValueLabel.Name = "ParsedValueLabel";
            this.ParsedValueLabel.Size = new System.Drawing.Size(0, 13);
            this.ParsedValueLabel.TabIndex = 11;
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Location = new System.Drawing.Point(8, 339);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Size = new System.Drawing.Size(349, 126);
            this.WeekdayGroupBox.TabIndex = 12;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // EnumerationGroupBox
            // 
            this.EnumerationGroupBox.Location = new System.Drawing.Point(8, 5);
            this.EnumerationGroupBox.Name = "EnumerationGroupBox";
            this.EnumerationGroupBox.Size = new System.Drawing.Size(553, 328);
            this.EnumerationGroupBox.TabIndex = 13;
            this.EnumerationGroupBox.TabStop = false;
            this.EnumerationGroupBox.Text = "Enumeration";
            // 
            // GroupBoxSeasonHandle
            // 
            this.GroupBoxSeasonHandle.Controls.Add(this.GoButton);
            this.GroupBoxSeasonHandle.Controls.Add(this.ChooseSeasonLabel);
            this.GroupBoxSeasonHandle.Controls.Add(this.SeasonComboBox);
            this.GroupBoxSeasonHandle.Location = new System.Drawing.Point(398, 339);
            this.GroupBoxSeasonHandle.Name = "GroupBoxSeasonHandle";
            this.GroupBoxSeasonHandle.Size = new System.Drawing.Size(356, 126);
            this.GroupBoxSeasonHandle.TabIndex = 14;
            this.GroupBoxSeasonHandle.TabStop = false;
            this.GroupBoxSeasonHandle.Text = "Season Handle";
            this.GroupBoxSeasonHandle.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(16, 53);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(215, 21);
            this.SeasonComboBox.TabIndex = 0;
            this.SeasonComboBox.SelectedIndexChanged += new System.EventHandler(this.SeasonComboBox_SelectedIndexChanged);
            // 
            // ChooseSeasonLabel
            // 
            this.ChooseSeasonLabel.AutoSize = true;
            this.ChooseSeasonLabel.Location = new System.Drawing.Point(14, 31);
            this.ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            this.ChooseSeasonLabel.Size = new System.Drawing.Size(83, 13);
            this.ChooseSeasonLabel.TabIndex = 1;
            this.ChooseSeasonLabel.Text = "Choose season:";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(254, 53);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(75, 23);
            this.GoButton.TabIndex = 2;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 510);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.GroupBoxSeasonHandle.ResumeLayout(false);
            this.GroupBoxSeasonHandle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox EnumsListBox;
        private System.Windows.Forms.ListBox ValuesListBox;
        private System.Windows.Forms.Label ChooseEnumerationLabel;
        private System.Windows.Forms.Label IntValueLabel;
        private System.Windows.Forms.Label ChooseValueLabel;
        private System.Windows.Forms.TextBox IntTextBox;
        private System.Windows.Forms.TextBox ParsingTextBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.Button ParseButtonClick;
        private System.Windows.Forms.Label ParsedValueLabel;
        private System.Windows.Forms.GroupBox GroupBoxSeasonHandle;
        private System.Windows.Forms.GroupBox WeekdayGroupBox;
        private System.Windows.Forms.GroupBox EnumerationGroupBox;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Label ChooseSeasonLabel;
        private System.Windows.Forms.ComboBox SeasonComboBox;
    }
}

