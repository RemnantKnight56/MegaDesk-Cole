﻿using System;
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

                row.Cells["namesColumn"].Value = item.customerName;
                row.Cells["pricesColumn"].Value = item.total;
                row.Cells["datesColumn"].Value = item.dateOrdered.Date;
                row.Cells["widthsColumn"].Value = item.deskOrdered.Width;
                row.Cells["depthsColumn"].Value = item.deskOrdered.Depth;
                row.Cells["drawerColumn"].Value = item.deskOrdered.NumDrawers;
                row.Cells["rushDaysColumn"].Value = item.rushDays.ToString();
                row.Cells["materialsColumn"].Value = item.deskOrdered.DeskMaterial.ToString();
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
    }
}
