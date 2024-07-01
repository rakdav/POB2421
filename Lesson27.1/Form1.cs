namespace Lesson27._1
{
    public partial class Form1 : Form
    {
        private Analizer analizer;
        private string result;
        public Form1()
        {
            InitializeComponent();
            textBoxSubString.Enabled = false;
            radioButtonLower.Checked=true;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            result = "";
            labelOutput.Text = "";
            analizer = new Analizer(textBoxInput.Text);
            if (checkBoxCount.Checked) result += analizer.getLength() + "\n";
            if (checkBoxFind.Checked)
            {
                result += analizer.haveSubString(textBoxSubString.Text).ToString() + "\n";
            }
            if (radioButtonUpper.Checked)
            {
                result += analizer.toUpper() + "\n";
            }
            if (radioButtonLower.Checked)
            {
                result += analizer.toLower() + "\n";
            }
            labelOutput.Text = result;
        }

        private void checkBoxFind_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxFind.Checked)
            {
                textBoxSubString.Enabled = true;
            }
            else
            {
                textBoxSubString.Enabled = false;
            }
        }

        private void checkBoxAll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAll.Checked)
            {
                checkBoxCount.Checked = true;
                checkBoxFind.Checked = true;
                radioButtonLower.Checked = true;
            }
            else
            {
                checkBoxCount.Checked = false;
                checkBoxFind.Checked = false;
                radioButtonLower.Checked = false;
            }
        }
    }
}
