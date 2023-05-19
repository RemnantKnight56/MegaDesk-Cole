using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Cole
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            List<DesktopMaterial> materials = Enum.GetValues<DesktopMaterial>().ToList<DesktopMaterial>();
            searchBox.DataSource = materials;
            searchBox.SelectedIndex = 5;
        }

        public SearchQuotes(List<DeskQuote> deskQuotes)
        {
            InitializeComponent();
            List<DesktopMaterial> materials = Enum.GetValues<DesktopMaterial>().ToList<DesktopMaterial>();
            searchBox.DataSource = materials;
            searchBox.SelectedIndex = 5;

            foreach (DeskQuote item in deskQuotes)
            {
                int rowID = dataGrid.Rows.Add();
                DataGridViewRow row = dataGrid.Rows[rowID];

                row.Cells["namesColumn"].Value = item.customerName;
                row.Cells["pricesColumn"].Value = item.total;
                row.Cells["datesColumn"].Value = item.dateOrdered.Date;
                row.Cells["widthsColumn"].Value = item.deskOrdered.Width;
                row.Cells["depthsColumn"].Value = item.deskOrdered.Depth;
                row.Cells["drawerColumn"].Value = item.deskOrdered.NumDrawers;
                row.Cells["rushDaysColumn"].Value = item.rushDays.ToString();
                row.Cells["materialsColumn"].Value = item.deskOrdered.DeskMaterial.ToString();
                row.Visible = false;
            }

            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                DataGridViewRow row = dataGrid.Rows[i];
                if ((string)row.Cells["materialsColumn"].Value == searchBox.Text)
                {
                    row.Visible = true;
                }
            }
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void SearchBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGrid.RowCount; i++)
            {
                DataGridViewRow row = dataGrid.Rows[i];
                if ((string)row.Cells["materialsColumn"].Value == searchBox.Text)
                {
                    row.Visible = true;
                }
                else
                {
                    row.Visible = false;
                }
            }
        }
    }
}
