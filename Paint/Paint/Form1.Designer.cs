namespace Paint
{
    partial class Form1
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ColorPanel = new System.Windows.Forms.Panel();
            this.ColorButton = new System.Windows.Forms.Button();
            this.WidthPanel = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.WTFButton = new System.Windows.Forms.RadioButton();
            this.EllipseButton = new System.Windows.Forms.RadioButton();
            this.RectButton = new System.Windows.Forms.RadioButton();
            this.BrushButton = new System.Windows.Forms.RadioButton();
            this.ClearButton = new System.Windows.Forms.Button();
            this.ColorsGroupBox = new System.Windows.Forms.GroupBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.BlackButton = new System.Windows.Forms.RadioButton();
            this.GreenButton = new System.Windows.Forms.RadioButton();
            this.BlueButton = new System.Windows.Forms.RadioButton();
            this.RedButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthPanel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.ColorsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(706, 590);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // ColorPanel
            // 
            this.ColorPanel.Location = new System.Drawing.Point(725, 12);
            this.ColorPanel.Name = "ColorPanel";
            this.ColorPanel.Size = new System.Drawing.Size(83, 83);
            this.ColorPanel.TabIndex = 1;
            // 
            // ColorButton
            // 
            this.ColorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ColorButton.Location = new System.Drawing.Point(815, 13);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(191, 82);
            this.ColorButton.TabIndex = 2;
            this.ColorButton.Text = "Color";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // WidthPanel
            // 
            this.WidthPanel.Location = new System.Drawing.Point(725, 130);
            this.WidthPanel.Name = "WidthPanel";
            this.WidthPanel.Size = new System.Drawing.Size(281, 20);
            this.WidthPanel.TabIndex = 3;
            this.WidthPanel.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.WidthPanel.ValueChanged += new System.EventHandler(this.WidthPanel_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(720, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Width";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WTFButton);
            this.groupBox1.Controls.Add(this.EllipseButton);
            this.groupBox1.Controls.Add(this.RectButton);
            this.groupBox1.Controls.Add(this.BrushButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(725, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(281, 157);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tool";
            // 
            // WTFButton
            // 
            this.WTFButton.AutoSize = true;
            this.WTFButton.Location = new System.Drawing.Point(6, 116);
            this.WTFButton.Name = "WTFButton";
            this.WTFButton.Size = new System.Drawing.Size(61, 24);
            this.WTFButton.TabIndex = 3;
            this.WTFButton.Text = "WTF";
            this.WTFButton.UseVisualStyleBackColor = true;
            this.WTFButton.CheckedChanged += new System.EventHandler(this.WTFButton_CheckedChanged);
            // 
            // EllipseButton
            // 
            this.EllipseButton.AutoSize = true;
            this.EllipseButton.Location = new System.Drawing.Point(5, 86);
            this.EllipseButton.Name = "EllipseButton";
            this.EllipseButton.Size = new System.Drawing.Size(73, 24);
            this.EllipseButton.TabIndex = 2;
            this.EllipseButton.Text = "Ellipse";
            this.EllipseButton.UseVisualStyleBackColor = true;
            this.EllipseButton.CheckedChanged += new System.EventHandler(this.EllipseButton_CheckedChanged);
            // 
            // RectButton
            // 
            this.RectButton.AutoSize = true;
            this.RectButton.Location = new System.Drawing.Point(5, 56);
            this.RectButton.Name = "RectButton";
            this.RectButton.Size = new System.Drawing.Size(100, 24);
            this.RectButton.TabIndex = 1;
            this.RectButton.Text = "Rectangle";
            this.RectButton.UseVisualStyleBackColor = true;
            this.RectButton.CheckedChanged += new System.EventHandler(this.RectButton_CheckedChanged);
            // 
            // BrushButton
            // 
            this.BrushButton.AutoSize = true;
            this.BrushButton.Checked = true;
            this.BrushButton.Location = new System.Drawing.Point(7, 26);
            this.BrushButton.Name = "BrushButton";
            this.BrushButton.Size = new System.Drawing.Size(69, 24);
            this.BrushButton.TabIndex = 0;
            this.BrushButton.TabStop = true;
            this.BrushButton.Text = "Brush";
            this.BrushButton.UseVisualStyleBackColor = true;
            this.BrushButton.CheckedChanged += new System.EventHandler(this.BrushButton_CheckedChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearButton.Location = new System.Drawing.Point(725, 539);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(281, 63);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ColorsGroupBox
            // 
            this.ColorsGroupBox.Controls.Add(this.SubmitButton);
            this.ColorsGroupBox.Controls.Add(this.BlackButton);
            this.ColorsGroupBox.Controls.Add(this.GreenButton);
            this.ColorsGroupBox.Controls.Add(this.BlueButton);
            this.ColorsGroupBox.Controls.Add(this.RedButton);
            this.ColorsGroupBox.Location = new System.Drawing.Point(725, 12);
            this.ColorsGroupBox.Name = "ColorsGroupBox";
            this.ColorsGroupBox.Size = new System.Drawing.Size(281, 138);
            this.ColorsGroupBox.TabIndex = 9;
            this.ColorsGroupBox.TabStop = false;
            this.ColorsGroupBox.Text = "Colors";
            this.ColorsGroupBox.Visible = false;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubmitButton.Location = new System.Drawing.Point(82, 32);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(192, 87);
            this.SubmitButton.TabIndex = 4;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // BlackButton
            // 
            this.BlackButton.AutoSize = true;
            this.BlackButton.Checked = true;
            this.BlackButton.Location = new System.Drawing.Point(7, 102);
            this.BlackButton.Name = "BlackButton";
            this.BlackButton.Size = new System.Drawing.Size(52, 17);
            this.BlackButton.TabIndex = 3;
            this.BlackButton.TabStop = true;
            this.BlackButton.Text = "Black";
            this.BlackButton.UseVisualStyleBackColor = true;
            // 
            // GreenButton
            // 
            this.GreenButton.AutoSize = true;
            this.GreenButton.Location = new System.Drawing.Point(7, 78);
            this.GreenButton.Name = "GreenButton";
            this.GreenButton.Size = new System.Drawing.Size(54, 17);
            this.GreenButton.TabIndex = 2;
            this.GreenButton.Text = "Green";
            this.GreenButton.UseVisualStyleBackColor = true;
            // 
            // BlueButton
            // 
            this.BlueButton.AutoSize = true;
            this.BlueButton.Location = new System.Drawing.Point(7, 55);
            this.BlueButton.Name = "BlueButton";
            this.BlueButton.Size = new System.Drawing.Size(46, 17);
            this.BlueButton.TabIndex = 1;
            this.BlueButton.Text = "Blue";
            this.BlueButton.UseVisualStyleBackColor = true;
            // 
            // RedButton
            // 
            this.RedButton.AutoSize = true;
            this.RedButton.Location = new System.Drawing.Point(7, 32);
            this.RedButton.Name = "RedButton";
            this.RedButton.Size = new System.Drawing.Size(45, 17);
            this.RedButton.TabIndex = 0;
            this.RedButton.Text = "Red";
            this.RedButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 614);
            this.Controls.Add(this.ColorsGroupBox);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WidthPanel);
            this.Controls.Add(this.ColorButton);
            this.Controls.Add(this.ColorPanel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Drawing Application";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WidthPanel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ColorsGroupBox.ResumeLayout(false);
            this.ColorsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel ColorPanel;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.NumericUpDown WidthPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton EllipseButton;
        private System.Windows.Forms.RadioButton RectButton;
        private System.Windows.Forms.RadioButton BrushButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.RadioButton WTFButton;
        private System.Windows.Forms.GroupBox ColorsGroupBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.RadioButton BlackButton;
        private System.Windows.Forms.RadioButton GreenButton;
        private System.Windows.Forms.RadioButton BlueButton;
        private System.Windows.Forms.RadioButton RedButton;
    }
}

