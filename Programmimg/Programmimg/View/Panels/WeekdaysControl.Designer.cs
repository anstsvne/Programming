namespace Programmimg.View.Panels
{
    partial class WeekdaysControl
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
            this.ParsedValueLabel = new System.Windows.Forms.Label();
            this.ParseButtonClick = new System.Windows.Forms.Button();
            this.ParsingTextBox = new System.Windows.Forms.TextBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.WeekdayGroupBox = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // ParsedValueLabel
            // 
            this.ParsedValueLabel.AutoSize = true;
            this.ParsedValueLabel.Location = new System.Drawing.Point(42, 194);
            this.ParsedValueLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.ParsedValueLabel.Name = "ParsedValueLabel";
            this.ParsedValueLabel.Size = new System.Drawing.Size(0, 25);
            this.ParsedValueLabel.TabIndex = 16;
            // 
            // ParseButtonClick
            // 
            this.ParseButtonClick.Location = new System.Drawing.Point(524, 127);
            this.ParseButtonClick.Margin = new System.Windows.Forms.Padding(4);
            this.ParseButtonClick.Name = "ParseButtonClick";
            this.ParseButtonClick.Size = new System.Drawing.Size(112, 38);
            this.ParseButtonClick.TabIndex = 15;
            this.ParseButtonClick.Text = "Parse";
            this.ParseButtonClick.UseVisualStyleBackColor = true;
            this.ParseButtonClick.Click += new System.EventHandler(this.button1_Click);
            // 
            // ParsingTextBox
            // 
            this.ParsingTextBox.Location = new System.Drawing.Point(46, 127);
            this.ParsingTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.ParsingTextBox.Name = "ParsingTextBox";
            this.ParsingTextBox.Size = new System.Drawing.Size(426, 31);
            this.ParsingTextBox.TabIndex = 14;
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.Location = new System.Drawing.Point(42, 87);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(232, 25);
            this.TypeLabel.TabIndex = 13;
            this.TypeLabel.Text = "Type value for parsing:";
            // 
            // WeekdayGroupBox
            // 
            this.WeekdayGroupBox.Location = new System.Drawing.Point(18, 27);
            this.WeekdayGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.WeekdayGroupBox.Name = "WeekdayGroupBox";
            this.WeekdayGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.WeekdayGroupBox.Size = new System.Drawing.Size(698, 242);
            this.WeekdayGroupBox.TabIndex = 17;
            this.WeekdayGroupBox.TabStop = false;
            this.WeekdayGroupBox.Text = "Weekday Parsing";
            // 
            // WeekdaysControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ParsedValueLabel);
            this.Controls.Add(this.ParseButtonClick);
            this.Controls.Add(this.ParsingTextBox);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.WeekdayGroupBox);
            this.Name = "WeekdaysControl";
            this.Size = new System.Drawing.Size(739, 290);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ParsedValueLabel;
        private System.Windows.Forms.Button ParseButtonClick;
        private System.Windows.Forms.TextBox ParsingTextBox;
        private System.Windows.Forms.Label TypeLabel;
        private System.Windows.Forms.GroupBox WeekdayGroupBox;
    }
}
