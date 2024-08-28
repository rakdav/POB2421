namespace Lesson32._1
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
            components = new System.ComponentModel.Container();
            listBoxTitle = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            удалитьToolStripMenuItem = new ToolStripMenuItem();
            listBoxAuthor = new ListBox();
            listBoxYear = new ListBox();
            label1 = new Label();
            textBoxTitle = new TextBox();
            textBoxAuthor = new TextBox();
            label2 = new Label();
            textBoxYear = new TextBox();
            label3 = new Label();
            buttonAdd = new Button();
            buttonUpload = new Button();
            label4 = new Label();
            textBoxSearch = new TextBox();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // listBoxTitle
            // 
            listBoxTitle.ContextMenuStrip = contextMenuStrip1;
            listBoxTitle.FormattingEnabled = true;
            listBoxTitle.Location = new Point(5, 7);
            listBoxTitle.Name = "listBoxTitle";
            listBoxTitle.Size = new Size(189, 424);
            listBoxTitle.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { удалитьToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(135, 28);
            // 
            // удалитьToolStripMenuItem
            // 
            удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            удалитьToolStripMenuItem.Size = new Size(134, 24);
            удалитьToolStripMenuItem.Text = "Удалить";
            удалитьToolStripMenuItem.Click += удалитьToolStripMenuItem_Click;
            // 
            // listBoxAuthor
            // 
            listBoxAuthor.FormattingEnabled = true;
            listBoxAuthor.Location = new Point(211, 7);
            listBoxAuthor.Name = "listBoxAuthor";
            listBoxAuthor.Size = new Size(183, 424);
            listBoxAuthor.TabIndex = 1;
            // 
            // listBoxYear
            // 
            listBoxYear.FormattingEnabled = true;
            listBoxYear.Location = new Point(410, 7);
            listBoxYear.Name = "listBoxYear";
            listBoxYear.Size = new Size(162, 424);
            listBoxYear.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(578, 7);
            label1.Name = "label1";
            label1.Size = new Size(77, 20);
            label1.TabIndex = 3;
            label1.Text = "Название";
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(578, 30);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(210, 27);
            textBoxTitle.TabIndex = 4;
            // 
            // textBoxAuthor
            // 
            textBoxAuthor.Location = new Point(578, 94);
            textBoxAuthor.Name = "textBoxAuthor";
            textBoxAuthor.Size = new Size(210, 27);
            textBoxAuthor.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(578, 71);
            label2.Name = "label2";
            label2.Size = new Size(51, 20);
            label2.TabIndex = 5;
            label2.Text = "Автор";
            // 
            // textBoxYear
            // 
            textBoxYear.Location = new Point(578, 159);
            textBoxYear.Name = "textBoxYear";
            textBoxYear.Size = new Size(210, 27);
            textBoxYear.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(578, 136);
            label3.Name = "label3";
            label3.Size = new Size(95, 20);
            label3.TabIndex = 7;
            label3.Text = "Год издания";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(645, 202);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(143, 29);
            buttonAdd.TabIndex = 9;
            buttonAdd.Text = "Добавить книгу";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonUpload
            // 
            buttonUpload.Location = new Point(646, 238);
            buttonUpload.Name = "buttonUpload";
            buttonUpload.Size = new Size(142, 29);
            buttonUpload.TabIndex = 10;
            buttonUpload.Text = "Выгрузить список";
            buttonUpload.UseVisualStyleBackColor = true;
            buttonUpload.Click += buttonUpload_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 443);
            label4.Name = "label4";
            label4.Size = new Size(52, 20);
            label4.TabIndex = 11;
            label4.Text = "Поиск";
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(69, 443);
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(503, 27);
            textBoxSearch.TabIndex = 12;
            textBoxSearch.TextChanged += textBoxSearch_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 478);
            Controls.Add(textBoxSearch);
            Controls.Add(label4);
            Controls.Add(buttonUpload);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxYear);
            Controls.Add(label3);
            Controls.Add(textBoxAuthor);
            Controls.Add(label2);
            Controls.Add(textBoxTitle);
            Controls.Add(label1);
            Controls.Add(listBoxYear);
            Controls.Add(listBoxAuthor);
            Controls.Add(listBoxTitle);
            Name = "Form1";
            Text = "Библиотека";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxTitle;
        private ListBox listBoxAuthor;
        private ListBox listBoxYear;
        private Label label1;
        private TextBox textBoxTitle;
        private TextBox textBoxAuthor;
        private Label label2;
        private TextBox textBoxYear;
        private Label label3;
        private Button buttonAdd;
        private Button buttonUpload;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private Label label4;
        private TextBox textBoxSearch;
    }
}
