namespace Lesson30
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
            listBoxTask = new ListBox();
            label1 = new Label();
            label2 = new Label();
            listBoxDate = new ListBox();
            listBoxTaskPriority = new ListBox();
            label3 = new Label();
            label4 = new Label();
            listBoxPriority = new ListBox();
            label5 = new Label();
            dateTimePickerTask = new DateTimePicker();
            label6 = new Label();
            textBoxTask = new TextBox();
            buttonAdd = new Button();
            buttonRemove = new Button();
            buttonEdit = new Button();
            SuspendLayout();
            // 
            // listBoxTask
            // 
            listBoxTask.FormattingEnabled = true;
            listBoxTask.Location = new Point(12, 31);
            listBoxTask.Name = "listBoxTask";
            listBoxTask.Size = new Size(150, 344);
            listBoxTask.TabIndex = 0;
            listBoxTask.SelectedIndexChanged += listBoxTask_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 8);
            label1.Name = "label1";
            label1.Size = new Size(57, 20);
            label1.TabIndex = 1;
            label1.Text = "Задача";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(179, 9);
            label2.Name = "label2";
            label2.Size = new Size(102, 20);
            label2.TabIndex = 2;
            label2.Text = "Дата и время";
            // 
            // listBoxDate
            // 
            listBoxDate.FormattingEnabled = true;
            listBoxDate.Location = new Point(179, 32);
            listBoxDate.Name = "listBoxDate";
            listBoxDate.Size = new Size(150, 344);
            listBoxDate.TabIndex = 3;
            // 
            // listBoxTaskPriority
            // 
            listBoxTaskPriority.FormattingEnabled = true;
            listBoxTaskPriority.Location = new Point(344, 31);
            listBoxTaskPriority.Name = "listBoxTaskPriority";
            listBoxTaskPriority.Size = new Size(150, 344);
            listBoxTaskPriority.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(344, 8);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 5;
            label3.Text = "Приоритет";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(503, 8);
            label4.Name = "label4";
            label4.Size = new Size(145, 20);
            label4.TabIndex = 6;
            label4.Text = "Укажите приоритет";
            // 
            // listBoxPriority
            // 
            listBoxPriority.FormattingEnabled = true;
            listBoxPriority.Items.AddRange(new object[] { "Низкий", "Средний", "Высокий" });
            listBoxPriority.Location = new Point(503, 32);
            listBoxPriority.Name = "listBoxPriority";
            listBoxPriority.Size = new Size(179, 104);
            listBoxPriority.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(503, 139);
            label5.Name = "label5";
            label5.Size = new Size(161, 20);
            label5.TabIndex = 8;
            label5.Text = "Укажите дату и время";
            // 
            // dateTimePickerTask
            // 
            dateTimePickerTask.Location = new Point(505, 162);
            dateTimePickerTask.Name = "dateTimePickerTask";
            dateTimePickerTask.Size = new Size(177, 27);
            dateTimePickerTask.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 386);
            label6.Name = "label6";
            label6.Size = new Size(157, 20);
            label6.TabIndex = 10;
            label6.Text = "Укажите текст задачи";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(12, 409);
            textBoxTask.Name = "textBoxTask";
            textBoxTask.Size = new Size(482, 27);
            textBoxTask.TabIndex = 11;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(505, 207);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(178, 29);
            buttonAdd.TabIndex = 12;
            buttonAdd.Text = "Добавить";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonRemove
            // 
            buttonRemove.Location = new Point(505, 255);
            buttonRemove.Name = "buttonRemove";
            buttonRemove.Size = new Size(177, 29);
            buttonRemove.TabIndex = 13;
            buttonRemove.Text = "Удалить";
            buttonRemove.UseVisualStyleBackColor = true;
            buttonRemove.Click += buttonRemove_Click;
            // 
            // buttonEdit
            // 
            buttonEdit.Location = new Point(505, 306);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(179, 29);
            buttonEdit.TabIndex = 14;
            buttonEdit.Text = "Перезаписать";
            buttonEdit.UseVisualStyleBackColor = true;
            buttonEdit.Click += buttonEdit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 450);
            Controls.Add(buttonEdit);
            Controls.Add(buttonRemove);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxTask);
            Controls.Add(label6);
            Controls.Add(dateTimePickerTask);
            Controls.Add(label5);
            Controls.Add(listBoxPriority);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(listBoxTaskPriority);
            Controls.Add(listBoxDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBoxTask);
            Name = "Form1";
            Text = "Планировщик задач";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxTask;
        private Label label1;
        private Label label2;
        private ListBox listBoxDate;
        private ListBox listBoxTaskPriority;
        private Label label3;
        private Label label4;
        private ListBox listBoxPriority;
        private Label label5;
        private DateTimePicker dateTimePickerTask;
        private Label label6;
        private TextBox textBoxTask;
        private Button buttonAdd;
        private Button buttonRemove;
        private Button buttonEdit;
    }
}
