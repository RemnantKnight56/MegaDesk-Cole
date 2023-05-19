namespace MegaDesk_Cole
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            addNewQuoteButton = new Button();
            viewQuoteButton = new Button();
            searchQuoteButton = new Button();
            exitButton = new Button();
            SuspendLayout();
            // 
            // addNewQuoteButton
            // 
            addNewQuoteButton.Location = new Point(12, 26);
            addNewQuoteButton.Name = "addNewQuoteButton";
            addNewQuoteButton.Size = new Size(116, 40);
            addNewQuoteButton.TabIndex = 0;
            addNewQuoteButton.Text = "Add New Quote";
            addNewQuoteButton.UseVisualStyleBackColor = true;
            addNewQuoteButton.MouseClick += AddNewQuoteButton_MouseClick;
            // 
            // viewQuoteButton
            // 
            viewQuoteButton.Location = new Point(12, 72);
            viewQuoteButton.Name = "viewQuoteButton";
            viewQuoteButton.Size = new Size(116, 40);
            viewQuoteButton.TabIndex = 1;
            viewQuoteButton.Text = "View Quotes";
            viewQuoteButton.UseVisualStyleBackColor = true;
            viewQuoteButton.MouseClick += ViewQuoteButton_MouseClick;
            // 
            // searchQuoteButton
            // 
            searchQuoteButton.Location = new Point(12, 118);
            searchQuoteButton.Name = "searchQuoteButton";
            searchQuoteButton.Size = new Size(116, 40);
            searchQuoteButton.TabIndex = 2;
            searchQuoteButton.Text = "Search Quotes";
            searchQuoteButton.UseVisualStyleBackColor = true;
            searchQuoteButton.Click += SearchQuoteButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(12, 164);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(116, 40);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += ExitButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 236);
            Controls.Add(exitButton);
            Controls.Add(searchQuoteButton);
            Controls.Add(viewQuoteButton);
            Controls.Add(addNewQuoteButton);
            Name = "MainMenu";
            Text = "Main Menu";
            FormClosing += MainMenu_FormClosing;
            Load += MainMenu_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button addNewQuoteButton;
        private Button viewQuoteButton;
        private Button searchQuoteButton;
        private Button exitButton;
    }
}