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
            drawerUpDown.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            drawerUpDown.Location = new Point(480, 106);
            drawerUpDown.Margin = new Padding(4, 5, 4, 5);
            drawerUpDown.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            drawerUpDown.Name = "drawerUpDown";
            drawerUpDown.Size = new Size(125, 39);
            drawerUpDown.TabIndex = 4;
            drawerUpDown.TextAlign = HorizontalAlignment.Right;
            drawerUpDown.Validating += drawerUpDown_Validating;
            // 
            // nameInput
            // 
            nameInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameInput.Location = new Point(202, 42);
            nameInput.Margin = new Padding(4, 5, 4, 5);
            nameInput.Name = "nameInput";
            nameInput.Size = new Size(403, 39);
            nameInput.TabIndex = 1;
            nameInput.Validating += nameInput_Validating;
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(17, 48);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(164, 28);
            nameLabel.TabIndex = 4;
            nameLabel.Text = "Customer Name";
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            widthLabel.Location = new Point(17, 111);
            widthLabel.Margin = new Padding(4, 0, 4, 0);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(165, 28);
            widthLabel.TabIndex = 5;
            widthLabel.Text = "Desk Width (in.)";
            // 
            // depthLabel
            // 
            depthLabel.AutoSize = true;
            depthLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            depthLabel.Location = new Point(17, 162);
            depthLabel.Margin = new Padding(4, 0, 4, 0);
            depthLabel.Name = "depthLabel";
            depthLabel.Size = new Size(165, 28);
            depthLabel.TabIndex = 6;
            depthLabel.Text = "Desk Depth (in.)";
            // 
            // drawerLabel
            // 
            drawerLabel.AutoSize = true;
            drawerLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            drawerLabel.Location = new Point(340, 112);
            drawerLabel.Margin = new Padding(4, 0, 4, 0);
            drawerLabel.Name = "drawerLabel";
            drawerLabel.Size = new Size(134, 28);
            drawerLabel.TabIndex = 7;
            drawerLabel.Text = "# of Drawers";
            // 
            // surfaceBox
            // 
            surfaceBox.DropDownStyle = ComboBoxStyle.DropDownList;
            surfaceBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            surfaceBox.FormattingEnabled = true;
            surfaceBox.Items.AddRange(new object[] { "Pine", "Laminate", "Veneer", "Oak", "Rosewood" });
            surfaceBox.Location = new Point(205, 230);
            surfaceBox.Margin = new Padding(4, 5, 4, 5);
            surfaceBox.MaxDropDownItems = 5;
            surfaceBox.Name = "surfaceBox";
            surfaceBox.Size = new Size(400, 40);
            surfaceBox.TabIndex = 5;
            surfaceBox.Validating += surfaceBox_Validating;
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            materialLabel.Location = new Point(17, 230);
            materialLabel.Margin = new Padding(4, 0, 4, 0);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new Size(169, 28);
            materialLabel.TabIndex = 9;
            materialLabel.Text = "Surface Material";
            // 
            // rushBox
            // 
            rushBox.DropDownStyle = ComboBoxStyle.DropDownList;
            rushBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rushBox.FormattingEnabled = true;
            rushBox.Items.AddRange(new object[] { "N/A", "3 Days", "5 Days", "7 Days" });
            rushBox.Location = new Point(480, 164);
            rushBox.Margin = new Padding(4, 5, 4, 5);
            rushBox.MaxDropDownItems = 5;
            rushBox.Name = "rushBox";
            rushBox.Size = new Size(125, 40);
            rushBox.TabIndex = 6;
            rushBox.Validating += rushBox_Validating;
            // 
            // rushOrderLabel
            // 
            rushOrderLabel.AutoSize = true;
            rushOrderLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rushOrderLabel.Location = new Point(340, 170);
            rushOrderLabel.Margin = new Padding(4, 0, 4, 0);
            rushOrderLabel.Name = "rushOrderLabel";
            rushOrderLabel.Size = new Size(127, 28);
            rushOrderLabel.TabIndex = 11;
            rushOrderLabel.Text = "Rush Order?";
            // 
            // confirmButton
            // 
            confirmButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            confirmButton.Location = new Point(255, 297);
            confirmButton.Margin = new Padding(4, 5, 4, 5);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(141, 62);
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
            depthInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            depthInput.Location = new Point(205, 170);
            depthInput.Margin = new Padding(4, 5, 4, 5);
            depthInput.MaxLength = 4;
            depthInput.Name = "depthInput";
            depthInput.Size = new Size(115, 39);
            depthInput.TabIndex = 3;
            depthInput.Text = "0";
            depthInput.TextAlign = HorizontalAlignment.Right;
            depthInput.Validating += depthInput_Validating;
            // 
            // widthInput
            // 
            widthInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            widthInput.Location = new Point(205, 106);
            widthInput.Margin = new Padding(4, 5, 4, 5);
            widthInput.MaxLength = 4;
            widthInput.Name = "widthInput";
            widthInput.Size = new Size(116, 39);
            widthInput.TabIndex = 2;
            widthInput.Text = "0";
            widthInput.TextAlign = HorizontalAlignment.Right;
            widthInput.Validating += widthInput_Validating;
            // 
            // AddQuote
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(629, 384);
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
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AddQuote";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Quote";
            FormClosed += AddQuote_FormClosed;
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