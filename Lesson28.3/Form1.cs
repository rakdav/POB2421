using Lesson28._2;
using System.IO;

namespace Lesson28._3
{
    public partial class Form1 : Form
    {
        private DirectoryInfo dinfo;
        private bool IsOpen;
        public Form1()
        {
            InitializeComponent();
            dinfo = new DirectoryInfo(Environment.CurrentDirectory);
            UpdateFiles();
        }
        private void UpdateFiles()
        {
            listBoxFiles.Items.Clear();
            foreach (FileInfo file in dinfo.GetFiles())
                if (file.Extension == ".txt")
                    listBoxFiles.Items.Add(file.Name);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (IsOpen == false)
            {
                saveFileDialog1.InitialDirectory = dinfo.FullName;
                saveFileDialog1.Filter = "*.txt|*.txt";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ClassFileManager.Write(saveFileDialog1.FileName, textBoxText.Text);
                    UpdateFiles();
                }
            }
            else
            {
                ClassFileManager.Write(dinfo.FullName + "\\" + listBoxFiles.SelectedItem, textBoxText.Text);
            }
        }

        private void listBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedIndex != -1)
            {
                textBoxText.Text = ClassFileManager.Read(dinfo.FullName + "\\" + listBoxFiles.SelectedItem);
                IsOpen = true;
            }
        }

        private void buttonSub_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedIndex != -1)
            {
                ClassFileManager.FileRemove(dinfo.FullName + "\\" + listBoxFiles.SelectedItem);
                UpdateFiles();
                textBoxText.Text = "";
            }
        }
    }
}
