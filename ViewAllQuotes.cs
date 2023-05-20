using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Cole
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
        {
            InitializeComponent();
        }

        public ViewAllQuotes(List<DeskQuote> deskQuotes)
        {
            InitializeComponent();
            foreach (DeskQuote item in deskQuotes)
            {

                int rowID = dataGrid.Rows.Add();
                DataGridViewRow row = dataGrid.Rows[rowID];

                row.Cells["namesColumn"].Value = item.GetCustomerName();
                row.Cells["pricesColumn"].Value = item.GetTotal();
                row.Cells["datesColumn"].Value = item.GetDateTime();
                row.Cells["widthsColumn"].Value = item.GetWidth();
                row.Cells["depthsColumn"].Value = item.GetDepth();
                row.Cells["drawerColumn"].Value = item.GetDrawers();
                row.Cells["rushDaysColumn"].Value = item.GetRush().ToString();
                row.Cells["materialsColumn"].Value = item.GetDeskMaterial().ToString();
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void dataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //MainMenu viewMainMenu = (MainMenu)Tag;

            //DisplayQuote displayMenu = new(viewMainMenu.quotesList[dataGrid.SelectedRows[0].Index]);
            //displayMenu.Show();
        }

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
        }
    }
}
