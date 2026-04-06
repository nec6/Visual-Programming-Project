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
            paymentsLabel = new Label();
            balanceDueLabel = new Label();
            payButton = new Button();
            repeatButton = new Button();
            panel2 = new Panel();
            label3 = new Label();
            employeeNameLabel = new Label();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(1064, 835);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(102, 74);
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
            menuCategoryPanel.Location = new Point(411, 106);
            menuCategoryPanel.Margin = new Padding(2, 1, 2, 1);
            menuCategoryPanel.Name = "menuCategoryPanel";
            menuCategoryPanel.Size = new Size(172, 717);
            menuCategoryPanel.TabIndex = 1;
            menuCategoryPanel.WrapContents = false;
            // 
            // menuItemsPanel
            // 
            menuItemsPanel.BackColor = SystemColors.ControlLight;
            menuItemsPanel.Location = new Point(643, 106);
            menuItemsPanel.Margin = new Padding(2, 1, 2, 1);
            menuItemsPanel.Name = "menuItemsPanel";
            menuItemsPanel.Size = new Size(523, 717);
            menuItemsPanel.TabIndex = 2;
            // 
            // viewTablesButton
            // 
            viewTablesButton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewTablesButton.Location = new Point(943, 835);
            viewTablesButton.Margin = new Padding(2);
            viewTablesButton.Name = "viewTablesButton";
            viewTablesButton.Size = new Size(102, 74);
            viewTablesButton.TabIndex = 4;
            viewTablesButton.Text = "View Tables";
            viewTablesButton.UseVisualStyleBackColor = true;
            viewTablesButton.Click += viewTablesButton_Click;
            // 
            // tableLabel
            // 
            tableLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLabel.Location = new Point(47, 63);
            tableLabel.Margin = new Padding(2, 0, 2, 0);
            tableLabel.Name = "tableLabel";
            tableLabel.Size = new Size(296, 30);
            tableLabel.TabIndex = 6;
            tableLabel.Text = "Table: Order:";
            tableLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // orderedItemsListbox
            // 
            orderedItemsListbox.BackColor = SystemColors.Window;
            orderedItemsListbox.FormattingEnabled = true;
            orderedItemsListbox.Location = new Point(47, 106);
            orderedItemsListbox.Margin = new Padding(2, 1, 2, 1);
            orderedItemsListbox.Name = "orderedItemsListbox";
            orderedItemsListbox.Size = new Size(304, 634);
            orderedItemsListbox.TabIndex = 7;
            // 
            // deleteItemButton
            // 
            deleteItemButton.Location = new Point(47, 882);
            deleteItemButton.Margin = new Padding(2, 1, 2, 1);
            deleteItemButton.Name = "deleteItemButton";
            deleteItemButton.Size = new Size(89, 27);
            deleteItemButton.TabIndex = 8;
            deleteItemButton.Text = "Delete";
            deleteItemButton.UseVisualStyleBackColor = true;
            deleteItemButton.Click += deleteItemButton_Click;
            // 
            // modificationsTextBox
            // 
            modificationsTextBox.Location = new Point(47, 845);
            modificationsTextBox.Margin = new Padding(2, 1, 2, 1);
            modificationsTextBox.Name = "modificationsTextBox";
            modificationsTextBox.PlaceholderText = "Enter Modifications Here:";
            modificationsTextBox.Size = new Size(304, 23);
            modificationsTextBox.TabIndex = 9;
            // 
            // modifyButton
            // 
            modifyButton.Location = new Point(153, 882);
            modifyButton.Margin = new Padding(2, 1, 2, 1);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(89, 27);
            modifyButton.TabIndex = 10;
            modifyButton.Text = "Modify";
            modifyButton.UseVisualStyleBackColor = true;
            modifyButton.Click += modifyButton_Click;
            // 
            // totalLabel
            // 
            totalLabel.Location = new Point(114, 781);
            totalLabel.Margin = new Padding(2, 0, 2, 0);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(239, 15);
            totalLabel.TabIndex = 11;
            totalLabel.Text = "Total: $0.00";
            totalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // taxLabel
            // 
            taxLabel.Location = new Point(94, 766);
            taxLabel.Margin = new Padding(2, 0, 2, 0);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new Size(260, 15);
            taxLabel.TabIndex = 12;
            taxLabel.Text = "Tax: $0.00";
            taxLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // subtotalLabel
            // 
            subtotalLabel.Anchor = AnchorStyles.Right;
            subtotalLabel.Location = new Point(84, 751);
            subtotalLabel.Margin = new Padding(2, 0, 2, 0);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new Size(269, 15);
            subtotalLabel.TabIndex = 13;
            subtotalLabel.Text = "Subtotal: $0.00";
            subtotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(700, 835);
            button2.Margin = new Padding(2, 1, 2, 1);
            button2.Name = "button2";
            button2.Size = new Size(103, 74);
            button2.TabIndex = 14;
            button2.Text = "Close Check";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // paymentsLabel
            // 
            paymentsLabel.Location = new Point(114, 796);
            paymentsLabel.Margin = new Padding(2, 0, 2, 0);
            paymentsLabel.Name = "paymentsLabel";
            paymentsLabel.Size = new Size(239, 15);
            paymentsLabel.TabIndex = 15;
            paymentsLabel.Text = "Payments Applied: $0.00";
            paymentsLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // balanceDueLabel
            // 
            balanceDueLabel.Location = new Point(114, 811);
            balanceDueLabel.Margin = new Padding(2, 0, 2, 0);
            balanceDueLabel.Name = "balanceDueLabel";
            balanceDueLabel.Size = new Size(239, 15);
            balanceDueLabel.TabIndex = 16;
            balanceDueLabel.Text = "Balance Due: $0.00";
            balanceDueLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // payButton
            // 
            payButton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payButton.Location = new Point(824, 835);
            payButton.Margin = new Padding(2, 1, 2, 1);
            payButton.Name = "payButton";
            payButton.Size = new Size(103, 74);
            payButton.TabIndex = 17;
            payButton.Text = "Pay Check";
            payButton.UseVisualStyleBackColor = true;
            payButton.Click += payButton_Click;
            // 
            // repeatButton
            // 
            repeatButton.Location = new Point(261, 882);
            repeatButton.Margin = new Padding(2, 1, 2, 1);
            repeatButton.Name = "repeatButton";
            repeatButton.Size = new Size(89, 27);
            repeatButton.TabIndex = 18;
            repeatButton.Text = "Repeat";
            repeatButton.UseVisualStyleBackColor = true;
            repeatButton.Click += repeatButton_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(26, 26, 46);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(employeeNameLabel);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1200, 50);
            panel2.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Javanese Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(14, 9);
            label3.Name = "label3";
            label3.Size = new Size(160, 34);
            label3.TabIndex = 0;
            label3.Text = "RESTAURANT POS";
            // 
            // employeeNameLabel
            // 
            employeeNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic);
            employeeNameLabel.ForeColor = SystemColors.ButtonHighlight;
            employeeNameLabel.Location = new Point(1045, 7);
            employeeNameLabel.Margin = new Padding(2, 0, 2, 0);
            employeeNameLabel.Name = "employeeNameLabel";
            employeeNameLabel.Size = new Size(148, 30);
            employeeNameLabel.TabIndex = 1;
            employeeNameLabel.Text = "Logged In:";
            employeeNameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // OrderScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.PaleGoldenrod;
            Controls.Add(panel2);
            Controls.Add(repeatButton);
            Controls.Add(payButton);
            Controls.Add(balanceDueLabel);
            Controls.Add(paymentsLabel);
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
            Margin = new Padding(2);
            Name = "OrderScreen";
            Size = new Size(1200, 915);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private Label paymentsLabel;
        private Label balanceDueLabel;
        private Button payButton;
        private Button repeatButton;
        private Panel panel2;
        private Label label3;
        private Label employeeNameLabel;
    }
}
