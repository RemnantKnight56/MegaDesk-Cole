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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            addNewQuoteButton = new Button();
            viewQuoteButton = new Button();
            searchQuoteButton = new Button();
            exitButton = new Button();
            image = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)image).BeginInit();
            SuspendLayout();
            // 
            // addNewQuoteButton
            // 
            addNewQuoteButton.Location = new Point(17, 18);
            addNewQuoteButton.Margin = new Padding(4, 5, 4, 5);
            addNewQuoteButton.Name = "addNewQuoteButton";
            addNewQuoteButton.Size = new Size(166, 67);
            addNewQuoteButton.TabIndex = 0;
            addNewQuoteButton.Text = "Add New Quote";
            addNewQuoteButton.UseVisualStyleBackColor = true;
            addNewQuoteButton.MouseClick += AddNewQuoteButton_MouseClick;
            // 
            // viewQuoteButton
            // 
            viewQuoteButton.Location = new Point(17, 113);
            viewQuoteButton.Margin = new Padding(4, 5, 4, 5);
            viewQuoteButton.Name = "viewQuoteButton";
            viewQuoteButton.Size = new Size(166, 67);
            viewQuoteButton.TabIndex = 1;
            viewQuoteButton.Text = "View Quotes";
            viewQuoteButton.UseVisualStyleBackColor = true;
            viewQuoteButton.MouseClick += ViewQuoteButton_MouseClick;
            // 
            // searchQuoteButton
            // 
            searchQuoteButton.Location = new Point(17, 208);
            searchQuoteButton.Margin = new Padding(4, 5, 4, 5);
            searchQuoteButton.Name = "searchQuoteButton";
            searchQuoteButton.Size = new Size(166, 67);
            searchQuoteButton.TabIndex = 2;
            searchQuoteButton.Text = "Search Quotes";
            searchQuoteButton.UseVisualStyleBackColor = true;
            searchQuoteButton.Click += SearchQuoteButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(17, 303);
            exitButton.Margin = new Padding(4, 5, 4, 5);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(166, 67);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += ExitButton_Click;
            // 
            // image
            // 
            image.Image = (Image)resources.GetObject("image.Image");
            image.Location = new Point(207, 18);
            image.Name = "image";
            image.Size = new Size(423, 353);
            image.TabIndex = 4;
            image.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label1.Location = new Point(142, 393);
            label1.Name = "label1";
            label1.Size = new Size(355, 41);
            label1.TabIndex = 5;
            label1.Text = "MegaDesk Team Project";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(110, 439);
            label2.Name = "label2";
            label2.Size = new Size(150, 32);
            label2.TabIndex = 6;
            label2.Text = "Cole, Jeremy";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(331, 439);
            label3.Name = "label3";
            label3.Size = new Size(225, 32);
            label3.TabIndex = 7;
            label3.Text = "Fernandez, Eduardo";
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 485);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(image);
            Controls.Add(exitButton);
            Controls.Add(searchQuoteButton);
            Controls.Add(viewQuoteButton);
            Controls.Add(addNewQuoteButton);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Menu";
            FormClosing += MainMenu_FormClosing;
            Load += MainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)image).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button addNewQuoteButton;
        private Button viewQuoteButton;
        private Button searchQuoteButton;
        private Button exitButton;
        private PictureBox image;
        private Label label1;
        private Label label2;
        private Label label3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}