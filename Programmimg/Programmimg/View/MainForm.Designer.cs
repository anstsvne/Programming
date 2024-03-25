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
            this.GroupBoxSeasonHandle = new System.Windows.Forms.GroupBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.ChooseSeasonLabel = new System.Windows.Forms.Label();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.ParsedValueLabel = new System.Windows.Forms.Label();
            this.ParseButtonClick = new System.Windows.Forms.Button();
            this.ParsingTextBox = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.IntTextBox = new System.Windows.Forms.TextBox();
            this.IntValueLabel = new System.Windows.Forms.Label();
            this.ChooseValueLabel = new System.Windows.Forms.Label();
            this.ChooseEnumerationLabel = new System.Windows.Forms.Label();
            this.ValuesListBox = new System.Windows.Forms.ListBox();
            this.EnumsListBox = new System.Windows.Forms.ListBox();
            this.WeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.EnumerationGroupBox = new System.Windows.Forms.GroupBox();
            this.tabPageClasses = new System.Windows.Forms.TabPage();
            this.groupBoxMovies = new System.Windows.Forms.GroupBox();
            this.buttonFind1 = new System.Windows.Forms.Button();
            this.textBoxRating = new System.Windows.Forms.TextBox();
            this.labelRating = new System.Windows.Forms.Label();
            this.textBoxGenre = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textBoxDuration = new System.Windows.Forms.TextBox();
            this.labelDuration = new System.Windows.Forms.Label();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.listBoxMovie = new System.Windows.Forms.ListBox();
            this.listBoxRectangles = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.idtxtbox = new System.Windows.Forms.TextBox();
            this.idLabel = new System.Windows.Forms.Label();
            this.ycentertxtbox = new System.Windows.Forms.TextBox();
            this.YLabel = new System.Windows.Forms.Label();
            this.textBoxLenght = new System.Windows.Forms.TextBox();
            this.xcentertxtbox = new System.Windows.Forms.TextBox();
            this.textBoxColor = new System.Windows.Forms.TextBox();
            this.textBoxWidth = new System.Windows.Forms.TextBox();
            this.Xlabel = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.buttonFind = new System.Windows.Forms.Button();
            this.labelWidth = new System.Windows.Forms.Label();
            this.labelLenght = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.GroupBoxSeasonHandle.SuspendLayout();
            this.tabPageClasses.SuspendLayout();
            this.groupBoxMovies.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPageClasses);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1623, 1033);
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
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1607, 986);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Enums";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GroupBoxSeasonHandle
            // 
            this.GroupBoxSeasonHandle.Controls.Add(this.GoButton);
            this.GroupBoxSeasonHandle.Controls.Add(this.ChooseSeasonLabel);
            this.GroupBoxSeasonHandle.Controls.Add(this.SeasonComboBox);
            this.GroupBoxSeasonHandle.Location = new System.Drawing.Point(796, 652);
            this.GroupBoxSeasonHandle.Margin = new System.Windows.Forms.Padding(6);
            this.GroupBoxSeasonHandle.Name = "GroupBoxSeasonHandle";
            this.GroupBoxSeasonHandle.Padding = new System.Windows.Forms.Padding(6);
            this.GroupBoxSeasonHandle.Size = new System.Drawing.Size(712, 242);
            this.GroupBoxSeasonHandle.TabIndex = 14;
            this.GroupBoxSeasonHandle.TabStop = false;
            this.GroupBoxSeasonHandle.Text = "Season Handle";
            // 
            // GoButton
            // 
            this.GoButton.Location = new System.Drawing.Point(508, 102);
            this.GoButton.Margin = new System.Windows.Forms.Padding(6);
            this.GoButton.Name = "GoButton";
            this.GoButton.Size = new System.Drawing.Size(150, 44);
            this.GoButton.TabIndex = 2;
            this.GoButton.Text = "Go";
            this.GoButton.UseVisualStyleBackColor = true;
            this.GoButton.Click += new System.EventHandler(this.GoButton_Click_1);
            // 
            // ChooseSeasonLabel
            // 
            this.ChooseSeasonLabel.AutoSize = true;
            this.ChooseSeasonLabel.Location = new System.Drawing.Point(28, 60);
            this.ChooseSeasonLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ChooseSeasonLabel.Name = "ChooseSeasonLabel";
            this.ChooseSeasonLabel.Size = new System.Drawing.Size(168, 25);
            this.ChooseSeasonLabel.TabIndex = 1;
            this.ChooseSeasonLabel.Text = "Choose season:";
            // 
            // SeasonComboBox
            // 
            this.SeasonComboBox.FormattingEnabled = true;
            this.SeasonComboBox.Location = new System.Drawing.Point(32, 102);
            this.SeasonComboBox.Margin = new System.Windows.Forms.Padding(6);
            this.SeasonComboBox.Name = "SeasonComboBox";
            this.SeasonComboBox.Size = new System.Drawing.Size(426, 33);
            this.SeasonComboBox.TabIndex = 0;
            // 
            // ParsedValueLabel
            // 
            this.ParsedValueLabel.AutoSize = true;
            this.ParsedValueLabel.Location = new System.Drawing.Point(40, 819);
            this.ParsedValueLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ParsedValueLabel.Name = "ParsedValueLabel";
            this.ParsedValueLabel.Size = new System.Drawing.Size(0, 25);
            this.ParsedValueLabel.TabIndex = 11;
            // 
            // ParseButtonClick
            // 
            this.ParseButtonClick.Location = new System.Drawing.Point(522, 752);
            this.ParseButtonClick.Margin = new System.Windows.Forms.Padding(4);
            this.ParseButtonClick.Name = "ParseButtonClick";
            this.ParseButtonClick.Size = new System.Drawing.Size(112, 38);
            this.ParseButtonClick.TabIndex = 10;
            this.ParseButtonClick.Text = "Parse";
            this.ParseButtonClick.UseVisualStyleBackColor = true;
            this.ParseButtonClick.Click += new System.EventHandler(this.button1_Click);
            // 
            // ParsingTextBox
            // 
            this.ParsingTextBox.Location = new System.Drawing.Point(44, 752);
            this.ParsingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ParsingTextBox.Name = "ParsingTextBox";
            this.ParsingTextBox.Size = new System.Drawing.Size(426, 31);
            this.ParsingTextBox.TabIndex = 9;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(40, 712);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(232, 25);
            this.TypeLabel.TabIndex = 8;
            this.TypeLabel.Text = "Type value for parsing:";
            // 
            // IntTextBox
            // 
            this.IntTextBox.Location = new System.Drawing.Point(796, 117);
            this.IntTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.IntTextBox.Name = "IntTextBox";
            this.IntTextBox.Size = new System.Drawing.Size(196, 31);
            this.IntTextBox.TabIndex = 7;
            // 
            // IntValueLabel
            // 
            this.IntValueLabel.AutoSize = true;
            this.IntValueLabel.Location = new System.Drawing.Point(792, 77);
            this.IntValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IntValueLabel.Name = "IntValueLabel";
            this.IntValueLabel.Size = new System.Drawing.Size(99, 25);
            this.IntValueLabel.TabIndex = 6;
            this.IntValueLabel.Text = "Int value:";
            // 
            // ChooseValueLabel
            // 
            this.ChooseValueLabel.AutoSize = true;
            this.ChooseValueLabel.Location = new System.Drawing.Point(384, 77);
            this.ChooseValueLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChooseValueLabel.Name = "ChooseValueLabel";
            this.ChooseValueLabel.Size = new System.Drawing.Size(150, 25);
            this.ChooseValueLabel.TabIndex = 5;
            this.ChooseValueLabel.Text = "Choose value:";
            // 
            // ChooseEnumerationLabel
            // 
            this.ChooseEnumerationLabel.AutoSize = true;
            this.ChooseEnumerationLabel.Location = new System.Drawing.Point(40, 77);
            this.ChooseEnumerationLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ChooseEnumerationLabel.Name = "ChooseEnumerationLabel";
            this.ChooseEnumerationLabel.Size = new System.Drawing.Size(217, 25);
            this.ChooseEnumerationLabel.TabIndex = 4;
            this.ChooseEnumerationLabel.Text = "Choose enumeration:";
            // 
            // ValuesListBox
            // 
            this.ValuesListBox.FormattingEnabled = true;
            this.ValuesListBox.ItemHeight = 25;
            this.ValuesListBox.Location = new System.Drawing.Point(388, 117);
            this.ValuesListBox.Margin = new System.Windows.Forms.Padding(4);
            this.ValuesListBox.Name = "ValuesListBox";
            this.ValuesListBox.Size = new System.Drawing.Size(322, 479);
            this.ValuesListBox.TabIndex = 1;
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
            this.EnumsListBox.Location = new System.Drawing.Point(44, 117);
            this.EnumsListBox.Margin = new System.Windows.Forms.Padding(4);
            this.EnumsListBox.Name = "EnumsListBox";
            this.EnumsListBox.Size = new System.Drawing.Size(306, 479);
            this.EnumsListBox.TabIndex = 0;
            this.EnumsListBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Location = new System.Drawing.Point(16, 652);
            this.WeekdayGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.WeekdayGroupBox.Size = new System.Drawing.Size(698, 242);
            this.WeekdayGroupBox.TabIndex = 12;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // EnumerationGroupBox
            // 
            this.EnumerationGroupBox.Location = new System.Drawing.Point(16, 10);
            this.EnumerationGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.EnumerationGroupBox.Name = "EnumerationGroupBox";
            this.EnumerationGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.EnumerationGroupBox.Size = new System.Drawing.Size(1106, 631);
            this.EnumerationGroupBox.TabIndex = 13;
            this.EnumerationGroupBox.TabStop = false;
            this.EnumerationGroupBox.Text = "Enumeration";
            // 
            // tabPageClasses
            // 
            this.tabPageClasses.Controls.Add(this.groupBoxMovies);
            this.tabPageClasses.Controls.Add(this.listBoxRectangles);
            this.tabPageClasses.Controls.Add(this.groupBox1);
            this.tabPageClasses.Location = new System.Drawing.Point(8, 39);
            this.tabPageClasses.Name = "tabPageClasses";
            this.tabPageClasses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClasses.Size = new System.Drawing.Size(1607, 986);
            this.tabPageClasses.TabIndex = 2;
            this.tabPageClasses.Text = "Classes";
            this.tabPageClasses.UseVisualStyleBackColor = true;
            // 
            // groupBoxMovies
            // 
            this.groupBoxMovies.Controls.Add(this.buttonFind1);
            this.groupBoxMovies.Controls.Add(this.textBoxRating);
            this.groupBoxMovies.Controls.Add(this.labelRating);
            this.groupBoxMovies.Controls.Add(this.textBoxGenre);
            this.groupBoxMovies.Controls.Add(this.labelGenre);
            this.groupBoxMovies.Controls.Add(this.textBoxYear);
            this.groupBoxMovies.Controls.Add(this.labelYear);
            this.groupBoxMovies.Controls.Add(this.textBoxDuration);
            this.groupBoxMovies.Controls.Add(this.labelDuration);
            this.groupBoxMovies.Controls.Add(this.textBoxTitle);
            this.groupBoxMovies.Controls.Add(this.labelTitle);
            this.groupBoxMovies.Controls.Add(this.listBoxMovie);
            this.groupBoxMovies.Location = new System.Drawing.Point(778, 22);
            this.groupBoxMovies.Name = "groupBoxMovies";
            this.groupBoxMovies.Size = new System.Drawing.Size(695, 787);
            this.groupBoxMovies.TabIndex = 9;
            this.groupBoxMovies.TabStop = false;
            this.groupBoxMovies.Text = "Movies";
            // 
            // buttonFind1
            // 
            this.buttonFind1.Location = new System.Drawing.Point(447, 711);
            this.buttonFind1.Name = "buttonFind1";
            this.buttonFind1.Size = new System.Drawing.Size(161, 36);
            this.buttonFind1.TabIndex = 11;
            this.buttonFind1.Text = "Find";
            this.buttonFind1.UseVisualStyleBackColor = true;
            this.buttonFind1.Click += new System.EventHandler(this.buttonFind1_Click);
            // 
            // textBoxRating
            // 
            this.textBoxRating.Location = new System.Drawing.Point(447, 478);
            this.textBoxRating.Name = "textBoxRating";
            this.textBoxRating.Size = new System.Drawing.Size(161, 31);
            this.textBoxRating.TabIndex = 10;
            this.textBoxRating.TextChanged += new System.EventHandler(this.textBoxRating_TextChanged);
            // 
            // labelRating
            // 
            this.labelRating.AutoSize = true;
            this.labelRating.Location = new System.Drawing.Point(442, 450);
            this.labelRating.Name = "labelRating";
            this.labelRating.Size = new System.Drawing.Size(74, 25);
            this.labelRating.TabIndex = 9;
            this.labelRating.Text = "Rating";
            // 
            // textBoxGenre
            // 
            this.textBoxGenre.Location = new System.Drawing.Point(447, 379);
            this.textBoxGenre.Name = "textBoxGenre";
            this.textBoxGenre.Size = new System.Drawing.Size(161, 31);
            this.textBoxGenre.TabIndex = 8;
            this.textBoxGenre.TextChanged += new System.EventHandler(this.textBoxGenre_TextChanged);
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(442, 351);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(71, 25);
            this.labelGenre.TabIndex = 7;
            this.labelGenre.Text = "Genre";
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(447, 271);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(161, 31);
            this.textBoxYear.TabIndex = 6;
            this.textBoxYear.TextChanged += new System.EventHandler(this.textBoxYear_TextChanged);
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(442, 243);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(159, 25);
            this.labelYear.TabIndex = 5;
            this.labelYear.Text = "Year of release";
            // 
            // textBoxDuration
            // 
            this.textBoxDuration.Location = new System.Drawing.Point(447, 163);
            this.textBoxDuration.Name = "textBoxDuration";
            this.textBoxDuration.Size = new System.Drawing.Size(161, 31);
            this.textBoxDuration.TabIndex = 4;
            this.textBoxDuration.TextChanged += new System.EventHandler(this.textBoxDuration_TextChanged);
            // 
            // labelDuration
            // 
            this.labelDuration.AutoSize = true;
            this.labelDuration.Location = new System.Drawing.Point(442, 135);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(197, 25);
            this.labelDuration.TabIndex = 3;
            this.labelDuration.Text = "Duration in minutes";
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(447, 60);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(161, 31);
            this.textBoxTitle.TabIndex = 2;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(442, 32);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(53, 25);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "Title";
            // 
            // listBoxMovie
            // 
            this.listBoxMovie.FormattingEnabled = true;
            this.listBoxMovie.ItemHeight = 25;
            this.listBoxMovie.Location = new System.Drawing.Point(17, 32);
            this.listBoxMovie.Name = "listBoxMovie";
            this.listBoxMovie.Size = new System.Drawing.Size(331, 629);
            this.listBoxMovie.TabIndex = 0;
            this.listBoxMovie.SelectedIndexChanged += new System.EventHandler(this.listBoxMovie_SelectedIndexChanged);
            // 
            // listBoxRectangles
            // 
            this.listBoxRectangles.FormattingEnabled = true;
            this.listBoxRectangles.ItemHeight = 25;
            this.listBoxRectangles.Location = new System.Drawing.Point(31, 54);
            this.listBoxRectangles.Name = "listBoxRectangles";
            this.listBoxRectangles.Size = new System.Drawing.Size(310, 629);
            this.listBoxRectangles.TabIndex = 0;
            this.listBoxRectangles.SelectedIndexChanged += new System.EventHandler(this.listBoxRectangles_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.idtxtbox);
            this.groupBox1.Controls.Add(this.idLabel);
            this.groupBox1.Controls.Add(this.ycentertxtbox);
            this.groupBox1.Controls.Add(this.YLabel);
            this.groupBox1.Controls.Add(this.textBoxLenght);
            this.groupBox1.Controls.Add(this.xcentertxtbox);
            this.groupBox1.Controls.Add(this.textBoxColor);
            this.groupBox1.Controls.Add(this.textBoxWidth);
            this.groupBox1.Controls.Add(this.Xlabel);
            this.groupBox1.Controls.Add(this.labelColor);
            this.groupBox1.Controls.Add(this.buttonFind);
            this.groupBox1.Controls.Add(this.labelWidth);
            this.groupBox1.Controls.Add(this.labelLenght);
            this.groupBox1.Location = new System.Drawing.Point(17, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 787);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rectangles";
            // 
            // idtxtbox
            // 
            this.idtxtbox.Location = new System.Drawing.Point(416, 71);
            this.idtxtbox.Name = "idtxtbox";
            this.idtxtbox.ReadOnly = true;
            this.idtxtbox.Size = new System.Drawing.Size(165, 31);
            this.idtxtbox.TabIndex = 10;
            // 
            // idLabel
            // 
            this.idLabel.AutoSize = true;
            this.idLabel.Location = new System.Drawing.Point(411, 43);
            this.idLabel.Name = "idLabel";
            this.idLabel.Size = new System.Drawing.Size(35, 25);
            this.idLabel.TabIndex = 12;
            this.idLabel.Text = "Id:";
            // 
            // ycentertxtbox
            // 
            this.ycentertxtbox.Location = new System.Drawing.Point(416, 581);
            this.ycentertxtbox.Name = "ycentertxtbox";
            this.ycentertxtbox.ReadOnly = true;
            this.ycentertxtbox.Size = new System.Drawing.Size(165, 31);
            this.ycentertxtbox.TabIndex = 10;
            this.ycentertxtbox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // YLabel
            // 
            this.YLabel.AutoSize = true;
            this.YLabel.Location = new System.Drawing.Point(411, 553);
            this.YLabel.Name = "YLabel";
            this.YLabel.Size = new System.Drawing.Size(166, 25);
            this.YLabel.TabIndex = 11;
            this.YLabel.Text = "Y-cord of center";
            // 
            // textBoxLenght
            // 
            this.textBoxLenght.Location = new System.Drawing.Point(416, 163);
            this.textBoxLenght.Name = "textBoxLenght";
            this.textBoxLenght.Size = new System.Drawing.Size(165, 31);
            this.textBoxLenght.TabIndex = 6;
            this.textBoxLenght.TextChanged += new System.EventHandler(this.textBoxLenght_TextChanged);
            // 
            // xcentertxtbox
            // 
            this.xcentertxtbox.Location = new System.Drawing.Point(416, 482);
            this.xcentertxtbox.Name = "xcentertxtbox";
            this.xcentertxtbox.ReadOnly = true;
            this.xcentertxtbox.Size = new System.Drawing.Size(165, 31);
            this.xcentertxtbox.TabIndex = 10;
            // 
            // textBoxColor
            // 
            this.textBoxColor.Location = new System.Drawing.Point(416, 374);
            this.textBoxColor.Name = "textBoxColor";
            this.textBoxColor.Size = new System.Drawing.Size(165, 31);
            this.textBoxColor.TabIndex = 5;
            this.textBoxColor.TextChanged += new System.EventHandler(this.textBoxColor_TextChanged);
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(416, 266);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(165, 31);
            this.textBoxWidth.TabIndex = 4;
            this.textBoxWidth.TextChanged += new System.EventHandler(this.textBoxWidth_TextChanged);
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.Location = new System.Drawing.Point(411, 454);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(165, 25);
            this.Xlabel.TabIndex = 8;
            this.Xlabel.Text = "X-cord of center";
            this.Xlabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(411, 346);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(63, 25);
            this.labelColor.TabIndex = 3;
            this.labelColor.Text = "Color";
            this.labelColor.Click += new System.EventHandler(this.labelColor_Click);
            // 
            // buttonFind
            // 
            this.buttonFind.Location = new System.Drawing.Point(416, 711);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(165, 36);
            this.buttonFind.TabIndex = 7;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = true;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
            // 
            // labelWidth
            // 
            this.labelWidth.AutoSize = true;
            this.labelWidth.Location = new System.Drawing.Point(411, 238);
            this.labelWidth.Name = "labelWidth";
            this.labelWidth.Size = new System.Drawing.Size(67, 25);
            this.labelWidth.TabIndex = 2;
            this.labelWidth.Text = "Width";
            this.labelWidth.Click += new System.EventHandler(this.labelWidth_Click);
            // 
            // labelLenght
            // 
            this.labelLenght.AutoSize = true;
            this.labelLenght.Location = new System.Drawing.Point(411, 135);
            this.labelLenght.Name = "labelLenght";
            this.labelLenght.Size = new System.Drawing.Size(78, 25);
            this.labelLenght.TabIndex = 1;
            this.labelLenght.Text = "Lenght";
            this.labelLenght.Click += new System.EventHandler(this.labelLenght_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1623, 1033);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Programming Demo";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.GroupBoxSeasonHandle.ResumeLayout(false);
            this.GroupBoxSeasonHandle.PerformLayout();
            this.tabPageClasses.ResumeLayout(false);
            this.groupBoxMovies.ResumeLayout(false);
            this.groupBoxMovies.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TabPage tabPageClasses;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelLenght;
        private System.Windows.Forms.ListBox listBoxRectangles;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.TextBox textBoxLenght;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxMovies;
        private System.Windows.Forms.TextBox textBoxRating;
        private System.Windows.Forms.Label labelRating;
        private System.Windows.Forms.TextBox textBoxGenre;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.TextBox textBoxYear;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textBoxDuration;
        private System.Windows.Forms.Label labelDuration;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.ListBox listBoxMovie;
        private System.Windows.Forms.Button buttonFind1;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox ycentertxtbox;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.TextBox xcentertxtbox;
        private System.Windows.Forms.Label Xlabel;
        private System.Windows.Forms.TextBox idtxtbox;
    }
}

