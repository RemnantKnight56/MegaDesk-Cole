namespace MegaDesk_Cole
{
    public partial class MainMenu : Form
    {
        public int quoteCounter;
        public DeskQuote[] quotesList;

        public MainMenu()
        {
            InitializeComponent();
            quoteCounter = 0;
            quotesList = new DeskQuote[50];
        }

        private void AddNewQuoteButton_MouseClick(object sender, MouseEventArgs e)
        {
            AddQuote aq = new()
            {
                Tag = this
            };
            aq.Show(this);
            this.Hide();
        }

        private void ViewQuoteButton_MouseClick(object sender, MouseEventArgs e)
        {
            ViewAllQuotes vq = new(quotesList, quoteCounter)
            {
                Tag = this
            };
            vq.Show(this);
            this.Hide();
        }

        private void SearchQuoteButton_Click(object sender, EventArgs e)
        {
            SearchQuotes sq = new(quotesList, quoteCounter)
            {
                Tag = this
            };
            sq.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}