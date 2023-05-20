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
            searchBox = new ComboBox();
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
            // searchBox
            // 
            searchBox.FormattingEnabled = true;
            searchBox.Location = new Point(200, 21);
            searchBox.Margin = new Padding(4, 5, 4, 5);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(171, 33);
            searchBox.TabIndex = 0;
            searchBox.SelectedIndexChanged += SearchBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(17, 26);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 25);
            label1.TabIndex = 1;
            label1.Text = "Search By Material";
            // 
            // NameColumn
            // 
            NameColumn.HeaderText = "Name";
            NameColumn.MinimumWidth = 8;
            NameColumn.Name = "NameColumn";
            NameColumn.Width = 150;
            // 
            // DateColumn
            // 
            DateColumn.HeaderText = "Date";
            DateColumn.MinimumWidth = 8;
            DateColumn.Name = "DateColumn";
            DateColumn.Width = 150;
            // 
            // PriceColumn
            // 
            PriceColumn.HeaderText = "Price";
            PriceColumn.MinimumWidth = 8;
            PriceColumn.Name = "PriceColumn";
            PriceColumn.Width = 150;
            // 
            // WidthColumn
            // 
            WidthColumn.HeaderText = "Width";
            WidthColumn.MinimumWidth = 8;
            WidthColumn.Name = "WidthColumn";
            WidthColumn.Width = 150;
            // 
            // DepthColumn
            // 
            DepthColumn.HeaderText = "Depth";
            DepthColumn.MinimumWidth = 8;
            DepthColumn.Name = "DepthColumn";
            DepthColumn.Width = 150;
            // 
            // DrawersColumn
            // 
            DrawersColumn.HeaderText = "Drawers";
            DrawersColumn.MinimumWidth = 8;
            DrawersColumn.Name = "DrawersColumn";
            DrawersColumn.Width = 150;
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
            dataGrid.Location = new Point(17, 71);
            dataGrid.Margin = new Padding(4, 5, 4, 5);
            dataGrid.Name = "dataGrid";
            dataGrid.RowHeadersWidth = 62;
            dataGrid.RowTemplate.Height = 25;
            dataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGrid.Size = new Size(1211, 571);
            dataGrid.TabIndex = 2;
            // 
            // namesColumn
            // 
            namesColumn.HeaderText = "Name";
            namesColumn.MinimumWidth = 8;
            namesColumn.Name = "namesColumn";
            namesColumn.Width = 150;
            // 
            // datesColumn
            // 
            datesColumn.HeaderText = "Date";
            datesColumn.MinimumWidth = 8;
            datesColumn.Name = "datesColumn";
            datesColumn.Width = 150;
            // 
            // pricesColumn
            // 
            pricesColumn.HeaderText = "Price";
            pricesColumn.MinimumWidth = 8;
            pricesColumn.Name = "pricesColumn";
            pricesColumn.Width = 150;
            // 
            // widthsColumn
            // 
            widthsColumn.HeaderText = "Width";
            widthsColumn.MinimumWidth = 8;
            widthsColumn.Name = "widthsColumn";
            widthsColumn.Width = 150;
            // 
            // depthsColumn
            // 
            depthsColumn.HeaderText = "Depth";
            depthsColumn.MinimumWidth = 8;
            depthsColumn.Name = "depthsColumn";
            depthsColumn.Width = 150;
            // 
            // drawerColumn
            // 
            drawerColumn.HeaderText = "Drawers";
            drawerColumn.MinimumWidth = 8;
            drawerColumn.Name = "drawerColumn";
            drawerColumn.Width = 150;
            // 
            // rushDaysColumn
            // 
            rushDaysColumn.HeaderText = "Rush Order?";
            rushDaysColumn.MinimumWidth = 8;
            rushDaysColumn.Name = "rushDaysColumn";
            rushDaysColumn.Width = 150;
            // 
            // materialsColumn
            // 
            materialsColumn.HeaderText = "Material";
            materialsColumn.MinimumWidth = 8;
            materialsColumn.Name = "materialsColumn";
            materialsColumn.Width = 150;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(1121, 21);
            exitButton.Margin = new Padding(4, 5, 4, 5);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(107, 38);
            exitButton.TabIndex = 3;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += ExitButton_Click;
            // 
            // SearchQuotes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 668);
            Controls.Add(exitButton);
            Controls.Add(dataGrid);
            Controls.Add(label1);
            Controls.Add(searchBox);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "SearchQuotes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Search Quotes";
            FormClosed += SearchQuotes_FormClosed;
            ((System.ComponentModel.ISupportInitialize)deskQuoteBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox searchBox;
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