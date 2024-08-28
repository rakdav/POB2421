namespace Lesson29._2
{
    public partial class Form1 : Form
    {
        private StringClass stringClass;
        public Form1()
        {
            InitializeComponent();
            stringClass = new StringClass();
        }
        private void radioButtonPolindrom_CheckedChanged(object sender, EventArgs e)
        {
            stringClass.setStroka(textBoxText.Text);
            if (stringClass.isPolindrom()) labelResult.Text = "������ ���������";
            else labelResult.Text = "������ �� ���������";
        }

        private void radioButtonReverse_CheckedChanged(object sender, EventArgs e)
        {
            stringClass.setStroka(textBoxText.Text);
            labelResult.Text = stringClass.Reverse();
        }

        private void radioButtonUpper_CheckedChanged(object sender, EventArgs e)
        {
            stringClass.setStroka(textBoxText.Text);
            labelResult.Text = stringClass.toUpper();
        }

        private void radioButtonLower_CheckedChanged(object sender, EventArgs e)
        {
            stringClass.setStroka(textBoxText.Text);
            labelResult.Text = stringClass.toLower();
        }

        private void textBoxIndex_TextChanged(object sender, EventArgs e)
        {
            stringClass.setStroka(textBoxText.Text);
            if(textBoxIndex.Text.Length!=0)
            labelResult.Text = stringClass.SubString(int.Parse(textBoxIndex.Text));
            else labelResult.Text = "";
        }

        private void textBoxSearch_TextChanged(object sender, EventArgs e)
        {
            stringClass.setStroka(textBoxText.Text);
            if (textBoxSearch.Text.Length != 0)
            {
                if (stringClass.Search(textBoxSearch.Text)) labelResult.Text = "������ �������� c���� " + textBoxSearch.Text;
                else labelResult.Text = "������ �� �������� c���� " + textBoxSearch.Text;
            }
            else labelResult.Text = "";
        }
    }
}
