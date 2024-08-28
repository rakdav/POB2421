namespace Lesson26._4
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
            folderBrowserDialog1 = new FolderBrowserDialog();
            listBoxPictures = new ListBox();
            buttonOpen = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // listBoxPictures
            // 
            listBoxPictures.FormattingEnabled = true;
            listBoxPictures.Location = new Point(11, 13);
            listBoxPictures.Name = "listBoxPictures";
            listBoxPictures.Size = new Size(214, 264);
            listBoxPictures.TabIndex = 0;
            listBoxPictures.SelectedIndexChanged += listBoxPictures_SelectedIndexChanged;
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(11, 283);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(214, 29);
            buttonOpen.TabIndex = 1;
            buttonOpen.Text = "Загрузить";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(235, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(266, 299);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(512, 326);
            Controls.Add(pictureBox1);
            Controls.Add(buttonOpen);
            Controls.Add(listBoxPictures);
            Name = "Form1";
            Text = "Фотографии";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FolderBrowserDialog folderBrowserDialog1;
        private ListBox listBoxPictures;
        private Button buttonOpen;
        private PictureBox pictureBox1;
    }
}
