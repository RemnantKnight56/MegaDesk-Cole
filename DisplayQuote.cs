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
            nameBox.Text = deskQuote.customerName;
            widthBox.Text = deskQuote.deskOrdered.Width.ToString();
            depthBox.Text = deskQuote.deskOrdered.Depth.ToString();
            drawersBox.Text = deskQuote.deskOrdered.NumDrawers.ToString();
            materialBox.Text = deskQuote.deskOrdered.DeskMaterial.ToString();

            switch (deskQuote.rushDays)
            {
                case RushOrder.Three_Days:
                    rushBox.Text = "3 Days";
                    break;

                case RushOrder.Five_Days:
                    rushBox.Text = "5 Days";
                    break;

                case RushOrder.Seven_Days:
                    rushBox.Text = "7 Days";
                    break;
                case RushOrder.None:
                    break;
                case RushOrder.Not_Selected:
                    break;
                default:
                    rushBox.Text = "N/A";
                    break;
            }

            FigurePrices(deskQuote);
        }

        private void FigurePrices(DeskQuote deskQuote)
        {
            areaValue.Text = (deskQuote.deskOrdered.Width * deskQuote.deskOrdered.Depth).ToString();
            baseValue.Text = DeskQuote.basePrice;
            areaCostValue.Text = deskQuote.FindAreaPrice();
            drawerCostValue.Text = deskQuote.FindDrawerPrice();
            materialCostValue.Text = deskQuote.FindMaterialPrice();
            rushOrderValue.Text = deskQuote.FindRushPrice();
            totalValue.Text = deskQuote.FindTotalPrice();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //MainMenu viewMainMenu = (MainMenu)Tag;
            //viewMainMenu.Show();
            Close();
        }
    }
}
