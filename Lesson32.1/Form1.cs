namespace Lesson32._1
{
    public partial class Form1 : Form
    {
        private Library library;
        public Form1()
        {
            InitializeComponent();
            library = new Library();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxTitle.Text.Length != 0 &&
                textBoxAuthor.Text.Length != 0 &&
                textBoxYear.Text.Length != 0)
            {
                library.AddBook(new Book(textBoxTitle.Text,
                    textBoxAuthor.Text, int.Parse(textBoxYear.Text)));
                listBoxTitle.Items.Add(textBoxTitle.Text);
                listBoxAuthor.Items.Add(textBoxAuthor.Text);
                listBoxYear.Items.Add(textBoxYear.Text);
            }
        }
        private void Û‰‡ÎËÚ¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string title=listBoxTitle.SelectedItem!.ToString()!;
            library.Remove(title);
            UpdateForm();
        }
        private void UpdateForm()
        {
            listBoxAuthor.Items.Clear();
            listBoxTitle.Items.Clear();
            listBoxYear.Items.Clear();
            foreach (Book book in library.GetBooks())
            {
                listBoxTitle.Items.Add(book.getTitle());
                listBoxAuthor.Items.Add(book.getAuthor());
                listBoxYear.Items.Add(book.getYear());
            }
        }
    }
}
