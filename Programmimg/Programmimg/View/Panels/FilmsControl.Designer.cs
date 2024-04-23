namespace Programming.View.Panels
{
    partial class FilmsControl
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
            this.groupBoxMovies.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBoxMovies.Location = new System.Drawing.Point(23, 22);
            this.groupBoxMovies.Name = "groupBoxMovies";
            this.groupBoxMovies.Size = new System.Drawing.Size(695, 787);
            this.groupBoxMovies.TabIndex = 10;
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
            // FilmsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBoxMovies);
            this.Name = "FilmsControl";
            this.Size = new System.Drawing.Size(736, 828);
            this.groupBoxMovies.ResumeLayout(false);
            this.groupBoxMovies.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxMovies;
        private System.Windows.Forms.Button buttonFind1;
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
    }
}
