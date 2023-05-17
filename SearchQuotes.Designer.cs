namespace MegaDesk_Cole
{
    partial class SearchQuotes
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
            comboBox1 = new ComboBox();
            label1 = new Label();
            NameColumn = new DataGridViewTextBoxColumn();
            DateColumn = new DataGridViewTextBoxColumn();
            PriceColumn = new DataGridViewTextBoxColumn();
            WidthColumn = new DataGridViewTextBoxColumn();
            DepthColumn = new DataGridViewTextBoxColumn();
            DrawersColumn = new DataGridViewTextBoxColumn();
            deskQuoteBindingSource = new BindingSource(components);
            dataGrid = new DataGridView();
            namesColumn = new DataGridViewTextBoxColumn();
            datesColumn = new DataGridViewTextBoxColumn();
            pricesColumn = new DataGridViewTextBoxColumn();
            widthsColumn = new DataGridViewTextBoxColumn();
            depthsColumn = new DataGridViewTextBoxColumn();
            drawerColumn = new DataGridViewTextBoxColumn();
            rushDaysColumn = new DataGridViewTextBoxColumn();
            materialsColumn = new DataGridViewTextBoxColumn();
            exitButton = new Button();
            ((System.ComponentModel.ISupportInitialize)deskQuoteBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(170, 17);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(111, 15);
            label1.TabIndex = 1;
            label1.Text = "Search By Material";
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Name";
            NameColumn.Name = "NameColumn";
            // 
            // DateColumn
            // 
            DateColumn.HeaderText = "Date";
            DateColumn.Name = "DateColumn";
            // 
            // PriceColumn
            // 
            PriceColumn.HeaderText = "Price";
            PriceColumn.Name = "PriceColumn";
            // 
            // WidthColumn
            // 
            WidthColumn.HeaderText = "Width";
            WidthColumn.Name = "WidthColumn";
            // 
            // DepthColumn
            // 
            DepthColumn.HeaderText = "Depth";
            DepthColumn.Name = "DepthColumn";
            // 
            // DrawersColumn
            // 
            DrawersColumn.HeaderText = "Drawers";
            DrawersColumn.Name = "DrawersColumn";
            // 
            // deskQuoteBindingSource
            // 
            deskQuoteBindingSource.DataSource = typeof(DeskQuote);
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToOrderColumns = true;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { namesColumn, datesColumn, pricesColumn, widthsColumn, depthsColumn, drawerColumn, rushDaysColumn, materialsColumn });
            dataGrid.Location = new Point(12, 63);
            dataGrid.Name = "dataGrid";
            dataGrid.RowTemplate.Height = 25;
            dataGrid.Size = new Size(848, 279);
            dataGrid.TabIndex = 2;
            // 
            // namesColumn
            // 
            namesColumn.HeaderText = "Name";
            namesColumn.Name = "namesColumn";
            // 
            // datesColumn
            // 
            datesColumn.HeaderText = "Date";
            datesColumn.Name = "datesColumn";
            // 
            // pricesColumn
            // 
            pricesColumn.HeaderText = "Price";
            pricesColumn.Name = "pricesColumn";
            // 
            // widthsColumn
            // 
            widthsColumn.HeaderText = "Width";
            widthsColumn.Name = "widthsColumn";
            // 
            // depthsColumn
            // 
            depthsColumn.HeaderText = "Depth";
            depthsColumn.Name = "depthsColumn";
            // 
            // drawerColumn
            // 
            drawerColumn.HeaderText = "Drawers";
            drawerColumn.Name = "drawerColumn";
            // 
            // rushDaysColumn
            // 
            rushDaysColumn.HeaderText = "Rush Order?";
            rushDaysColumn.Name = "rushDaysColumn";
            // 
            // materialsColumn
            // 
            materialsColumn.HeaderText = "Material";
            materialsColumn.Name = "materialsColumn";
            // 
            // exitButton
            // 
            exitButton.Location = new Point(766, 366);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(75, 23);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // SearchQuotes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(872, 401);
            Controls.Add(exitButton);
            Controls.Add(dataGrid);
            Controls.Add(label1);
            Controls.Add(comboBox1);
            Name = "SearchQuotes";
            Text = "Search Quotes";
            ((System.ComponentModel.ISupportInitialize)deskQuoteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label label1;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn DateColumn;
        private DataGridViewTextBoxColumn PriceColumn;
        private DataGridViewTextBoxColumn WidthColumn;
        private DataGridViewTextBoxColumn DepthColumn;
        private DataGridViewTextBoxColumn DrawersColumn;
        private BindingSource deskQuoteBindingSource;
        private DataGridView dataGrid;
        private DataGridViewTextBoxColumn namesColumn;
        private DataGridViewTextBoxColumn datesColumn;
        private DataGridViewTextBoxColumn pricesColumn;
        private DataGridViewTextBoxColumn widthsColumn;
        private DataGridViewTextBoxColumn depthsColumn;
        private DataGridViewTextBoxColumn drawerColumn;
        private DataGridViewTextBoxColumn rushDaysColumn;
        private DataGridViewTextBoxColumn materialsColumn;
        private Button exitButton;
    }
}