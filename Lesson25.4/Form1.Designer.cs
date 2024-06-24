namespace Lesson25._4
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
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 25.8000011F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(142, 139);
            label1.TabIndex = 0;
            label1.Text = "YOUR LOGO";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(152, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(118, 110);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Lime;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(40, 163);
            button1.Name = "button1";
            button1.Size = new Size(209, 53);
            button1.TabIndex = 2;
            button1.Text = "LOG IN";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(40, 222);
            button2.Name = "button2";
            button2.Size = new Size(209, 45);
            button2.TabIndex = 3;
            button2.Text = "SIGN UP";
            button2.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(12, 279);
            label2.Name = "label2";
            label2.Size = new Size(258, 115);
            label2.TabIndex = 4;
            label2.Text = "Create you design";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fone;
            ClientSize = new Size(282, 403);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private Label label2;
    }
}
