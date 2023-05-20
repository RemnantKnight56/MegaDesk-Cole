using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using static System.Convert;
using static System.Net.Mime.MediaTypeNames;

namespace MegaDesk_Cole
{
    public partial class AddQuote : Form
    {
        protected DeskQuote currentDesk;

        public AddQuote()
        {
            InitializeComponent();
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
                currentDesk = new(Convert.ToInt32(widthInput.Text), Convert.ToInt32(depthInput.Text), Convert.ToInt32(drawerUpDown.Text), surfaceBox.Text, nameInput.Text, rushBox.Text, DateTime.Today);

                MainMenu viewMainMenu = (MainMenu)Tag;
                viewMainMenu.quotesList.Add(currentDesk);

                DisplayQuote displayQuote = new(currentDesk);
                displayQuote.Tag = viewMainMenu;
                displayQuote.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Resolve all errors before continuing.");
            }
        }

        private void nameInput_Validating(object sender, CancelEventArgs e)
        {
            ValidateText("Name", nameInput, e);
        }

        private void depthInput_Validating(object sender, CancelEventArgs e)
        {
            ValidateNumber(Desk.deskDepthMin, Desk.deskDepthMax, "Depth", depthInput, e);
        }

        private void widthInput_Validating(object sender, CancelEventArgs e)
        {
            ValidateNumber(Desk.deskWidthMin, Desk.deskWidthMax, "Width", widthInput, e);
        }

        private void drawerUpDown_Validating(object sender, CancelEventArgs e)
        {
            ValidateNumber(0, 7, "Number of drawers", drawerUpDown, e);
        }

        private void surfaceBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateCombo("Surface Material", surfaceBox, e);
        }

        private void rushBox_Validating(object sender, CancelEventArgs e)
        {
            ValidateCombo("Rush Order", rushBox, e);
        }

        private void ValidateNumber(int rangeMin, int rangeMax, string fieldName, TextBox field, CancelEventArgs e)
        {
            int input;
            bool isNum = Int32.TryParse(field.Text, out input);
            if (!isNum) // if its not numeric
            {
                MessageBox.Show($"You might only use numeric characters in the field {fieldName}.", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(field, "You might only use numeric characters in this field.");
                e.Cancel = true;
                field.Focus();
            }
            else if (input < rangeMin || input > rangeMax) // if the range is not met
            {
                errorProvider.SetError(field, $" {fieldName} must be set between " + rangeMin + " and " + rangeMax);
                e.Cancel = true;
                field.Focus();
            }
            else
            {
                errorProvider.SetError(field, null);
            }
            e.Cancel = false;
        }

        private void ValidateNumber(int rangeMin, int rangeMax, string fieldName, NumericUpDown field, CancelEventArgs e)
        {
            int input;
            bool isNum = Int32.TryParse(field.Text, out input);
            if (!isNum) // if its not numeric
            {
                MessageBox.Show($"You might only use numeric characters in the field {fieldName}.", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(field, "You might only use numeric characters in this field.");
                e.Cancel = true;
                field.Focus();
            }
            else if (input < rangeMin || input > rangeMax) // if the range is not met
            {
                errorProvider.SetError(field, $" {fieldName} must be set between " + rangeMin + " and " + rangeMax);
                e.Cancel = true;
                field.Focus();
            }
            else
            {
                errorProvider.SetError(field, null);
            }
            e.Cancel = false;
        }

        private void ValidateCombo(string fieldName, ComboBox field, CancelEventArgs e)
        {
            if (field.Text == "" || field.Text == null)// validates null or empty
            {
                MessageBox.Show($"You need to set a valid {fieldName}.", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(field, $"You need to set a valid {fieldName}.");
                e.Cancel = true;
                field.Focus();
            }
            else
            {
                errorProvider.SetError(field, null);
            };
            e.Cancel = false;
        }

        private void ValidateText(string fieldName, TextBox field, CancelEventArgs e)
        {
            if (field.Text == "" || field.Text == null)// validates null or empty
            {
                MessageBox.Show($"You need to set a valid {fieldName}.", "ATTENTION", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errorProvider.SetError(field, $"You need to set a valid {fieldName}.");
                e.Cancel = true;
                field.Focus();
            }
            else
            {
                errorProvider.SetError(field, null);
            };
            e.Cancel = false;
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.DialogResult == DialogResult.Cancel)
            {
                MainMenu viewMainMenu = (MainMenu)Tag;
                viewMainMenu.Show();
            }
        }
    }
}
