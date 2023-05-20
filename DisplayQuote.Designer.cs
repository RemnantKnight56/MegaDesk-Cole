namespace MegaDesk_Cole
{
    partial class DisplayQuote
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
            nameLabel = new Label();
            widthLabel = new Label();
            depthLabel = new Label();
            drawerLabel = new Label();
            rushLabel = new Label();
            materialLabel = new Label();
            nameBox = new TextBox();
            widthBox = new TextBox();
            depthBox = new TextBox();
            drawersBox = new TextBox();
            materialBox = new TextBox();
            rushBox = new TextBox();
            exitButton = new Button();
            baseLabel = new Label();
            areaLabel = new Label();
            areaValue = new Label();
            unitLabel = new Label();
            baseValue = new Label();
            areaPriceLabel = new Label();
            areaCostValue = new Label();
            materialCostValue = new Label();
            materialCostLabel = new Label();
            rushOrderValue = new Label();
            rushOrderLabel = new Label();
            totalLabel = new Label();
            totalValue = new Label();
            drawerCostValue = new Label();
            drawerCostLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            nameLabel.Location = new Point(2, 25);
            nameLabel.Margin = new Padding(4, 0, 4, 0);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(169, 28);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Customer Name:";
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            widthLabel.Location = new Point(44, 80);
            widthLabel.Margin = new Padding(4, 0, 4, 0);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(127, 28);
            widthLabel.TabIndex = 1;
            widthLabel.Text = "Desk Width:";
            // 
            // depthLabel
            // 
            depthLabel.AutoSize = true;
            depthLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            depthLabel.Location = new Point(341, 80);
            depthLabel.Margin = new Padding(4, 0, 4, 0);
            depthLabel.Name = "depthLabel";
            depthLabel.Size = new Size(127, 28);
            depthLabel.TabIndex = 2;
            depthLabel.Text = "Desk Depth:";
            // 
            // drawerLabel
            // 
            drawerLabel.AutoSize = true;
            drawerLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            drawerLabel.Location = new Point(32, 130);
            drawerLabel.Margin = new Padding(4, 0, 4, 0);
            drawerLabel.Name = "drawerLabel";
            drawerLabel.Size = new Size(139, 28);
            drawerLabel.TabIndex = 3;
            drawerLabel.Text = "# of Drawers:";
            // 
            // rushLabel
            // 
            rushLabel.AutoSize = true;
            rushLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rushLabel.Location = new Point(354, 134);
            rushLabel.Margin = new Padding(4, 0, 4, 0);
            rushLabel.Name = "rushLabel";
            rushLabel.Size = new Size(114, 28);
            rushLabel.TabIndex = 4;
            rushLabel.Text = "Rush Type:";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            materialLabel.Location = new Point(74, 181);
            materialLabel.Margin = new Padding(4, 0, 4, 0);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new Size(97, 28);
            materialLabel.TabIndex = 5;
            materialLabel.Text = "Material:";
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameBox.Location = new Point(178, 20);
            nameBox.Margin = new Padding(4, 5, 4, 5);
            nameBox.Name = "nameBox";
            nameBox.ReadOnly = true;
            nameBox.Size = new Size(437, 39);
            nameBox.TabIndex = 6;
            // 
            // widthBox
            // 
            widthBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            widthBox.Location = new Point(178, 75);
            widthBox.Margin = new Padding(4, 5, 4, 5);
            widthBox.Name = "widthBox";
            widthBox.ReadOnly = true;
            widthBox.Size = new Size(141, 39);
            widthBox.TabIndex = 7;
            widthBox.TextAlign = HorizontalAlignment.Center;
            // 
            // depthBox
            // 
            depthBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            depthBox.Location = new Point(474, 75);
            depthBox.Margin = new Padding(4, 5, 4, 5);
            depthBox.Name = "depthBox";
            depthBox.ReadOnly = true;
            depthBox.Size = new Size(141, 39);
            depthBox.TabIndex = 8;
            depthBox.TextAlign = HorizontalAlignment.Center;
            // 
            // drawersBox
            // 
            drawersBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            drawersBox.Location = new Point(178, 125);
            drawersBox.Margin = new Padding(4, 5, 4, 5);
            drawersBox.Name = "drawersBox";
            drawersBox.ReadOnly = true;
            drawersBox.Size = new Size(141, 39);
            drawersBox.TabIndex = 9;
            drawersBox.TextAlign = HorizontalAlignment.Center;
            // 
            // materialBox
            // 
            materialBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            materialBox.Location = new Point(178, 176);
            materialBox.Margin = new Padding(4, 5, 4, 5);
            materialBox.Name = "materialBox";
            materialBox.ReadOnly = true;
            materialBox.Size = new Size(141, 39);
            materialBox.TabIndex = 10;
            materialBox.TextAlign = HorizontalAlignment.Center;
            // 
            // rushBox
            // 
            rushBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rushBox.Location = new Point(474, 129);
            rushBox.Margin = new Padding(4, 5, 4, 5);
            rushBox.Name = "rushBox";
            rushBox.ReadOnly = true;
            rushBox.Size = new Size(141, 39);
            rushBox.TabIndex = 11;
            rushBox.TextAlign = HorizontalAlignment.Center;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.Location = new Point(426, 390);
            exitButton.Margin = new Padding(4, 5, 4, 5);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(107, 45);
            exitButton.TabIndex = 12;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += ExitButton_Click;
            // 
            // baseLabel
            // 
            baseLabel.AutoSize = true;
            baseLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            baseLabel.Location = new Point(57, 237);
            baseLabel.Margin = new Padding(4, 0, 4, 0);
            baseLabel.Name = "baseLabel";
            baseLabel.Size = new Size(132, 28);
            baseLabel.TabIndex = 13;
            baseLabel.Text = "Base Price: $";
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            areaLabel.Location = new Point(330, 181);
            areaLabel.Margin = new Padding(4, 0, 4, 0);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new Size(138, 28);
            areaLabel.TabIndex = 14;
            areaLabel.Text = "Surface Area:";
            // 
            // areaValue
            // 
            areaValue.AutoSize = true;
            areaValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            areaValue.Location = new Point(496, 176);
            areaValue.Margin = new Padding(4, 0, 4, 0);
            areaValue.Name = "areaValue";
            areaValue.Size = new Size(27, 32);
            areaValue.TabIndex = 15;
            areaValue.Text = "0";
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.BackColor = SystemColors.ButtonFace;
            unitLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            unitLabel.Location = new Point(567, 176);
            unitLabel.Margin = new Padding(4, 0, 4, 0);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new Size(34, 32);
            unitLabel.TabIndex = 16;
            unitLabel.Text = "in";
            // 
            // baseValue
            // 
            baseValue.AutoSize = true;
            baseValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            baseValue.Location = new Point(194, 237);
            baseValue.Margin = new Padding(4, 0, 4, 0);
            baseValue.Name = "baseValue";
            baseValue.Size = new Size(27, 32);
            baseValue.TabIndex = 17;
            baseValue.Text = "0";
            // 
            // areaPriceLabel
            // 
            areaPriceLabel.AutoSize = true;
            areaPriceLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            areaPriceLabel.Location = new Point(63, 271);
            areaPriceLabel.Margin = new Padding(4, 0, 4, 0);
            areaPriceLabel.Name = "areaPriceLabel";
            areaPriceLabel.Size = new Size(126, 28);
            areaPriceLabel.TabIndex = 18;
            areaPriceLabel.Text = "Area Cost: $";
            // 
            // areaCostValue
            // 
            areaCostValue.AutoSize = true;
            areaCostValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            areaCostValue.Location = new Point(194, 271);
            areaCostValue.Margin = new Padding(4, 0, 4, 0);
            areaCostValue.Name = "areaCostValue";
            areaCostValue.Size = new Size(27, 32);
            areaCostValue.TabIndex = 19;
            areaCostValue.Text = "0";
            // 
            // materialCostValue
            // 
            materialCostValue.AutoSize = true;
            materialCostValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            materialCostValue.Location = new Point(194, 339);
            materialCostValue.Margin = new Padding(4, 0, 4, 0);
            materialCostValue.Name = "materialCostValue";
            materialCostValue.Size = new Size(27, 32);
            materialCostValue.TabIndex = 21;
            materialCostValue.Text = "0";
            // 
            // materialCostLabel
            // 
            materialCostLabel.AutoSize = true;
            materialCostLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            materialCostLabel.Location = new Point(27, 339);
            materialCostLabel.Margin = new Padding(4, 0, 4, 0);
            materialCostLabel.Name = "materialCostLabel";
            materialCostLabel.Size = new Size(162, 28);
            materialCostLabel.TabIndex = 20;
            materialCostLabel.Text = "Material Cost: $";
            // 
            // rushOrderValue
            // 
            rushOrderValue.AutoSize = true;
            rushOrderValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rushOrderValue.Location = new Point(194, 373);
            rushOrderValue.Margin = new Padding(4, 0, 4, 0);
            rushOrderValue.Name = "rushOrderValue";
            rushOrderValue.Size = new Size(27, 32);
            rushOrderValue.TabIndex = 23;
            rushOrderValue.Text = "0";
            // 
            // rushOrderLabel
            // 
            rushOrderLabel.AutoSize = true;
            rushOrderLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rushOrderLabel.Location = new Point(1, 373);
            rushOrderLabel.Margin = new Padding(4, 0, 4, 0);
            rushOrderLabel.Name = "rushOrderLabel";
            rushOrderLabel.Size = new Size(188, 28);
            rushOrderLabel.TabIndex = 22;
            rushOrderLabel.Text = "Rush Order Cost: $";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            totalLabel.Location = new Point(107, 407);
            totalLabel.Margin = new Padding(4, 0, 4, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(82, 28);
            totalLabel.TabIndex = 24;
            totalLabel.Text = "Total: $";
            // 
            // totalValue
            // 
            totalValue.AutoSize = true;
            totalValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            totalValue.Location = new Point(194, 407);
            totalValue.Margin = new Padding(4, 0, 4, 0);
            totalValue.Name = "totalValue";
            totalValue.Size = new Size(27, 32);
            totalValue.TabIndex = 25;
            totalValue.Text = "0";
            // 
            // drawerCostValue
            // 
            drawerCostValue.AutoSize = true;
            drawerCostValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            drawerCostValue.Location = new Point(194, 305);
            drawerCostValue.Margin = new Padding(4, 0, 4, 0);
            drawerCostValue.Name = "drawerCostValue";
            drawerCostValue.Size = new Size(27, 32);
            drawerCostValue.TabIndex = 27;
            drawerCostValue.Text = "0";
            // 
            // drawerCostLabel
            // 
            drawerCostLabel.AutoSize = true;
            drawerCostLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            drawerCostLabel.Location = new Point(38, 305);
            drawerCostLabel.Margin = new Padding(4, 0, 4, 0);
            drawerCostLabel.Name = "drawerCostLabel";
            drawerCostLabel.Size = new Size(151, 28);
            drawerCostLabel.TabIndex = 26;
            drawerCostLabel.Text = "Drawer Cost: $";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(592, 169);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(23, 28);
            label1.TabIndex = 28;
            label1.Text = "2";
            // 
            // DisplayQuote
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 464);
            Controls.Add(label1);
            Controls.Add(unitLabel);
            Controls.Add(drawerCostValue);
            Controls.Add(drawerCostLabel);
            Controls.Add(totalValue);
            Controls.Add(totalLabel);
            Controls.Add(rushOrderValue);
            Controls.Add(rushOrderLabel);
            Controls.Add(materialCostValue);
            Controls.Add(materialCostLabel);
            Controls.Add(areaCostValue);
            Controls.Add(areaPriceLabel);
            Controls.Add(baseValue);
            Controls.Add(areaValue);
            Controls.Add(areaLabel);
            Controls.Add(baseLabel);
            Controls.Add(exitButton);
            Controls.Add(rushBox);
            Controls.Add(materialBox);
            Controls.Add(drawersBox);
            Controls.Add(depthBox);
            Controls.Add(widthBox);
            Controls.Add(nameBox);
            Controls.Add(materialLabel);
            Controls.Add(rushLabel);
            Controls.Add(drawerLabel);
            Controls.Add(depthLabel);
            Controls.Add(widthLabel);
            Controls.Add(nameLabel);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "DisplayQuote";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Display Quote";
            FormClosed += DisplayQuote_FormClosed;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label nameLabel;
        private Label widthLabel;
        private Label depthLabel;
        private Label drawerLabel;
        private Label rushLabel;
        private Label materialLabel;
        private TextBox nameBox;
        private TextBox widthBox;
        private TextBox depthBox;
        private TextBox drawersBox;
        private TextBox materialBox;
        private TextBox rushBox;
        private Button exitButton;
        private Label baseLabel;
        private Label areaLabel;
        private Label areaValue;
        private Label unitLabel;
        private Label baseValue;
        private Label areaPriceLabel;
        private Label areaCostValue;
        private Label materialCostValue;
        private Label materialCostLabel;
        private Label rushOrderValue;
        private Label rushOrderLabel;
        private Label totalLabel;
        private Label totalValue;
        private Label drawerCostValue;
        private Label drawerCostLabel;
        private Label label1;
    }
}