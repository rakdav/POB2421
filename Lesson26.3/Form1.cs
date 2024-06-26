namespace Lesson26._3
{
    public partial class Form1 : Form
    {
        private double price;
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    {
                        price = 1000;
                        pictureBox1.Image = new Bitmap(Properties.Resources.wood);
                    }
                    break;
                case 1:
                    {
                        price = 2100;
                        pictureBox1.Image = new Bitmap(Properties.Resources.alum);
                    }
                    break;
                case 2:
                    {
                        price = 1900;
                        pictureBox1.Image = new Bitmap(Properties.Resources.plast);
                    }
                    break;
                case 3:
                    {
                        price = 700;
                        pictureBox1.Image = new Bitmap(Properties.Resources.paper);
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double width, height;
                double.TryParse(textBoxWidth.Text, out width);
                double.TryParse(textBoxHeight.Text, out height);
                labelResult.Text = $"Стоимость площади {width*height} кв. метра:{price*width*height:C}";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
