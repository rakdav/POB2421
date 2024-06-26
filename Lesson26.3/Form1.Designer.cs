namespace Lesson26._3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBox1 = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            textBoxWidth = new TextBox();
            label3 = new Label();
            textBoxHeight = new TextBox();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            labelResult = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Деревянные", "Алюминиевые", "Пластиковые", "Бумажные" });
            comboBox1.Location = new Point(14, 32);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(241, 28);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(153, 20);
            label1.TabIndex = 1;
            label1.Text = "Выберите материал ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(124, 20);
            label2.TabIndex = 2;
            label2.Text = "Введите ширину";
            // 
            // textBoxWidth
            // 
            textBoxWidth.Location = new Point(12, 86);
            textBoxWidth.Name = "textBoxWidth";
            textBoxWidth.Size = new Size(241, 27);
            textBoxWidth.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 116);
            label3.Name = "label3";
            label3.Size = new Size(117, 20);
            label3.TabIndex = 4;
            label3.Text = "Введите высоту";
            // 
            // textBoxHeight
            // 
            textBoxHeight.Location = new Point(14, 139);
            textBoxHeight.Name = "textBoxHeight";
            textBoxHeight.Size = new Size(241, 27);
            textBoxHeight.TabIndex = 5;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.paper;
            pictureBox1.Location = new Point(275, 26);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 266);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(275, 298);
            button1.Name = "button1";
            button1.Size = new Size(229, 29);
            button1.TabIndex = 7;
            button1.Text = "Расчитать";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelResult
            // 
            labelResult.Location = new Point(12, 181);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(243, 146);
            labelResult.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 338);
            Controls.Add(labelResult);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxHeight);
            Controls.Add(label3);
            Controls.Add(textBoxWidth);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Жалюзи";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private Label label2;
        private TextBox textBoxWidth;
        private Label label3;
        private TextBox textBoxHeight;
        private PictureBox pictureBox1;
        private Button button1;
        private Label labelResult;
    }
}
