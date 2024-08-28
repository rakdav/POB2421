namespace Lesson29._4
{
    public partial class Form1 : Form
    {
        private ButtonColor buttonColor;
        public Form1()
        {
            InitializeComponent();
            buttonColor = new ButtonColor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor = buttonColor.GetColor();
            button1.ForeColor = buttonColor.GetColor();
        }
    }
}
