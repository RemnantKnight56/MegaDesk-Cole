using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Convert;
using static System.Net.Mime.MediaTypeNames;

namespace MegaDesk_Cole
{
    public partial class AddQuote : Form
    {
        Desk currentDesk = new Desk();
        bool nonNumberEntered = false;

        public AddQuote()
        {
            InitializeComponent();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            /*if(errorProvider1.GetError(depthInput) != "" ||
                errorProvider1.GetError(widthInput) != "")
            {
                MainMenu viewMainMenu = (MainMenu)Tag;
                viewMainMenu.quotesList[viewMainMenu.quoteCounter].deskOrdered = currentDesk;
                viewMainMenu.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Resolve all errors before continuing.");
            }*/
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.quotesList[viewMainMenu.quoteCounter].deskOrdered = currentDesk;
            viewMainMenu.Show();
            Close();
        }

        private void depthInput_KeyDown(object sender, KeyEventArgs e)
        {
            nonNumberEntered = false;

            if (e.KeyCode < Keys.D0 || e.KeyCode > Keys.D9)
            {
                if (e.KeyCode < Keys.NumPad0 || e.KeyCode > Keys.NumPad9)
                {
                    if (e.KeyCode != Keys.Back)
                    {
                        nonNumberEntered = true;
                    }
                }
            }

            if (Control.ModifierKeys == Keys.Shift)
            {
                nonNumberEntered = true;
            }
        }

        private void depthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered)
            {
                e.Handled = true;
            }
        }

        private void depthInput_KeyUp(object sender, KeyEventArgs e)
        {
            currentDesk.depth = ToInt32(depthInput.Text);

            if ((currentDesk.depth < Desk.deskDepthMin) || (currentDesk.depth > Desk.deskDepthMax))
            {
                errorProvider1.SetError(depthInput, "Depth must be set between " + Desk.deskDepthMin +
                    " and " + Desk.deskDepthMax);
                depthInput.Select(0, depthInput.Text.Length);
            }
            else
            {
                errorProvider1.SetError(depthInput, "");
            }
        }

        private void widthInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                currentDesk.width = ToInt32(widthInput.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Only numbers are valid input");
                widthInput.Text = "0";
            }
        }

        private void widthInput_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                currentDesk.width = ToInt32(widthInput.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Only numbers are valid input");
                widthInput.Text = "0";
                return;
            }
            if ((currentDesk.width < Desk.deskWidthMin) || (currentDesk.width > Desk.deskWidthMax))
            {
                e.Cancel = true;
                errorProvider1.SetError(widthInput, "Width must be set between " + Desk.deskWidthMin +
                    " and " + Desk.deskWidthMax);
                widthInput.Select(0, widthInput.Text.Length);
            }
        }

        private void widthInput_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(widthInput, "");
        }
    }
}
