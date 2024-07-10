namespace Lesson29._6
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
            label1 = new Label();
            labelDistResult = new Label();
            comboBoxDist = new ComboBox();
            textBoxDist = new TextBox();
            groupBox2 = new GroupBox();
            label2 = new Label();
            labelTempResult = new Label();
            comboBoxTemp = new ComboBox();
            textBoxTemp = new TextBox();
            groupBox3 = new GroupBox();
            label3 = new Label();
            labelBarResult = new Label();
            comboBoxBar = new ComboBox();
            textBoxBar = new TextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(labelDistResult);
            groupBox1.Controls.Add(comboBoxDist);
            groupBox1.Controls.Add(textBoxDist);
            groupBox1.Location = new Point(13, 13);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(430, 125);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Растояние";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(191, 39);
            label1.Name = "label1";
            label1.Size = new Size(31, 20);
            label1.TabIndex = 3;
            label1.Text = "мм";
            // 
            // labelDistResult
            // 
            labelDistResult.Location = new Point(10, 72);
            labelDistResult.Name = "labelDistResult";
            labelDistResult.Size = new Size(401, 33);
            labelDistResult.TabIndex = 2;
            // 
            // comboBoxDist
            // 
            comboBoxDist.FormattingEnabled = true;
            comboBoxDist.Items.AddRange(new object[] { "сантиметры", "дециметры", "метры", "километры" });
            comboBoxDist.Location = new Point(260, 31);
            comboBoxDist.Name = "comboBoxDist";
            comboBoxDist.Size = new Size(151, 28);
            comboBoxDist.TabIndex = 1;
            comboBoxDist.SelectedIndexChanged += comboBoxDist_SelectedIndexChanged;
            // 
            // textBoxDist
            // 
            textBoxDist.Location = new Point(11, 31);
            textBoxDist.Name = "textBoxDist";
            textBoxDist.Size = new Size(174, 27);
            textBoxDist.TabIndex = 0;
            textBoxDist.TextChanged += textBoxDist_TextChanged;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(labelTempResult);
            groupBox2.Controls.Add(comboBoxTemp);
            groupBox2.Controls.Add(textBoxTemp);
            groupBox2.Location = new Point(13, 155);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(430, 125);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Температура";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(191, 38);
            label2.Name = "label2";
            label2.Size = new Size(68, 20);
            label2.TabIndex = 3;
            label2.Text = "Цельсия";
            // 
            // labelTempResult
            // 
            labelTempResult.Location = new Point(10, 72);
            labelTempResult.Name = "labelTempResult";
            labelTempResult.Size = new Size(401, 33);
            labelTempResult.TabIndex = 2;
            // 
            // comboBoxTemp
            // 
            comboBoxTemp.FormattingEnabled = true;
            comboBoxTemp.Items.AddRange(new object[] { "сантиметры", "дециметры", "метры", "километры" });
            comboBoxTemp.Location = new Point(260, 31);
            comboBoxTemp.Name = "comboBoxTemp";
            comboBoxTemp.Size = new Size(151, 28);
            comboBoxTemp.TabIndex = 1;
            // 
            // textBoxTemp
            // 
            textBoxTemp.Location = new Point(11, 31);
            textBoxTemp.Name = "textBoxTemp";
            textBoxTemp.Size = new Size(174, 27);
            textBoxTemp.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(labelBarResult);
            groupBox3.Controls.Add(comboBoxBar);
            groupBox3.Controls.Add(textBoxBar);
            groupBox3.Location = new Point(13, 286);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(430, 125);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Давление";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 38);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 3;
            label3.Text = "Паскаль";
            // 
            // labelBarResult
            // 
            labelBarResult.Location = new Point(10, 72);
            labelBarResult.Name = "labelBarResult";
            labelBarResult.Size = new Size(401, 33);
            labelBarResult.TabIndex = 2;
            // 
            // comboBoxBar
            // 
            comboBoxBar.FormattingEnabled = true;
            comboBoxBar.Items.AddRange(new object[] { "сантиметры", "дециметры", "метры", "километры" });
            comboBoxBar.Location = new Point(260, 31);
            comboBoxBar.Name = "comboBoxBar";
            comboBoxBar.Size = new Size(151, 28);
            comboBoxBar.TabIndex = 1;
            // 
            // textBoxBar
            // 
            textBoxBar.Location = new Point(11, 31);
            textBoxBar.Name = "textBoxBar";
            textBoxBar.Size = new Size(174, 27);
            textBoxBar.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(459, 427);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Преобразователь единиц измерения";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label labelDistResult;
        private ComboBox comboBoxDist;
        private TextBox textBoxDist;
        private GroupBox groupBox2;
        private Label labelTempResult;
        private ComboBox comboBoxTemp;
        private TextBox textBoxTemp;
        private GroupBox groupBox3;
        private Label labelBarResult;
        private ComboBox comboBoxBar;
        private TextBox textBoxBar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
