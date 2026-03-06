namespace restaurantPOS
{
    partial class OrderScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            menuCategoryPanel = new FlowLayoutPanel();
            menuItemsPanel = new FlowLayoutPanel();
            viewTablesButton = new Button();
            dataGridView1 = new DataGridView();
            tableLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(2026, 1805);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(190, 157);
            button1.TabIndex = 0;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuCategoryPanel
            // 
            menuCategoryPanel.AutoScroll = true;
            menuCategoryPanel.FlowDirection = FlowDirection.TopDown;
            menuCategoryPanel.Location = new Point(732, 130);
            menuCategoryPanel.Name = "menuCategoryPanel";
            menuCategoryPanel.Size = new Size(419, 1626);
            menuCategoryPanel.TabIndex = 1;
            menuCategoryPanel.WrapContents = false;
            // 
            // menuItemsPanel
            // 
            menuItemsPanel.BackColor = SystemColors.ControlLight;
            menuItemsPanel.Location = new Point(1194, 130);
            menuItemsPanel.Name = "menuItemsPanel";
            menuItemsPanel.Size = new Size(972, 1626);
            menuItemsPanel.TabIndex = 2;
            // 
            // viewTablesButton
            // 
            viewTablesButton.Location = new Point(1818, 1805);
            viewTablesButton.Margin = new Padding(3, 4, 3, 4);
            viewTablesButton.Name = "viewTablesButton";
            viewTablesButton.Size = new Size(190, 157);
            viewTablesButton.TabIndex = 4;
            viewTablesButton.Text = "View Tables";
            viewTablesButton.UseVisualStyleBackColor = true;
            viewTablesButton.Click += viewTablesButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(88, 130);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.Size = new Size(550, 1626);
            dataGridView1.TabIndex = 5;
            // 
            // tableLabel
            // 
            tableLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLabel.Location = new Point(88, 44);
            tableLabel.Name = "tableLabel";
            tableLabel.Size = new Size(550, 64);
            tableLabel.TabIndex = 6;
            tableLabel.Text = "Table: Order:";
            tableLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OrderScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLabel);
            Controls.Add(dataGridView1);
            Controls.Add(viewTablesButton);
            Controls.Add(menuItemsPanel);
            Controls.Add(menuCategoryPanel);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrderScreen";
            Size = new Size(2219, 1966);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private FlowLayoutPanel menuCategoryPanel;
        private FlowLayoutPanel menuItemsPanel;
        private Button viewTablesButton;
        private DataGridView dataGridView1;
        private Label tableLabel;
    }
}
