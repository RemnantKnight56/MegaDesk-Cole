namespace MegaDesk_Cole
{
    public partial class MainMenu : Form
    {
        public int quoteCounter = 0;
        public Quote[] quotesList = new Quote[50];

        public MainMenu()
        {
            InitializeComponent();
        }

        private void addNewQuoteButton_MouseClick(object sender, MouseEventArgs e)
        {
            AddQuote aq = new AddQuote();
            //aq.Show();
            aq.Tag = this;
            aq.Show(this);
            this.Hide();
        }

        private void viewQuoteButton_MouseClick(object sender, MouseEventArgs e)
        {
            ViewAllQuotes vq = new ViewAllQuotes();
            vq.Show();
        }

        private void searchQuoteButton_Click(object sender, EventArgs e)
        {
            SearchQuotes sq = new SearchQuotes();
            sq.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}