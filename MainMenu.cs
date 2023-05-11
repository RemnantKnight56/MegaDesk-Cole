namespace MegaDesk_Cole
{
    public partial class MainMenu : Form
    {
        public int quoteCounter = 0;
        public DeskQuote[] quotesList = new DeskQuote[50];

        public MainMenu()
        {
            InitializeComponent();
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
            ViewAllQuotes vq = new();
            vq.Show();
        }

        private void SearchQuoteButton_Click(object sender, EventArgs e)
        {
            SearchQuotes sq = new();
            sq.Show();
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