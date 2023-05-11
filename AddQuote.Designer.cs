namespace MegaDesk_Cole
{
    partial class AddQuote
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            drawerUpDown = new NumericUpDown();
            nameInput = new TextBox();
            nameLabel = new Label();
            widthLabel = new Label();
            depthLabel = new Label();
            drawerLabel = new Label();
            surfaceBox = new ComboBox();
            materialLabel = new Label();
            rushBox = new ComboBox();
            rushOrderLabel = new Label();
            confirmButton = new Button();
            errorProvider = new ErrorProvider(components);
            depthInput = new TextBox();
            widthInput = new TextBox();
            ((System.ComponentModel.ISupportInitialize)drawerUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // drawerUpDown
            // 
            drawerUpDown.Location = new Point(149, 113);
            drawerUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            drawerUpDown.Name = "drawerUpDown";
            drawerUpDown.Size = new Size(64, 23);
            drawerUpDown.TabIndex = 4;
            drawerUpDown.ValueChanged += DrawerUpDown_ValueChanged;
            // 
            // nameInput
            // 
            nameInput.Location = new Point(149, 26);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(168, 23);
            nameInput.TabIndex = 1;
            nameInput.TextChanged += NameInput_TextChanged;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(12, 29);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(97, 15);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Customer Name";
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            widthLabel.Location = new Point(12, 57);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(118, 15);
            widthLabel.TabIndex = 5;
            widthLabel.Text = "Desk Width (inches)";
            // 
            // depthLabel
            // 
            depthLabel.AutoSize = true;
            depthLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            depthLabel.Location = new Point(12, 86);
            depthLabel.Name = "depthLabel";
            depthLabel.Size = new Size(119, 15);
            depthLabel.TabIndex = 6;
            depthLabel.Text = "Desk Depth (inches)";
            // 
            // drawerLabel
            // 
            drawerLabel.AutoSize = true;
            drawerLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            drawerLabel.Location = new Point(12, 115);
            drawerLabel.Name = "drawerLabel";
            drawerLabel.Size = new Size(118, 15);
            drawerLabel.TabIndex = 7;
            drawerLabel.Text = "Number of Drawers";
            // 
            // surfaceBox
            // 
            surfaceBox.DropDownStyle = ComboBoxStyle.DropDownList;
            surfaceBox.FormattingEnabled = true;
            surfaceBox.Items.AddRange(new object[] { "Pine", "Laminate", "Veneer", "Oak", "Rosewood" });
            surfaceBox.Location = new Point(149, 142);
            surfaceBox.MaxDropDownItems = 5;
            surfaceBox.Name = "surfaceBox";
            surfaceBox.Size = new Size(108, 23);
            surfaceBox.TabIndex = 5;
            surfaceBox.SelectionChangeCommitted += SurfaceBox_SelectionChangeCommitted;
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            materialLabel.Location = new Point(12, 145);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new Size(99, 15);
            materialLabel.TabIndex = 9;
            materialLabel.Text = "Surface Material";
            // 
            // rushBox
            // 
            rushBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rushBox.FormattingEnabled = true;
            rushBox.Items.AddRange(new object[] { "N/A", "3 Days", "5 Days", "7 Days" });
            rushBox.Location = new Point(149, 168);
            rushBox.MaxDropDownItems = 5;
            rushBox.Name = "rushBox";
            rushBox.Size = new Size(108, 23);
            rushBox.TabIndex = 6;
            rushBox.SelectionChangeCommitted += RushBox_SelectionChangeCommitted;
            // 
            // rushOrderLabel
            // 
            rushOrderLabel.AutoSize = true;
            rushOrderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            rushOrderLabel.Location = new Point(10, 171);
            rushOrderLabel.Name = "rushOrderLabel";
            rushOrderLabel.Size = new Size(75, 15);
            rushOrderLabel.TabIndex = 11;
            rushOrderLabel.Text = "Rush Order?";
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(287, 204);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(75, 23);
            confirmButton.TabIndex = 7;
            confirmButton.Text = "Submit";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += ConfirmButton_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // depthInput
            // 
            depthInput.Location = new Point(149, 84);
            depthInput.MaximumSize = new Size(64, 23);
            depthInput.MinimumSize = new Size(64, 23);
            depthInput.Name = "depthInput";
            depthInput.Size = new Size(64, 23);
            depthInput.TabIndex = 3;
            depthInput.Text = "0";
            depthInput.KeyDown += DepthInput_KeyDown;
            depthInput.KeyPress += DepthInput_KeyPress;
            depthInput.KeyUp += DepthInput_KeyUp;
            // 
            // widthInput
            // 
            widthInput.Location = new Point(149, 57);
            widthInput.MaxLength = 4;
            widthInput.Name = "widthInput";
            widthInput.Size = new Size(64, 23);
            widthInput.TabIndex = 2;
            widthInput.Text = "0";
            widthInput.TextChanged += WidthInput_TextChanged;
            widthInput.Validating += WidthInput_Validating;
            widthInput.Validated += WidthInput_Validated;
            // 
            // AddQuote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(374, 236);
            Controls.Add(widthInput);
            Controls.Add(depthInput);
            Controls.Add(confirmButton);
            Controls.Add(rushOrderLabel);
            Controls.Add(rushBox);
            Controls.Add(materialLabel);
            Controls.Add(surfaceBox);
            Controls.Add(drawerLabel);
            Controls.Add(depthLabel);
            Controls.Add(widthLabel);
            Controls.Add(nameLabel);
            Controls.Add(nameInput);
            Controls.Add(drawerUpDown);
            Name = "AddQuote";
            Text = "Add Quote";
            ((System.ComponentModel.ISupportInitialize)drawerUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private NumericUpDown drawerUpDown;
        private TextBox nameInput;
        private Label nameLabel;
        private Label widthLabel;
        private Label depthLabel;
        private Label drawerLabel;
        private ComboBox surfaceBox;
        private Label materialLabel;
        private ComboBox rushBox;
        private Label rushOrderLabel;
        private Button confirmButton;
        private ErrorProvider errorProvider;
        private TextBox depthInput;
        private TextBox widthInput;
    }
}