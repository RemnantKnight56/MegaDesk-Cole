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
        readonly DeskQuote currentDesk;
        bool nonNumberEntered;

        public AddQuote()
        {
            InitializeComponent();
            currentDesk = new();
            nonNumberEntered = false;

            errorProvider.SetError(nameInput, "Enter a name");
            errorProvider.SetError(widthInput, "Enter a width");
            errorProvider.SetError(depthInput, "Enter a depth");
            errorProvider.SetError(surfaceBox, "Select a surface");
            errorProvider.SetError(rushBox, "Select a rush order type");
        }

        public AddQuote(DeskQuote oldQuote)
        {
            InitializeComponent();
            currentDesk = oldQuote;
            nonNumberEntered = false;

            if (currentDesk.customerName == "")
                errorProvider.SetError(nameInput, "Enter a name");
            else
                nameInput.Text = currentDesk.customerName;

            if (currentDesk.deskOrdered.Width < Desk.deskWidthMin || currentDesk.deskOrdered.Width > Desk.deskWidthMax)
                errorProvider.SetError(widthInput, "Enter a width");
            else
                widthInput.Text = currentDesk.deskOrdered.Width.ToString();

            if (currentDesk.deskOrdered.Depth < Desk.deskDepthMin || currentDesk.deskOrdered.Depth > Desk.deskDepthMax)
                errorProvider.SetError(depthInput, "Enter a depth");
            else
                depthInput.Text = currentDesk.deskOrdered.Depth.ToString();

            if(currentDesk.deskOrdered.DeskMaterial == DesktopMaterial.Not_Selected)
                errorProvider.SetError(surfaceBox, "Select a surface");
            else
                surfaceBox.SelectedIndex = (int)currentDesk.deskOrdered.DeskMaterial;

            if(currentDesk.deskOrdered.NumDrawers > Desk.maxDrawers || currentDesk.deskOrdered.NumDrawers < Desk.minDrawers)
                errorProvider.SetError(drawerUpDown, "Must be between " + Desk.minDrawers + " and " + Desk.maxDrawers);
            else
                drawerUpDown.Value = currentDesk.deskOrdered.NumDrawers;

            if(currentDesk.rushDays == RushOrder.Not_Selected)
                errorProvider.SetError(rushBox, "Select a rush order type");
            else
                rushBox.SelectedIndex = (int)currentDesk.rushDays;
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (errorProvider.GetError(depthInput) == "" &&
                errorProvider.GetError(widthInput) == "" &&
                errorProvider.GetError(nameInput) == "" &&
                errorProvider.GetError(surfaceBox) == "" &&
                errorProvider.GetError(rushBox) == "" &&
                errorProvider.GetError(drawerUpDown) == "")
            {
                MainMenu viewMainMenu = (MainMenu)Tag;
                viewMainMenu.quotesList.Add(currentDesk);
                viewMainMenu.Show();

                DisplayQuote displayMenu = new(currentDesk);
                displayMenu.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Resolve all errors before continuing.");
            }
        }

        private void DepthInput_KeyDown(object sender, KeyEventArgs e)
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

        private void DepthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (nonNumberEntered)
            {
                e.Handled = true;
            }
        }

        private void DepthInput_KeyUp(object sender, KeyEventArgs e)
        {
            if (depthInput.Text != "")
            {
                currentDesk.deskOrdered.Depth = ToInt32(depthInput.Text);
            }

            if ((currentDesk.deskOrdered.Depth < Desk.deskDepthMin) || (currentDesk.deskOrdered.Depth > Desk.deskDepthMax))
            {
                errorProvider.SetError(depthInput, "Depth must be set between " + Desk.deskDepthMin +
                    " and " + Desk.deskDepthMax);
            }
            else
            {
                errorProvider.SetError(depthInput, "");
                currentDesk.deskOrdered.Depth = Convert.ToInt32(depthInput.Text);
            }
        }

        private void WidthInput_TextChanged(object sender, EventArgs e)
        {
            try
            {
                currentDesk.deskOrdered.Width = ToInt32(widthInput.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Only numbers are valid input");
                widthInput.Text = "0";
            }
        }

        private void WidthInput_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                currentDesk.deskOrdered.Width = ToInt32(widthInput.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Only numbers are valid input");
                widthInput.Text = "0";
                return;
            }
            if ((currentDesk.deskOrdered.Width < Desk.deskWidthMin) || (currentDesk.deskOrdered.Width > Desk.deskWidthMax))
            {
                e.Cancel = true;
                errorProvider.SetError(widthInput, "Width must be set between " + Desk.deskWidthMin +
                    " and " + Desk.deskWidthMax);
                widthInput.Select(0, widthInput.Text.Length);
            }
        }

        private void WidthInput_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError(widthInput, "");
            currentDesk.deskOrdered.Width = Convert.ToInt32(widthInput.Text);
        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {
            if (nameInput.Text != "")
            {
                errorProvider.SetError(nameInput, "");
                currentDesk.customerName = nameInput.Text;
            }
            else
            {
                errorProvider.SetError(nameInput, "Enter a name");
            }
        }

        private void SurfaceBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            currentDesk.deskOrdered.DeskMaterial = (DesktopMaterial)surfaceBox.SelectedIndex;
            errorProvider.SetError(surfaceBox, "");
        }

        private void RushBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            currentDesk.rushDays = (RushOrder)rushBox.SelectedIndex;
            errorProvider.SetError(rushBox, "");
        }

        private void DrawerUpDown_ValueChanged(object sender, EventArgs e)
        {
            if(drawerUpDown.Value > Desk.maxDrawers || drawerUpDown.Value < Desk.minDrawers)
            {
                errorProvider.SetError(drawerUpDown, "Must be between " + Desk.minDrawers + " and " + Desk.maxDrawers);
            }
            else
            {
                errorProvider.SetError(drawerUpDown, "");
                currentDesk.deskOrdered.NumDrawers = Convert.ToInt32(drawerUpDown.Value);
            }
        }
    }
}
