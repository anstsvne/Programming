namespace Programming.View.Panels
{
    partial class SeasonControl
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
            this.GroupBoxSeasonHandle = new System.Windows.Forms.GroupBox();
            this.GoButton = new System.Windows.Forms.Button();
            this.ChooseSeasonLabel = new System.Windows.Forms.Label();
            this.SeasonComboBox = new System.Windows.Forms.ComboBox();
            this.GroupBoxSeasonHandle.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBoxSeasonHandle
            // 
            this.GroupBoxSeasonHandle.Controls.Add(this.GoButton);
            this.GroupBoxSeasonHandle.Controls.Add(this.ChooseSeasonLabel);
            this.GroupBoxSeasonHandle.Controls.Add(this.SeasonComboBox);
            this.GroupBoxSeasonHandle.Location = new System.Drawing.Point(15, 16);
            this.GroupBoxSeasonHandle.Margin = new System.Windows.Forms.Padding(6);
            this.GroupBoxSeasonHandle.Name = "GroupBoxSeasonHandle";
            this.GroupBoxSeasonHandle.Padding = new System.Windows.Forms.Padding(6);
            this.GroupBoxSeasonHandle.Size = new System.Drawing.Size(712, 242);
            this.GroupBoxSeasonHandle.TabIndex = 15;
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
            // SeasonControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GroupBoxSeasonHandle);
            this.Name = "SeasonControl";
            this.Size = new System.Drawing.Size(748, 275);
            this.GroupBoxSeasonHandle.ResumeLayout(false);
            this.GroupBoxSeasonHandle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBoxSeasonHandle;
        private System.Windows.Forms.Button GoButton;
        private System.Windows.Forms.Label ChooseSeasonLabel;
        private System.Windows.Forms.ComboBox SeasonComboBox;
    }
}
