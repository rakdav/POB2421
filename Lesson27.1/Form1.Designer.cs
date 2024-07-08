namespace Lesson27._1
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
            panel1 = new Panel();
            checkBoxAll = new CheckBox();
            buttonOk = new Button();
            groupBox1 = new GroupBox();
            radioButtonLower = new RadioButton();
            radioButtonUpper = new RadioButton();
            textBoxSubString = new TextBox();
            checkBoxFind = new CheckBox();
            checkBoxCount = new CheckBox();
            textBoxInput = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            labelOutput = new Label();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(checkBoxAll);
            panel1.Controls.Add(buttonOk);
            panel1.Controls.Add(groupBox1);
            panel1.Controls.Add(textBoxInput);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(5);
            panel1.Name = "panel1";
            panel1.Size = new Size(449, 511);
            panel1.TabIndex = 0;
            // 
            // checkBoxAll
            // 
            checkBoxAll.AutoSize = true;
            checkBoxAll.Location = new Point(28, 163);
            checkBoxAll.Name = "checkBoxAll";
            checkBoxAll.Size = new Size(139, 29);
            checkBoxAll.TabIndex = 4;
            checkBoxAll.Text = "Выбрать все";
            checkBoxAll.UseVisualStyleBackColor = true;
            checkBoxAll.CheckedChanged += checkBoxAll_CheckedChanged;
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(136, 454);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(161, 45);
            buttonOk.TabIndex = 3;
            buttonOk.Text = "Выполнить";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonLower);
            groupBox1.Controls.Add(radioButtonUpper);
            groupBox1.Controls.Add(textBoxSubString);
            groupBox1.Controls.Add(checkBoxFind);
            groupBox1.Controls.Add(checkBoxCount);
            groupBox1.Location = new Point(17, 203);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(412, 230);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Методы";
            // 
            // radioButtonLower
            // 
            radioButtonLower.AutoSize = true;
            radioButtonLower.Location = new Point(11, 185);
            radioButtonLower.Name = "radioButtonLower";
            radioButtonLower.Size = new Size(173, 29);
            radioButtonLower.TabIndex = 4;
            radioButtonLower.TabStop = true;
            radioButtonLower.Text = "Нижний регистр";
            radioButtonLower.UseVisualStyleBackColor = true;
            // 
            // radioButtonUpper
            // 
            radioButtonUpper.AutoSize = true;
            radioButtonUpper.Location = new Point(11, 150);
            radioButtonUpper.Name = "radioButtonUpper";
            radioButtonUpper.Size = new Size(176, 29);
            radioButtonUpper.TabIndex = 3;
            radioButtonUpper.TabStop = true;
            radioButtonUpper.Text = "Верхний регистр";
            radioButtonUpper.UseVisualStyleBackColor = true;
            // 
            // textBoxSubString
            // 
            textBoxSubString.Location = new Point(11, 100);
            textBoxSubString.Name = "textBoxSubString";
            textBoxSubString.Size = new Size(382, 33);
            textBoxSubString.TabIndex = 2;
            // 
            // checkBoxFind
            // 
            checkBoxFind.AutoSize = true;
            checkBoxFind.Location = new Point(11, 65);
            checkBoxFind.Name = "checkBoxFind";
            checkBoxFind.Size = new Size(124, 29);
            checkBoxFind.TabIndex = 1;
            checkBoxFind.Text = "Подстрока";
            checkBoxFind.UseVisualStyleBackColor = true;
            checkBoxFind.CheckedChanged += checkBoxFind_CheckedChanged;
            // 
            // checkBoxCount
            // 
            checkBoxCount.AutoSize = true;
            checkBoxCount.Location = new Point(11, 30);
            checkBoxCount.Name = "checkBoxCount";
            checkBoxCount.Size = new Size(223, 29);
            checkBoxCount.TabIndex = 0;
            checkBoxCount.Text = "Количество символов";
            checkBoxCount.UseVisualStyleBackColor = true;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(17, 56);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(412, 101);
            textBoxInput.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(17, 18);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 0;
            label1.Text = "Введите строку";
            // 
            // panel2
            // 
            panel2.Controls.Add(labelOutput);
            panel2.Dock = DockStyle.Right;
            panel2.Location = new Point(459, 0);
            panel2.Margin = new Padding(5);
            panel2.Name = "panel2";
            panel2.Size = new Size(459, 511);
            panel2.TabIndex = 1;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Dock = DockStyle.Fill;
            labelOutput.Location = new Point(0, 0);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(0, 25);
            labelOutput.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(918, 511);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            MaximumSize = new Size(934, 550);
            MinimumSize = new Size(934, 550);
            Name = "Form1";
            Text = "Строковый анализатор";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox textBoxInput;
        private Button buttonOk;
        private TextBox textBoxSubString;
        private CheckBox checkBoxFind;
        private CheckBox checkBoxCount;
        private CheckBox checkBoxAll;
        private RadioButton radioButtonLower;
        private RadioButton radioButtonUpper;
        private Label labelOutput;
    }
}
