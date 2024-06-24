namespace Lesson25
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
            textBoxFirstVar = new TextBox();
            label2 = new Label();
            textBoxSecondVar = new TextBox();
            buttonAdd = new Button();
            buttonSub = new Button();
            buttonMult = new Button();
            buttonDiv = new Button();
            labelResult = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 14);
            label1.Name = "label1";
            label1.Size = new Size(165, 20);
            label1.TabIndex = 0;
            label1.Text = "Введите первое число";
            // 
            // textBoxFirstVar
            // 
            textBoxFirstVar.Location = new Point(10, 37);
            textBoxFirstVar.Name = "textBoxFirstVar";
            textBoxFirstVar.Size = new Size(255, 27);
            textBoxFirstVar.TabIndex = 1;
            textBoxFirstVar.KeyPress += textBoxFirstVar_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 67);
            label2.Name = "label2";
            label2.Size = new Size(163, 20);
            label2.TabIndex = 2;
            label2.Text = "Введите второе число";
            // 
            // textBoxSecondVar
            // 
            textBoxSecondVar.Location = new Point(10, 90);
            textBoxSecondVar.Name = "textBoxSecondVar";
            textBoxSecondVar.Size = new Size(255, 27);
            textBoxSecondVar.TabIndex = 3;
            textBoxSecondVar.KeyPress += textBoxSecondVar_KeyPress;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(9, 131);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(62, 29);
            buttonAdd.TabIndex = 4;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSub
            // 
            buttonSub.Location = new Point(77, 131);
            buttonSub.Name = "buttonSub";
            buttonSub.Size = new Size(62, 29);
            buttonSub.TabIndex = 5;
            buttonSub.Text = "-";
            buttonSub.UseVisualStyleBackColor = true;
            buttonSub.Click += buttonSub_Click;
            // 
            // buttonMult
            // 
            buttonMult.Location = new Point(145, 131);
            buttonMult.Name = "buttonMult";
            buttonMult.Size = new Size(62, 29);
            buttonMult.TabIndex = 6;
            buttonMult.Text = "*";
            buttonMult.UseVisualStyleBackColor = true;
            buttonMult.Click += buttonMult_Click;
            // 
            // buttonDiv
            // 
            buttonDiv.Location = new Point(213, 131);
            buttonDiv.Name = "buttonDiv";
            buttonDiv.Size = new Size(59, 29);
            buttonDiv.TabIndex = 7;
            buttonDiv.Text = "/";
            buttonDiv.UseVisualStyleBackColor = true;
            buttonDiv.Click += buttonDiv_Click;
            // 
            // labelResult
            // 
            labelResult.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelResult.Location = new Point(9, 167);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(263, 77);
            labelResult.TabIndex = 8;
            labelResult.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 253);
            Controls.Add(labelResult);
            Controls.Add(buttonDiv);
            Controls.Add(buttonMult);
            Controls.Add(buttonSub);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxSecondVar);
            Controls.Add(label2);
            Controls.Add(textBoxFirstVar);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Мое первое приложение";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxFirstVar;
        private Label label2;
        private TextBox textBoxSecondVar;
        private Button buttonAdd;
        private Button buttonSub;
        private Button buttonMult;
        private Button buttonDiv;
        private Label labelResult;
    }
}
