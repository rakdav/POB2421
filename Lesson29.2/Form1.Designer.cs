namespace Lesson29._2
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
            textBoxText = new TextBox();
            label1 = new Label();
            labelResult = new Label();
            groupBox1 = new GroupBox();
            radioButtonPolindrom = new RadioButton();
            radioButtonReverse = new RadioButton();
            groupBox3 = new GroupBox();
            radioButtonLower = new RadioButton();
            radioButtonUpper = new RadioButton();
            textBoxIndex = new TextBox();
            label2 = new Label();
            textBoxSearch = new TextBox();
            label3 = new Label();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxText
            // 
            textBoxText.Location = new Point(24, 45);
            textBoxText.Margin = new Padding(5);
            textBoxText.Multiline = true;
            textBoxText.Name = "textBoxText";
            textBoxText.Size = new Size(620, 89);
            textBoxText.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 15);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(144, 25);
            label1.TabIndex = 1;
            label1.Text = "Введите строку";
            // 
            // labelResult
            // 
            labelResult.Location = new Point(19, 147);
            labelResult.Margin = new Padding(5, 0, 5, 0);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(622, 127);
            labelResult.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButtonReverse);
            groupBox1.Controls.Add(radioButtonPolindrom);
            groupBox1.Location = new Point(19, 293);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(314, 110);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Проверка на полиндром";
            // 
            // radioButtonPolindrom
            // 
            radioButtonPolindrom.AutoSize = true;
            radioButtonPolindrom.Location = new Point(10, 32);
            radioButtonPolindrom.Margin = new Padding(5);
            radioButtonPolindrom.Name = "radioButtonPolindrom";
            radioButtonPolindrom.Size = new Size(141, 29);
            radioButtonPolindrom.TabIndex = 0;
            radioButtonPolindrom.TabStop = true;
            radioButtonPolindrom.Text = "Полиндром?";
            radioButtonPolindrom.UseVisualStyleBackColor = true;
            radioButtonPolindrom.CheckedChanged += radioButtonPolindrom_CheckedChanged;
            // 
            // radioButtonReverse
            // 
            radioButtonReverse.AutoSize = true;
            radioButtonReverse.Location = new Point(10, 71);
            radioButtonReverse.Margin = new Padding(5);
            radioButtonReverse.Name = "radioButtonReverse";
            radioButtonReverse.Size = new Size(124, 29);
            radioButtonReverse.TabIndex = 0;
            radioButtonReverse.TabStop = true;
            radioButtonReverse.Text = "Повернуть";
            radioButtonReverse.UseVisualStyleBackColor = true;
            radioButtonReverse.CheckedChanged += radioButtonReverse_CheckedChanged;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(radioButtonLower);
            groupBox3.Controls.Add(radioButtonUpper);
            groupBox3.Location = new Point(19, 417);
            groupBox3.Margin = new Padding(5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(5);
            groupBox3.Size = new Size(314, 138);
            groupBox3.TabIndex = 5;
            groupBox3.TabStop = false;
            groupBox3.Text = "Верний/Нижний";
            // 
            // radioButtonLower
            // 
            radioButtonLower.AutoSize = true;
            radioButtonLower.Location = new Point(9, 78);
            radioButtonLower.Margin = new Padding(5);
            radioButtonLower.Name = "radioButtonLower";
            radioButtonLower.Size = new Size(173, 29);
            radioButtonLower.TabIndex = 1;
            radioButtonLower.TabStop = true;
            radioButtonLower.Text = "Нижний регистр";
            radioButtonLower.UseVisualStyleBackColor = true;
            radioButtonLower.CheckedChanged += radioButtonLower_CheckedChanged;
            // 
            // radioButtonUpper
            // 
            radioButtonUpper.AutoSize = true;
            radioButtonUpper.Location = new Point(9, 37);
            radioButtonUpper.Margin = new Padding(5);
            radioButtonUpper.Name = "radioButtonUpper";
            radioButtonUpper.Size = new Size(176, 29);
            radioButtonUpper.TabIndex = 0;
            radioButtonUpper.TabStop = true;
            radioButtonUpper.Text = "Верхний регистр";
            radioButtonUpper.UseVisualStyleBackColor = true;
            radioButtonUpper.CheckedChanged += radioButtonUpper_CheckedChanged;
            // 
            // textBoxIndex
            // 
            textBoxIndex.Location = new Point(343, 452);
            textBoxIndex.Margin = new Padding(5);
            textBoxIndex.Name = "textBoxIndex";
            textBoxIndex.Size = new Size(296, 33);
            textBoxIndex.TabIndex = 6;
            textBoxIndex.TextChanged += textBoxIndex_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(343, 417);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(147, 25);
            label2.TabIndex = 7;
            label2.Text = "Введите индекс";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(19, 597);
            textBoxSearch.Margin = new Padding(5);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(620, 33);
            textBoxSearch.TabIndex = 8;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 567);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(239, 25);
            label3.TabIndex = 9;
            label3.Text = "Введите слово для поиска";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(665, 670);
            Controls.Add(label3);
            Controls.Add(textBoxSearch);
            Controls.Add(label2);
            Controls.Add(textBoxIndex);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Controls.Add(labelResult);
            Controls.Add(label1);
            Controls.Add(textBoxText);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "Form1";
            Text = "Тема 27. Задание 2.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxText;
        private Label label1;
        private Label labelResult;
        private GroupBox groupBox1;
        private RadioButton radioButtonPolindrom;
        private RadioButton radioButtonReverse;
        private GroupBox groupBox3;
        private RadioButton radioButtonLower;
        private RadioButton radioButtonUpper;
        private TextBox textBoxIndex;
        private Label label2;
        private TextBox textBoxSearch;
        private Label label3;
    }
}
