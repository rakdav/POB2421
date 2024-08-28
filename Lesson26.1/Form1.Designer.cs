namespace Lesson26._1
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
            groupBox1 = new GroupBox();
            textBox20x30 = new TextBox();
            textBoxPrice3x4 = new TextBox();
            textBoxPrice10x12 = new TextBox();
            radioButton20x30 = new RadioButton();
            radioButton3x4 = new RadioButton();
            radioButton10x12 = new RadioButton();
            label1 = new Label();
            textBoxCount = new TextBox();
            buttonOk = new Button();
            labelResult = new Label();
            buttonCancel = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox20x30);
            groupBox1.Controls.Add(textBoxPrice3x4);
            groupBox1.Controls.Add(textBoxPrice10x12);
            groupBox1.Controls.Add(radioButton20x30);
            groupBox1.Controls.Add(radioButton3x4);
            groupBox1.Controls.Add(radioButton10x12);
            groupBox1.Location = new Point(16, 16);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(243, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Выберите формат";
            // 
            // textBox20x30
            // 
            textBox20x30.Enabled = false;
            textBox20x30.Location = new Point(97, 83);
            textBox20x30.Name = "textBox20x30";
            textBox20x30.Size = new Size(132, 27);
            textBox20x30.TabIndex = 5;
            // 
            // textBoxPrice3x4
            // 
            textBoxPrice3x4.Enabled = false;
            textBoxPrice3x4.Location = new Point(97, 55);
            textBoxPrice3x4.Name = "textBoxPrice3x4";
            textBoxPrice3x4.Size = new Size(132, 27);
            textBoxPrice3x4.TabIndex = 4;
            // 
            // textBoxPrice10x12
            // 
            textBoxPrice10x12.Location = new Point(97, 23);
            textBoxPrice10x12.Name = "textBoxPrice10x12";
            textBoxPrice10x12.Size = new Size(132, 27);
            textBoxPrice10x12.TabIndex = 3;
            // 
            // radioButton20x30
            // 
            radioButton20x30.AutoSize = true;
            radioButton20x30.Location = new Point(6, 86);
            radioButton20x30.Name = "radioButton20x30";
            radioButton20x30.Size = new Size(69, 24);
            radioButton20x30.TabIndex = 2;
            radioButton20x30.TabStop = true;
            radioButton20x30.Text = "20x30";
            radioButton20x30.UseVisualStyleBackColor = true;
            radioButton20x30.CheckedChanged += radioButton20x30_CheckedChanged;
            // 
            // radioButton3x4
            // 
            radioButton3x4.AutoSize = true;
            radioButton3x4.Location = new Point(6, 56);
            radioButton3x4.Name = "radioButton3x4";
            radioButton3x4.Size = new Size(53, 24);
            radioButton3x4.TabIndex = 1;
            radioButton3x4.TabStop = true;
            radioButton3x4.Text = "3x4";
            radioButton3x4.UseVisualStyleBackColor = true;
            radioButton3x4.CheckedChanged += radioButton3x4_CheckedChanged;
            // 
            // radioButton10x12
            // 
            radioButton10x12.AutoSize = true;
            radioButton10x12.Location = new Point(6, 26);
            radioButton10x12.Name = "radioButton10x12";
            radioButton10x12.Size = new Size(69, 24);
            radioButton10x12.TabIndex = 0;
            radioButton10x12.TabStop = true;
            radioButton10x12.Text = "10x12";
            radioButton10x12.UseVisualStyleBackColor = true;
            radioButton10x12.CheckedChanged += radioButton10x12_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 148);
            label1.Name = "label1";
            label1.Size = new Size(239, 20);
            label1.TabIndex = 1;
            label1.Text = "Укажите количество фотографий";
            // 
            // textBoxCount
            // 
            textBoxCount.Location = new Point(16, 171);
            textBoxCount.Name = "textBoxCount";
            textBoxCount.Size = new Size(240, 27);
            textBoxCount.TabIndex = 2;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(88, 219);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(94, 29);
            buttonOk.TabIndex = 3;
            buttonOk.Text = "Расчитать";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // labelResult
            // 
            labelResult.Location = new Point(277, 26);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(293, 172);
            labelResult.TabIndex = 4;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(380, 219);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(94, 29);
            buttonCancel.TabIndex = 5;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 260);
            Controls.Add(buttonCancel);
            Controls.Add(labelResult);
            Controls.Add(buttonOk);
            Controls.Add(textBoxCount);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Фотоателье";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton20x30;
        private RadioButton radioButton3x4;
        private RadioButton radioButton10x12;
        private TextBox textBox20x30;
        private TextBox textBoxPrice3x4;
        private TextBox textBoxPrice10x12;
        private Label label1;
        private TextBox textBoxCount;
        private Button buttonOk;
        private Label labelResult;
        private Button buttonCancel;
    }
}
