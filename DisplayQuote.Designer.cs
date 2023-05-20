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
            nameLabel.Location = new Point(1, 15);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new Size(121, 19);
            nameLabel.TabIndex = 0;
            nameLabel.Text = "Customer Name:";
            // 
            // widthLabel
            // 
            widthLabel.AutoSize = true;
            widthLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            widthLabel.Location = new Point(31, 48);
            widthLabel.Name = "widthLabel";
            widthLabel.Size = new Size(89, 19);
            widthLabel.TabIndex = 1;
            widthLabel.Text = "Desk Width:";
            // 
            // depthLabel
            // 
            depthLabel.AutoSize = true;
            depthLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            depthLabel.Location = new Point(239, 48);
            depthLabel.Name = "depthLabel";
            depthLabel.Size = new Size(89, 19);
            depthLabel.TabIndex = 2;
            depthLabel.Text = "Desk Depth:";
            // 
            // drawerLabel
            // 
            drawerLabel.AutoSize = true;
            drawerLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            drawerLabel.Location = new Point(22, 78);
            drawerLabel.Name = "drawerLabel";
            drawerLabel.Size = new Size(98, 19);
            drawerLabel.TabIndex = 3;
            drawerLabel.Text = "# of Drawers:";
            // 
            // rushLabel
            // 
            rushLabel.AutoSize = true;
            rushLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rushLabel.Location = new Point(248, 80);
            rushLabel.Name = "rushLabel";
            rushLabel.Size = new Size(80, 19);
            rushLabel.TabIndex = 4;
            rushLabel.Text = "Rush Type:";
            // 
            // materialLabel
            // 
            materialLabel.AutoSize = true;
            materialLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            materialLabel.Location = new Point(52, 109);
            materialLabel.Name = "materialLabel";
            materialLabel.Size = new Size(69, 19);
            materialLabel.TabIndex = 5;
            materialLabel.Text = "Material:";
            // 
            // nameBox
            // 
            nameBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameBox.Location = new Point(125, 12);
            nameBox.Name = "nameBox";
            nameBox.ReadOnly = true;
            nameBox.Size = new Size(307, 29);
            nameBox.TabIndex = 6;
            // 
            // widthBox
            // 
            widthBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            widthBox.Location = new Point(125, 45);
            widthBox.Name = "widthBox";
            widthBox.ReadOnly = true;
            widthBox.Size = new Size(100, 29);
            widthBox.TabIndex = 7;
            widthBox.TextAlign = HorizontalAlignment.Center;
            // 
            // depthBox
            // 
            depthBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            depthBox.Location = new Point(332, 45);
            depthBox.Name = "depthBox";
            depthBox.ReadOnly = true;
            depthBox.Size = new Size(100, 29);
            depthBox.TabIndex = 8;
            depthBox.TextAlign = HorizontalAlignment.Center;
            // 
            // drawersBox
            // 
            drawersBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            drawersBox.Location = new Point(125, 75);
            drawersBox.Name = "drawersBox";
            drawersBox.ReadOnly = true;
            drawersBox.Size = new Size(100, 29);
            drawersBox.TabIndex = 9;
            drawersBox.TextAlign = HorizontalAlignment.Center;
            // 
            // materialBox
            // 
            materialBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            materialBox.Location = new Point(125, 106);
            materialBox.Name = "materialBox";
            materialBox.ReadOnly = true;
            materialBox.Size = new Size(100, 29);
            materialBox.TabIndex = 10;
            materialBox.TextAlign = HorizontalAlignment.Center;
            // 
            // rushBox
            // 
            rushBox.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rushBox.Location = new Point(332, 77);
            rushBox.Name = "rushBox";
            rushBox.ReadOnly = true;
            rushBox.Size = new Size(100, 29);
            rushBox.TabIndex = 11;
            rushBox.TextAlign = HorizontalAlignment.Center;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            exitButton.Location = new Point(298, 234);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 27);
            exitButton.TabIndex = 12;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += ExitButton_Click;
            // 
            // baseLabel
            // 
            baseLabel.AutoSize = true;
            baseLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            baseLabel.Location = new Point(40, 142);
            baseLabel.Name = "baseLabel";
            baseLabel.Size = new Size(94, 19);
            baseLabel.TabIndex = 13;
            baseLabel.Text = "Base Price: $";
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            areaLabel.Location = new Point(231, 109);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new Size(99, 19);
            areaLabel.TabIndex = 14;
            areaLabel.Text = "Surface Area:";
            // 
            // areaValue
            // 
            areaValue.AutoSize = true;
            areaValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            areaValue.Location = new Point(347, 106);
            areaValue.Name = "areaValue";
            areaValue.Size = new Size(19, 21);
            areaValue.TabIndex = 15;
            areaValue.Text = "0";
            // 
            // unitLabel
            // 
            unitLabel.AutoSize = true;
            unitLabel.BackColor = SystemColors.ButtonFace;
            unitLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            unitLabel.Location = new Point(372, 107);
            unitLabel.Name = "unitLabel";
            unitLabel.Size = new Size(23, 21);
            unitLabel.TabIndex = 16;
            unitLabel.Text = "in";
            // 
            // baseValue
            // 
            baseValue.AutoSize = true;
            baseValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            baseValue.Location = new Point(136, 142);
            baseValue.Name = "baseValue";
            baseValue.Size = new Size(19, 21);
            baseValue.TabIndex = 17;
            baseValue.Text = "0";
            // 
            // areaPriceLabel
            // 
            areaPriceLabel.AutoSize = true;
            areaPriceLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            areaPriceLabel.Location = new Point(44, 163);
            areaPriceLabel.Name = "areaPriceLabel";
            areaPriceLabel.Size = new Size(90, 19);
            areaPriceLabel.TabIndex = 18;
            areaPriceLabel.Text = "Area Cost: $";
            // 
            // areaCostValue
            // 
            areaCostValue.AutoSize = true;
            areaCostValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            areaCostValue.Location = new Point(136, 163);
            areaCostValue.Name = "areaCostValue";
            areaCostValue.Size = new Size(19, 21);
            areaCostValue.TabIndex = 19;
            areaCostValue.Text = "0";
            // 
            // materialCostValue
            // 
            materialCostValue.AutoSize = true;
            materialCostValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            materialCostValue.Location = new Point(136, 203);
            materialCostValue.Name = "materialCostValue";
            materialCostValue.Size = new Size(19, 21);
            materialCostValue.TabIndex = 21;
            materialCostValue.Text = "0";
            // 
            // materialCostLabel
            // 
            materialCostLabel.AutoSize = true;
            materialCostLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            materialCostLabel.Location = new Point(19, 203);
            materialCostLabel.Name = "materialCostLabel";
            materialCostLabel.Size = new Size(114, 19);
            materialCostLabel.TabIndex = 20;
            materialCostLabel.Text = "Material Cost: $";
            // 
            // rushOrderValue
            // 
            rushOrderValue.AutoSize = true;
            rushOrderValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rushOrderValue.Location = new Point(136, 224);
            rushOrderValue.Name = "rushOrderValue";
            rushOrderValue.Size = new Size(19, 21);
            rushOrderValue.TabIndex = 23;
            rushOrderValue.Text = "0";
            // 
            // rushOrderLabel
            // 
            rushOrderLabel.AutoSize = true;
            rushOrderLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            rushOrderLabel.Location = new Point(1, 224);
            rushOrderLabel.Name = "rushOrderLabel";
            rushOrderLabel.Size = new Size(133, 19);
            rushOrderLabel.TabIndex = 22;
            rushOrderLabel.Text = "Rush Order Cost: $";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            totalLabel.Location = new Point(75, 244);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(58, 19);
            totalLabel.TabIndex = 24;
            totalLabel.Text = "Total: $";
            // 
            // totalValue
            // 
            totalValue.AutoSize = true;
            totalValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            totalValue.Location = new Point(136, 244);
            totalValue.Name = "totalValue";
            totalValue.Size = new Size(19, 21);
            totalValue.TabIndex = 25;
            totalValue.Text = "0";
            // 
            // drawerCostValue
            // 
            drawerCostValue.AutoSize = true;
            drawerCostValue.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            drawerCostValue.Location = new Point(136, 183);
            drawerCostValue.Name = "drawerCostValue";
            drawerCostValue.Size = new Size(19, 21);
            drawerCostValue.TabIndex = 27;
            drawerCostValue.Text = "0";
            // 
            // drawerCostLabel
            // 
            drawerCostLabel.AutoSize = true;
            drawerCostLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            drawerCostLabel.Location = new Point(27, 183);
            drawerCostLabel.Name = "drawerCostLabel";
            drawerCostLabel.Size = new Size(107, 19);
            drawerCostLabel.TabIndex = 26;
            drawerCostLabel.Text = "Drawer Cost: $";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(391, 106);
            label1.Name = "label1";
            label1.Size = new Size(17, 19);
            label1.TabIndex = 28;
            label1.Text = "2";
            // 
            // DisplayQuote
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(448, 278);
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