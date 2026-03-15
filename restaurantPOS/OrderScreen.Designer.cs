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
            tableLabel = new Label();
            orderedItemsListbox = new ListBox();
            deleteItemButton = new Button();
            modificationsTextBox = new TextBox();
            modifyButton = new Button();
            totalLabel = new Label();
            taxLabel = new Label();
            subtotalLabel = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
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
            menuCategoryPanel.BackColor = SystemColors.Control;
            menuCategoryPanel.FlowDirection = FlowDirection.TopDown;
            menuCategoryPanel.Location = new Point(764, 130);
            menuCategoryPanel.Name = "menuCategoryPanel";
            menuCategoryPanel.Size = new Size(320, 1626);
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
            viewTablesButton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewTablesButton.Location = new Point(1818, 1805);
            viewTablesButton.Margin = new Padding(3, 4, 3, 4);
            viewTablesButton.Name = "viewTablesButton";
            viewTablesButton.Size = new Size(190, 157);
            viewTablesButton.TabIndex = 4;
            viewTablesButton.Text = "View Tables";
            viewTablesButton.UseVisualStyleBackColor = true;
            viewTablesButton.Click += viewTablesButton_Click;
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
            // orderedItemsListbox
            // 
            orderedItemsListbox.BackColor = SystemColors.Window;
            orderedItemsListbox.FormattingEnabled = true;
            orderedItemsListbox.Location = new Point(88, 130);
            orderedItemsListbox.Name = "orderedItemsListbox";
            orderedItemsListbox.Size = new Size(562, 1476);
            orderedItemsListbox.TabIndex = 7;
            // 
            // deleteItemButton
            // 
            deleteItemButton.Location = new Point(88, 1844);
            deleteItemButton.Name = "deleteItemButton";
            deleteItemButton.Size = new Size(166, 58);
            deleteItemButton.TabIndex = 8;
            deleteItemButton.Text = "Delete";
            deleteItemButton.UseVisualStyleBackColor = true;
            deleteItemButton.Click += deleteItemButton_Click;
            // 
            // modificationsTextBox
            // 
            modificationsTextBox.Location = new Point(88, 1782);
            modificationsTextBox.Name = "modificationsTextBox";
            modificationsTextBox.PlaceholderText = "Enter Modifications Here:";
            modificationsTextBox.Size = new Size(562, 39);
            modificationsTextBox.TabIndex = 9;
            // 
            // modifyButton
            // 
            modifyButton.Location = new Point(260, 1844);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(166, 58);
            modifyButton.TabIndex = 10;
            modifyButton.Text = "Modify";
            modifyButton.UseVisualStyleBackColor = true;
            modifyButton.Click += modifyButton_Click;
            // 
            // totalLabel
            // 
            totalLabel.Location = new Point(212, 1724);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(444, 32);
            totalLabel.TabIndex = 11;
            totalLabel.Text = "Total: $0.00";
            totalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // taxLabel
            // 
            taxLabel.Location = new Point(174, 1674);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new Size(482, 32);
            taxLabel.TabIndex = 12;
            taxLabel.Text = "Tax: $0.00";
            taxLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // subtotalLabel
            // 
            subtotalLabel.Anchor = AnchorStyles.Right;
            subtotalLabel.Location = new Point(156, 1624);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new Size(500, 32);
            subtotalLabel.TabIndex = 13;
            subtotalLabel.Text = "Subtotal: $0.00";
            subtotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(975, 1804);
            button2.Name = "button2";
            button2.Size = new Size(176, 138);
            button2.TabIndex = 14;
            button2.Text = "Close Check";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // OrderScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            Controls.Add(button2);
            Controls.Add(subtotalLabel);
            Controls.Add(taxLabel);
            Controls.Add(totalLabel);
            Controls.Add(modifyButton);
            Controls.Add(modificationsTextBox);
            Controls.Add(deleteItemButton);
            Controls.Add(orderedItemsListbox);
            Controls.Add(tableLabel);
            Controls.Add(viewTablesButton);
            Controls.Add(menuItemsPanel);
            Controls.Add(menuCategoryPanel);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrderScreen";
            Size = new Size(2219, 1966);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private FlowLayoutPanel menuCategoryPanel;
        private FlowLayoutPanel menuItemsPanel;
        private Button viewTablesButton;
        private Label tableLabel;
        private ListBox orderedItemsListbox;
        private Button deleteItemButton;
        private TextBox modificationsTextBox;
        private Button modifyButton;
        private Label totalLabel;
        private Label taxLabel;
        private Label subtotalLabel;
        private Button button2;
    }
}
