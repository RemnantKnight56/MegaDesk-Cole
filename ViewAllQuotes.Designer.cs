namespace MegaDesk_Cole
{
    partial class ViewAllQuotes
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
            exitButton = new Button();
            rushDaysColumn = new DataGridViewTextBoxColumn();
            drawerColumn = new DataGridViewTextBoxColumn();
            depthsColumn = new DataGridViewTextBoxColumn();
            widthsColumn = new DataGridViewTextBoxColumn();
            pricesColumn = new DataGridViewTextBoxColumn();
            datesColumn = new DataGridViewTextBoxColumn();
            namesColumn = new DataGridViewTextBoxColumn();
            materialsColumn = new DataGridViewTextBoxColumn();
            dataGrid = new DataGridView();
            DrawersColumn = new DataGridViewTextBoxColumn();
            DepthColumn = new DataGridViewTextBoxColumn();
            WidthColumn = new DataGridViewTextBoxColumn();
            PriceColumn = new DataGridViewTextBoxColumn();
            DateColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            label1 = new Label();
            deskQuoteBindingSource = new BindingSource(components);
            comboBox1 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deskQuoteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Location = new Point(780, 332);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 7;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // rushDaysColumn
            // 
            rushDaysColumn.HeaderText = "Rush Order?";
            rushDaysColumn.Name = "rushDaysColumn";
            // 
            // drawerColumn
            // 
            drawerColumn.HeaderText = "Drawers";
            drawerColumn.Name = "drawerColumn";
            // 
            // depthsColumn
            // 
            depthsColumn.HeaderText = "Depth";
            depthsColumn.Name = "depthsColumn";
            // 
            // widthsColumn
            // 
            widthsColumn.HeaderText = "Width";
            widthsColumn.Name = "widthsColumn";
            // 
            // pricesColumn
            // 
            pricesColumn.HeaderText = "Price";
            pricesColumn.Name = "pricesColumn";
            // 
            // datesColumn
            // 
            datesColumn.HeaderText = "Date";
            datesColumn.Name = "datesColumn";
            // 
            // namesColumn
            // 
            namesColumn.HeaderText = "Name";
            namesColumn.Name = "namesColumn";
            // 
            // materialsColumn
            // 
            materialsColumn.HeaderText = "Material";
            materialsColumn.Name = "materialsColumn";
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToOrderColumns = true;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { namesColumn, datesColumn, pricesColumn, widthsColumn, depthsColumn, drawerColumn, rushDaysColumn, materialsColumn });
            dataGrid.Location = new Point(12, 47);
            dataGrid.Name = "dataGrid";
            dataGrid.RowTemplate.Height = 25;
            dataGrid.Size = new Size(848, 279);
            dataGrid.TabIndex = 6;
            // 
            // DrawersColumn
            // 
            DrawersColumn.HeaderText = "Drawers";
            DrawersColumn.Name = "DrawersColumn";
            // 
            // DepthColumn
            // 
            DepthColumn.HeaderText = "Depth";
            DepthColumn.Name = "DepthColumn";
            // 
            // WidthColumn
            // 
            WidthColumn.HeaderText = "Width";
            WidthColumn.Name = "WidthColumn";
            // 
            // PriceColumn
            // 
            PriceColumn.HeaderText = "Price";
            PriceColumn.Name = "PriceColumn";
            // 
            // DateColumn
            // 
            DateColumn.HeaderText = "Date";
            DateColumn.Name = "DateColumn";
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Name";
            NameColumn.Name = "NameColumn";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 5;
            label1.Text = "Search By Material";
            // 
            // deskQuoteBindingSource
            // 
            deskQuoteBindingSource.DataSource = typeof(DeskQuote);
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(170, 9);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            // 
            // ViewAllQuotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(867, 363);
            Controls.Add(exitButton);
            Controls.Add(dataGrid);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "ViewAllQuotes";
            Text = "View All Quotes";
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)deskQuoteBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button exitButton;
        private DataGridViewTextBoxColumn rushDaysColumn;
        private DataGridViewTextBoxColumn drawerColumn;
        private DataGridViewTextBoxColumn depthsColumn;
        private DataGridViewTextBoxColumn widthsColumn;
        private DataGridViewTextBoxColumn pricesColumn;
        private DataGridViewTextBoxColumn datesColumn;
        private DataGridViewTextBoxColumn namesColumn;
        private DataGridViewTextBoxColumn materialsColumn;
        private DataGridView dataGrid;
        private DataGridViewTextBoxColumn DrawersColumn;
        private DataGridViewTextBoxColumn DepthColumn;
        private DataGridViewTextBoxColumn WidthColumn;
        private DataGridViewTextBoxColumn PriceColumn;
        private DataGridViewTextBoxColumn DateColumn;
        private DataGridViewTextBoxColumn NameColumn;
        private Label label1;
        private BindingSource deskQuoteBindingSource;
        private ComboBox comboBox1;
    }
}