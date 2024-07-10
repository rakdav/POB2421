namespace Lesson29._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxDist.SelectedIndex= 0;
            comboBoxTemp.SelectedIndex= 0;
            comboBoxBar.SelectedIndex= 0;
        }

        private void textBoxDist_TextChanged(object sender, EventArgs e)
        {
            DistChange();
        }
        private void comboBoxDist_SelectedIndexChanged(object sender, EventArgs e)
        {
            DistChange();
        }
        private void DistChange()
        {
            if (textBoxDist.Text.Length != 0)
            {
                double result = 0;
                Distance distance = new Distance(double.Parse(textBoxDist.Text));
                switch (comboBoxDist.SelectedIndex)
                {
                    case 0:
                        {
                            result = distance.toSm();
                            labelDistResult.Text = textBoxDist.Text + " לל = " + result.ToString() + " סל";
                        }
                        break;
                    case 1:
                        {
                            result = distance.toDm();
                            labelDistResult.Text = textBoxDist.Text + " לל = " + result.ToString() + " הל";
                        }
                        break;
                    case 2:
                        {
                            result = distance.toMetr();
                            labelDistResult.Text = textBoxDist.Text + " לל = " + result.ToString() + " ל";
                        }
                        break;
                    case 3:
                        {
                            result = distance.toKm();
                            labelDistResult.Text = textBoxDist.Text + " לל = " + result.ToString() + " ךל";
                        }
                        break;
                }
            }
            else labelDistResult.Text = "";
        }
    }
}
