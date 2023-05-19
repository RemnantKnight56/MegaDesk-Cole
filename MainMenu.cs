using System.IO;

namespace MegaDesk_Cole
{
    public partial class MainMenu : Form
    {
        public List<DeskQuote> quotesList;

        public MainMenu() => InitializeComponent();

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
            ViewAllQuotes vq = new(quotesList)
            {
                Tag = this
            };
            vq.Show(this);
            this.Hide();
        }

        private void SearchQuoteButton_Click(object sender, EventArgs e)
        {
            SearchQuotes sq = new(quotesList)
            {
                Tag = this
            };
            sq.Show();
            this.Hide();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Tools SaveData = new Tools();
            SaveData.SaveFile(quotesList);
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Tools LoadData = new Tools();
            if (File.Exists(LoadData.getDir()))
            {
                quotesList = LoadData.LoadFile();

            }
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Tools SaveData = new Tools();
            SaveData.SaveFile(quotesList);
            Application.Exit();
        }
    }
}