using System;

namespace Lesson26._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void TextBoxClear()
        {
            textBoxPrice10x12.Clear();
            textBoxPrice3x4.Clear();
            textBox20x30.Clear();
        }
        private void radioButton10x12_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPrice10x12.Enabled = true;
            textBoxPrice3x4.Enabled = false;
            textBox20x30.Enabled = false;
            TextBoxClear();
        }

        private void radioButton3x4_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPrice10x12.Enabled = false;
            textBoxPrice3x4.Enabled = true;
            textBox20x30.Enabled = false;
            TextBoxClear();
        }

        private void radioButton20x30_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPrice10x12.Enabled = false;
            textBoxPrice3x4.Enabled = false;
            textBox20x30.Enabled = true;
            TextBoxClear();
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            try
            {
                int n;
                int.TryParse(textBoxCount.Text, out n);
                if (radioButton10x12.Checked)
                {
                    decimal price = decimal.Parse(textBoxPrice10x12.Text) * n;
                    labelResult.Text = $"Цена {n} фотографий 10х12:{price.ToString("C")}";
                }
                else if (radioButton3x4.Checked)
                {
                    decimal price = decimal.Parse(textBoxPrice3x4.Text) * n;
                    labelResult.Text = $"Цена {n} фотографий 3х4:{price.ToString("C")}";
                }
                else
                {
                    decimal price = decimal.Parse(textBox20x30.Text) * n;
                    labelResult.Text = $"Цена {n} фотографий 20х30:{price.ToString("C")}";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
