namespace Lesson26._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            listBoxPictures.Items.Clear();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                DirectoryInfo dinfo = new DirectoryInfo(folderBrowserDialog1.SelectedPath);
                foreach (FileInfo f in dinfo.GetFiles())
                {
                    if (f.Extension == ".jpg" || f.Extension == ".png" || f.Extension == ".bmp")
                    {
                        listBoxPictures.Items.Add(f.Name);
                    }
                }
            }
        }

        private void listBoxPictures_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(folderBrowserDialog1.SelectedPath +"\\"+ listBoxPictures.SelectedItem);
        }
    }
}
