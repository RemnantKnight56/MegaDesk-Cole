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
            deskQuoteBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGrid).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deskQuoteBindingSource).BeginInit();
            SuspendLayout();
            // 
            // exitButton
            // 
            exitButton.Location = new Point(558, 510);
            exitButton.Margin = new Padding(4, 5, 4, 5);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(107, 38);
            exitButton.TabIndex = 7;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // rushDaysColumn
            // 
            rushDaysColumn.HeaderText = "Rush Order?";
            rushDaysColumn.MinimumWidth = 8;
            rushDaysColumn.Name = "rushDaysColumn";
            rushDaysColumn.Width = 150;
            // 
            // drawerColumn
            // 
            drawerColumn.HeaderText = "Drawers";
            drawerColumn.MinimumWidth = 8;
            drawerColumn.Name = "drawerColumn";
            drawerColumn.Width = 150;
            // 
            // depthsColumn
            // 
            depthsColumn.HeaderText = "Depth";
            depthsColumn.MinimumWidth = 8;
            depthsColumn.Name = "depthsColumn";
            depthsColumn.Width = 150;
            // 
            // widthsColumn
            // 
            widthsColumn.HeaderText = "Width";
            widthsColumn.MinimumWidth = 8;
            widthsColumn.Name = "widthsColumn";
            widthsColumn.Width = 150;
            // 
            // pricesColumn
            // 
            pricesColumn.HeaderText = "Price";
            pricesColumn.MinimumWidth = 8;
            pricesColumn.Name = "pricesColumn";
            pricesColumn.Width = 150;
            // 
            // datesColumn
            // 
            datesColumn.HeaderText = "Date";
            datesColumn.MinimumWidth = 8;
            datesColumn.Name = "datesColumn";
            datesColumn.Width = 150;
            // 
            // namesColumn
            // 
            namesColumn.HeaderText = "Name";
            namesColumn.MinimumWidth = 8;
            namesColumn.Name = "namesColumn";
            namesColumn.Width = 150;
            // 
            // materialsColumn
            // 
            materialsColumn.HeaderText = "Material";
            materialsColumn.MinimumWidth = 8;
            materialsColumn.Name = "materialsColumn";
            materialsColumn.Width = 150;
            // 
            // dataGrid
            // 
            dataGrid.AllowUserToAddRows = false;
            dataGrid.AllowUserToDeleteRows = false;
            dataGrid.AllowUserToOrderColumns = true;
            dataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid.Columns.AddRange(new DataGridViewColumn[] { namesColumn, datesColumn, pricesColumn, widthsColumn, depthsColumn, drawerColumn, rushDaysColumn, materialsColumn });
            dataGrid.Location = new Point(17, 26);
            dataGrid.Margin = new Padding(4, 5, 4, 5);
            dataGrid.MultiSelect = false;
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 62;
            dataGrid.RowTemplate.Height = 25;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.Size = new Size(1211, 465);
            dataGrid.TabIndex = 6;
            dataGrid.CellDoubleClick += dataGrid_CellDoubleClick;
            // 
            // DrawersColumn
            // 
            DrawersColumn.HeaderText = "Drawers";
            DrawersColumn.MinimumWidth = 8;
            DrawersColumn.Name = "DrawersColumn";
            DrawersColumn.Width = 150;
            // 
            // DepthColumn
            // 
            DepthColumn.HeaderText = "Depth";
            DepthColumn.MinimumWidth = 8;
            DepthColumn.Name = "DepthColumn";
            DepthColumn.Width = 150;
            // 
            // WidthColumn
            // 
            WidthColumn.HeaderText = "Width";
            WidthColumn.MinimumWidth = 8;
            WidthColumn.Name = "WidthColumn";
            WidthColumn.Width = 150;
            // 
            // PriceColumn
            // 
            PriceColumn.HeaderText = "Price";
            PriceColumn.MinimumWidth = 8;
            PriceColumn.Name = "PriceColumn";
            PriceColumn.Width = 150;
            // 
            // DateColumn
            // 
            DateColumn.HeaderText = "Date";
            DateColumn.MinimumWidth = 8;
            DateColumn.Name = "DateColumn";
            DateColumn.Width = 150;
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Name";
            NameColumn.MinimumWidth = 8;
            NameColumn.Name = "NameColumn";
            NameColumn.Width = 150;
            // 
            // deskQuoteBindingSource
            // 
            deskQuoteBindingSource.DataSource = typeof(DeskQuote);
            // 
            // ViewAllQuotes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1239, 575);
            Controls.Add(exitButton);
            Controls.Add(dataGrid);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "ViewAllQuotes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "View All Quotes";
            FormClosed += ViewAllQuotes_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ((System.ComponentModel.ISupportInitialize)deskQuoteBindingSource).EndInit();
            ResumeLayout(false);
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
        private BindingSource deskQuoteBindingSource;
    }
}