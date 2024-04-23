namespace Programmimg.View.Panels
{
    partial class RectanglesControl
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
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxRectangles
            // 
            this.listBoxRectangles.FormattingEnabled = true;
            this.listBoxRectangles.ItemHeight = 25;
            this.listBoxRectangles.Location = new System.Drawing.Point(26, 47);
            this.listBoxRectangles.Name = "listBoxRectangles";
            this.listBoxRectangles.Size = new System.Drawing.Size(310, 629);
            this.listBoxRectangles.TabIndex = 9;
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
            this.groupBox1.Location = new System.Drawing.Point(12, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(662, 787);
            this.groupBox1.TabIndex = 10;
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
            // 
            // textBoxWidth
            // 
            this.textBoxWidth.Location = new System.Drawing.Point(416, 266);
            this.textBoxWidth.Name = "textBoxWidth";
            this.textBoxWidth.Size = new System.Drawing.Size(165, 31);
            this.textBoxWidth.TabIndex = 4;
            this.textBoxWidth.TextChanged += new System.EventHandler(this.textBoxWidth_TextChanged_1);
           // this.textBoxWidth.VisibleChanged += new System.EventHandler(this.textBoxWidth_TextChanged);
            // 
            // Xlabel
            // 
            this.Xlabel.AutoSize = true;
            this.Xlabel.Location = new System.Drawing.Point(411, 454);
            this.Xlabel.Name = "Xlabel";
            this.Xlabel.Size = new System.Drawing.Size(165, 25);
            this.Xlabel.TabIndex = 8;
            this.Xlabel.Text = "X-cord of center";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(411, 346);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(63, 25);
            this.labelColor.TabIndex = 3;
            this.labelColor.Text = "Color";
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
            // 
            // labelLenght
            // 
            this.labelLenght.AutoSize = true;
            this.labelLenght.Location = new System.Drawing.Point(411, 135);
            this.labelLenght.Name = "labelLenght";
            this.labelLenght.Size = new System.Drawing.Size(78, 25);
            this.labelLenght.TabIndex = 1;
            this.labelLenght.Text = "Lenght";
            // 
            // RectanglesControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listBoxRectangles);
            this.Controls.Add(this.groupBox1);
            this.Name = "RectanglesControl";
            this.Size = new System.Drawing.Size(685, 819);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRectangles;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox idtxtbox;
        private System.Windows.Forms.Label idLabel;
        private System.Windows.Forms.TextBox ycentertxtbox;
        private System.Windows.Forms.Label YLabel;
        private System.Windows.Forms.TextBox textBoxLenght;
        private System.Windows.Forms.TextBox xcentertxtbox;
        private System.Windows.Forms.TextBox textBoxColor;
        private System.Windows.Forms.TextBox textBoxWidth;
        private System.Windows.Forms.Label Xlabel;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Label labelWidth;
        private System.Windows.Forms.Label labelLenght;
    }
}
