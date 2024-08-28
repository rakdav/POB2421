namespace Lesson29._5
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
            label1 = new Label();
            textBoxResult = new TextBox();
            label2 = new Label();
            textBoxFrom = new TextBox();
            label3 = new Label();
            textBoxTo = new TextBox();
            buttonGen = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 19);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(191, 25);
            label1.TabIndex = 0;
            label1.Text = "Случайное число:";
            // 
            // textBoxResult
            // 
            textBoxResult.Enabled = false;
            textBoxResult.Location = new Point(28, 54);
            textBoxResult.Margin = new Padding(4, 6, 4, 6);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.Size = new Size(434, 31);
            textBoxResult.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 92);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(44, 25);
            label2.TabIndex = 2;
            label2.Text = "От:";
            // 
            // textBoxFrom
            // 
            textBoxFrom.Location = new Point(28, 121);
            textBoxFrom.Margin = new Padding(4, 6, 4, 6);
            textBoxFrom.Name = "textBoxFrom";
            textBoxFrom.Size = new Size(168, 31);
            textBoxFrom.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(236, 92);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 25);
            label3.TabIndex = 4;
            label3.Text = "До:";
            // 
            // textBoxTo
            // 
            textBoxTo.Location = new Point(236, 121);
            textBoxTo.Margin = new Padding(4, 6, 4, 6);
            textBoxTo.Name = "textBoxTo";
            textBoxTo.Size = new Size(228, 31);
            textBoxTo.TabIndex = 5;
            // 
            // buttonGen
            // 
            buttonGen.Location = new Point(28, 175);
            buttonGen.Margin = new Padding(4, 6, 4, 6);
            buttonGen.Name = "buttonGen";
            buttonGen.Size = new Size(436, 38);
            buttonGen.TabIndex = 6;
            buttonGen.Text = "Сгенерировать";
            buttonGen.UseVisualStyleBackColor = true;
            buttonGen.Click += buttonGen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 231);
            Controls.Add(buttonGen);
            Controls.Add(textBoxTo);
            Controls.Add(label3);
            Controls.Add(textBoxFrom);
            Controls.Add(label2);
            Controls.Add(textBoxResult);
            Controls.Add(label1);
            Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(4, 6, 4, 6);
            Name = "Form1";
            Text = "Тема 28. Задание 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxResult;
        private Label label2;
        private TextBox textBoxFrom;
        private Label label3;
        private TextBox textBoxTo;
        private Button buttonGen;
    }
}
