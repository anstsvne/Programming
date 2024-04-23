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
            this.weekdaysControl1 = new Programmimg.View.Panels.WeekdaysControl();
            this.seasonControl1 = new Programming.View.Panels.SeasonControl();
            this.enumerationsControl1 = new Programming.View.Panels.EnumerationsControl();
            this.tabPageClasses = new System.Windows.Forms.TabPage();
            this.filmsControl1 = new Programming.View.Panels.FilmsControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rectanglesCollisionControl1 = new Programmimg.View.Panels.RectanglesCollisionControl();
            this.rectanglesControl1 = new Programmimg.View.Panels.RectanglesControl();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPageClasses.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPageClasses);
            this.tabControl1.Controls.Add(this.tabPage1);
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
            this.tabPage2.Controls.Add(this.weekdaysControl1);
            this.tabPage2.Controls.Add(this.seasonControl1);
            this.tabPage2.Controls.Add(this.enumerationsControl1);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1607, 986);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Enums";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // weekdaysControl1
            // 
            this.weekdaysControl1.Location = new System.Drawing.Point(37, 661);
            this.weekdaysControl1.Name = "weekdaysControl1";
            this.weekdaysControl1.Size = new System.Drawing.Size(741, 304);
            this.weekdaysControl1.TabIndex = 17;
            // 
            // seasonControl1
            // 
            this.seasonControl1.Location = new System.Drawing.Point(784, 672);
            this.seasonControl1.Name = "seasonControl1";
            this.seasonControl1.Size = new System.Drawing.Size(752, 281);
            this.seasonControl1.TabIndex = 16;
            // 
            // enumerationsControl1
            // 
            this.enumerationsControl1.Location = new System.Drawing.Point(16, 26);
            this.enumerationsControl1.Name = "enumerationsControl1";
            this.enumerationsControl1.Size = new System.Drawing.Size(1049, 617);
            this.enumerationsControl1.TabIndex = 15;
            // 
            // tabPageClasses
            // 
            this.tabPageClasses.Controls.Add(this.rectanglesControl1);
            this.tabPageClasses.Controls.Add(this.filmsControl1);
            this.tabPageClasses.Location = new System.Drawing.Point(8, 39);
            this.tabPageClasses.Name = "tabPageClasses";
            this.tabPageClasses.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClasses.Size = new System.Drawing.Size(1607, 986);
            this.tabPageClasses.TabIndex = 2;
            this.tabPageClasses.Text = "Classes";
            this.tabPageClasses.UseVisualStyleBackColor = true;
            // 
            // filmsControl1
            // 
            this.filmsControl1.Location = new System.Drawing.Point(794, 22);
            this.filmsControl1.Name = "filmsControl1";
            this.filmsControl1.Size = new System.Drawing.Size(713, 774);
            this.filmsControl1.TabIndex = 9;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rectanglesCollisionControl1);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1607, 986);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Rectangle";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rectanglesCollisionControl1
            // 
            this.rectanglesCollisionControl1.Location = new System.Drawing.Point(0, 1);
            this.rectanglesCollisionControl1.Name = "rectanglesCollisionControl1";
            this.rectanglesCollisionControl1.Size = new System.Drawing.Size(1614, 992);
            this.rectanglesCollisionControl1.TabIndex = 0;
            // 
            // rectanglesControl1
            // 
            this.rectanglesControl1.Location = new System.Drawing.Point(25, 23);
            this.rectanglesControl1.Name = "rectanglesControl1";
            this.rectanglesControl1.Size = new System.Drawing.Size(720, 847);
            this.rectanglesControl1.TabIndex = 10;
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
            this.tabPageClasses.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPageClasses;
        private System.Windows.Forms.TabPage tabPage1;
        private View.Panels.RectanglesCollisionControl rectanglesCollisionControl1;
        private Programming.View.Panels.SeasonControl seasonControl1;
        private Programming.View.Panels.EnumerationsControl enumerationsControl1;
        private Programming.View.Panels.FilmsControl filmsControl1;
        private View.Panels.WeekdaysControl weekdaysControl1;
        private View.Panels.RectanglesControl rectanglesControl1;
    }
}

