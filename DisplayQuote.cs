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
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
        }

        public DisplayQuote(DeskQuote deskQuote)
        {
            InitializeComponent();
            nameBox.Text = deskQuote.GetCustomerName();
            widthBox.Text = deskQuote.GetWidth().ToString();
            depthBox.Text = deskQuote.GetDepth().ToString();
            drawersBox.Text = deskQuote.GetDrawers().ToString();
            materialBox.Text = deskQuote.GetDeskMaterial();

            switch (deskQuote.GetRush())
            {
                case "3":
                    rushBox.Text = "3 Days";
                    break;

                case "5":
                    rushBox.Text = "5 Days";
                    break;

                case "7":
                    rushBox.Text = "7 Days";
                    break;
                default:
                    rushBox.Text = "N/A";
                    break;
            }

            areaValue.Text = deskQuote.GetArea().ToString();
            baseValue.Text = deskQuote.GetBase().ToString();
            areaCostValue.Text = deskQuote.FindAreaPrice();
            drawerCostValue.Text = deskQuote.FindDrawerPrice().ToString();
            materialCostValue.Text = deskQuote.FindMaterialPrice().ToString();
            rushOrderValue.Text = deskQuote.FindRushPrice();
            totalValue.Text = deskQuote.GetTotal().ToString();


        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void DisplayQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
        }
    }
}
