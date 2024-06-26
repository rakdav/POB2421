namespace Lesson26._2
{
    public partial class Form1 : Form
    {
        private int Total;
        public Form1()
        {
            InitializeComponent();
            labelResult.Text = Total.ToString("C");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) Total += 5000;
            else Total -= 5000;
            labelResult.Text = Total.ToString("C");
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked) Total += 6000;
            else Total -= 6000;
            labelResult.Text = Total.ToString("C");
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) Total += 800;
            else Total -= 800;
            labelResult.Text = Total.ToString("C");
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked) Total += 950;
            else Total -= 950;
            labelResult.Text = Total.ToString("C");
        }
    }
}
