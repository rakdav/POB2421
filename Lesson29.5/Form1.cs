namespace Lesson29._5
{
    public partial class Form1 : Form
    {
        private Generator generator;
        public Form1()
        {
            InitializeComponent();
            generator = new Generator();
        }

        private void buttonGen_Click(object sender, EventArgs e)
        {
            textBoxResult.Text = generator.GenNumber
                (
                int.Parse(textBoxFrom.Text), 
                int.Parse(textBoxTo.Text)
                ).ToString();
        }
    }
}
