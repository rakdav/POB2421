namespace Lesson33._2
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
            treeViewList = new TreeView();
            buttonTree = new Button();
            labelPath = new Label();
            folderBrowserDialog1 = new FolderBrowserDialog();
            checkBoxFiles = new CheckBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // treeViewList
            // 
            treeViewList.Location = new Point(15, 39);
            treeViewList.Name = "treeViewList";
            treeViewList.Size = new Size(455, 346);
            treeViewList.TabIndex = 0;
            treeViewList.AfterSelect += treeViewList_AfterSelect;
            // 
            // buttonTree
            // 
            buttonTree.Location = new Point(15, 400);
            buttonTree.Name = "buttonTree";
            buttonTree.Size = new Size(94, 29);
            buttonTree.TabIndex = 1;
            buttonTree.Text = "Выбрать папку";
            buttonTree.UseVisualStyleBackColor = true;
            buttonTree.Click += buttonTree_Click;
            // 
            // labelPath
            // 
            labelPath.AutoSize = true;
            labelPath.Location = new Point(117, 405);
            labelPath.Name = "labelPath";
            labelPath.Size = new Size(0, 20);
            labelPath.TabIndex = 2;
            // 
            // checkBoxFiles
            // 
            checkBoxFiles.AutoSize = true;
            checkBoxFiles.Location = new Point(16, 11);
            checkBoxFiles.Name = "checkBoxFiles";
            checkBoxFiles.Size = new Size(154, 24);
            checkBoxFiles.TabIndex = 3;
            checkBoxFiles.Text = "Вывод с файлами";
            checkBoxFiles.UseVisualStyleBackColor = true;
            checkBoxFiles.CheckedChanged += checkBoxFiles_CheckedChanged;
            // 
            // label1
            // 
            label1.Location = new Point(484, 38);
            label1.Name = "label1";
            label1.Size = new Size(232, 347);
            label1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(728, 450);
            Controls.Add(label1);
            Controls.Add(checkBoxFiles);
            Controls.Add(labelPath);
            Controls.Add(buttonTree);
            Controls.Add(treeViewList);
            Name = "Form1";
            Text = "Дерево";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TreeView treeViewList;
        private Button buttonTree;
        private Label labelPath;
        private FolderBrowserDialog folderBrowserDialog1;
        private CheckBox checkBoxFiles;
        private Label label1;
    }
}
