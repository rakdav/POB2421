using System.Collections.Generic;

namespace Lesson30
{
    public partial class Form1 : Form
    {
        private MyTask[] mas;
        private int count;
        private int selectedIndex;
        public Form1()
        {
            InitializeComponent();
            count = 0;
            mas = new MyTask[count];

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddTask();
        }
        private void AddTask()
        {
            if (textBoxTask.Text.Length != 0 && listBoxPriority.SelectedIndex != -1)
            {
                MyTask task = new MyTask(textBoxTask.Text,
                    dateTimePickerTask.Value,
                    listBoxPriority.SelectedItem!.ToString());
                count++;
                Array.Resize<MyTask>(ref mas, count);
                mas[count - 1] = task;
                listBoxTask.Items.Add(task.getTask());
                listBoxDate.Items.Add(task.getDate());
                listBoxTaskPriority.Items.Add(task.getPriority());
                textBoxTask.Clear();
                listBoxPriority.SelectedIndex = -1;
                dateTimePickerTask.Value = DateTime.Now;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            RemoveTask();
        }
        private void RemoveTask()
        {
            if (listBoxTask.SelectedIndex != -1)
            {
                int index = listBoxTask.SelectedIndex;
                listBoxTask.Items.RemoveAt(index);
                listBoxDate.Items.RemoveAt(index);
                listBoxTaskPriority.Items.RemoveAt(index);
                MyTask[] temp = new MyTask[--count];
                int j = 0;
                for (int i = 0; i < mas.Length; i++)
                {
                    if (i != index)
                    {
                        temp[j++] = mas[i];
                    }
                }
                Array.Resize<MyTask>(ref mas, count);
                Array.Copy(temp, mas, count);
            }
        }

        private void listBoxTask_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTask.SelectedIndex != -1)
            {
                selectedIndex = listBoxTask.SelectedIndex;
                MyTask myTask = mas[selectedIndex];
                textBoxTask.Text = myTask.getTask();
                switch (myTask.getPriority())
                {
                    case "Низкий": listBoxPriority.SelectedIndex = 0; break;
                    case "Средний": listBoxPriority.SelectedIndex = 1; break;
                    case "Высокий": listBoxPriority.SelectedIndex = 2; break;
                }
                dateTimePickerTask.Value = myTask.getDate();
            }
        }
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            mas[selectedIndex].setTask(textBoxTask.Text);
            mas[selectedIndex].setPriority(listBoxPriority.SelectedItem!.ToString());
            mas[selectedIndex].setDate(dateTimePickerTask.Value);
            FormUpdate();
        }
        private void FormUpdate()
        {
            listBoxDate.Items.Clear();
            listBoxTaskPriority.Items.Clear();
            listBoxTask.Items.Clear();
            foreach(MyTask task in mas)
            {
                listBoxTask.Items.Add(task.getTask());
                listBoxDate.Items.Add(task.getDate());
                listBoxTaskPriority.Items.Add(task.getPriority());
            }
        }
    }
}
