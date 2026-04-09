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
            panel1 = new Panel();
            label3 = new Label();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.icons8_sign_out_96;
            button1.ImageAlign = ContentAlignment.TopCenter;
            button1.Location = new Point(1976, 1782);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(190, 157);
            button1.TabIndex = 0;
            button1.Text = "Exit";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuCategoryPanel
            // 
            menuCategoryPanel.AutoScroll = true;
            menuCategoryPanel.BackColor = SystemColors.Control;
            menuCategoryPanel.FlowDirection = FlowDirection.TopDown;
            menuCategoryPanel.Location = new Point(764, 116);
            menuCategoryPanel.Name = "menuCategoryPanel";
            menuCategoryPanel.Size = new Size(320, 1640);
            menuCategoryPanel.TabIndex = 1;
            menuCategoryPanel.WrapContents = false;
            // 
            // menuItemsPanel
            // 
            menuItemsPanel.BackColor = SystemColors.ControlLight;
            menuItemsPanel.Location = new Point(1194, 113);
            menuItemsPanel.Name = "menuItemsPanel";
            menuItemsPanel.Size = new Size(972, 1643);
            menuItemsPanel.TabIndex = 2;
            // 
            // viewTablesButton
            // 
            viewTablesButton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            viewTablesButton.Image = Properties.Resources.smallTable;
            viewTablesButton.ImageAlign = ContentAlignment.TopCenter;
            viewTablesButton.Location = new Point(1752, 1782);
            viewTablesButton.Margin = new Padding(3, 4, 3, 4);
            viewTablesButton.Name = "viewTablesButton";
            viewTablesButton.Size = new Size(190, 157);
            viewTablesButton.TabIndex = 4;
            viewTablesButton.Text = "View Tables";
            viewTablesButton.TextAlign = ContentAlignment.BottomCenter;
            viewTablesButton.UseVisualStyleBackColor = true;
            viewTablesButton.Click += viewTablesButton_Click;
            // 
            // tableLabel
            // 
            tableLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tableLabel.Location = new Point(88, 113);
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
            orderedItemsListbox.Location = new Point(88, 194);
            orderedItemsListbox.Name = "orderedItemsListbox";
            orderedItemsListbox.Size = new Size(562, 1380);
            orderedItemsListbox.TabIndex = 7;
            // 
            // deleteItemButton
            // 
            deleteItemButton.Location = new Point(88, 1881);
            deleteItemButton.Name = "deleteItemButton";
            deleteItemButton.Size = new Size(166, 58);
            deleteItemButton.TabIndex = 8;
            deleteItemButton.Text = "Delete";
            deleteItemButton.UseVisualStyleBackColor = true;
            deleteItemButton.Click += deleteItemButton_Click;
            // 
            // modificationsTextBox
            // 
            modificationsTextBox.Location = new Point(88, 1802);
            modificationsTextBox.Name = "modificationsTextBox";
            modificationsTextBox.PlaceholderText = "Enter Modifications Here:";
            modificationsTextBox.Size = new Size(562, 39);
            modificationsTextBox.TabIndex = 9;
            // 
            // modifyButton
            // 
            modifyButton.Location = new Point(284, 1881);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(166, 58);
            modifyButton.TabIndex = 10;
            modifyButton.Text = "Modify";
            modifyButton.UseVisualStyleBackColor = true;
            modifyButton.Click += modifyButton_Click;
            // 
            // totalLabel
            // 
            totalLabel.Location = new Point(212, 1667);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(444, 32);
            totalLabel.TabIndex = 11;
            totalLabel.Text = "Total: $0.00";
            totalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // taxLabel
            // 
            taxLabel.Location = new Point(174, 1635);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new Size(482, 32);
            taxLabel.TabIndex = 12;
            taxLabel.Text = "Tax: $0.00";
            taxLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // subtotalLabel
            // 
            subtotalLabel.Anchor = AnchorStyles.Right;
            subtotalLabel.Location = new Point(156, 1603);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new Size(500, 32);
            subtotalLabel.TabIndex = 13;
            subtotalLabel.Text = "Subtotal: $0.00";
            subtotalLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Image = Properties.Resources.icons8_bill_96;
            button2.ImageAlign = ContentAlignment.TopCenter;
            button2.Location = new Point(1300, 1782);
            button2.Name = "button2";
            button2.Size = new Size(191, 157);
            button2.TabIndex = 14;
            button2.Text = "Close Check";
            button2.TextAlign = ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // paymentsLabel
            // 
            paymentsLabel.Location = new Point(212, 1699);
            paymentsLabel.Name = "paymentsLabel";
            paymentsLabel.Size = new Size(444, 32);
            paymentsLabel.TabIndex = 15;
            paymentsLabel.Text = "Payments Applied: $0.00";
            paymentsLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // balanceDueLabel
            // 
            balanceDueLabel.Location = new Point(212, 1731);
            balanceDueLabel.Name = "balanceDueLabel";
            balanceDueLabel.Size = new Size(444, 32);
            balanceDueLabel.TabIndex = 16;
            balanceDueLabel.Text = "Balance Due: $0.00";
            balanceDueLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // payButton
            // 
            payButton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            payButton.Image = Properties.Resources.icons8_money_96;
            payButton.ImageAlign = ContentAlignment.TopCenter;
            payButton.Location = new Point(1530, 1782);
            payButton.Name = "payButton";
            payButton.Size = new Size(191, 157);
            payButton.TabIndex = 17;
            payButton.Text = "Pay Check";
            payButton.TextAlign = ContentAlignment.BottomCenter;
            payButton.UseVisualStyleBackColor = true;
            payButton.Click += payButton_Click;
            // 
            // repeatButton
            // 
            repeatButton.Location = new Point(484, 1881);
            repeatButton.Name = "repeatButton";
            repeatButton.Size = new Size(166, 58);
            repeatButton.TabIndex = 18;
            repeatButton.Text = "Repeat";
            repeatButton.UseVisualStyleBackColor = true;
            repeatButton.Click += repeatButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 26, 46);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(2219, 107);
            panel1.TabIndex = 19;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(233, 69, 96);
            label3.Location = new Point(3033, 28);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(139, 36);
            label3.TabIndex = 1;
            label3.Text = "Manager";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Javanese Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(26, 19);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(313, 69);
            label2.TabIndex = 0;
            label2.Text = "RESTAURANT POS";
            // 
            // OrderScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            Controls.Add(panel1);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "OrderScreen";
            Size = new Size(2219, 1966);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel panel1;
        private Label label3;
        private Label label2;
    }
}
