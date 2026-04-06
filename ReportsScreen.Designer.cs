namespace restaurantPOS
{
    partial class ReportsScreen
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
            foodSalesButton = new Button();
            employeeSalesButton = new Button();
            exitButton = new Button();
            employeeCategoryLabel = new Label();
            salesPanel = new FlowLayoutPanel();
            salesLabel = new Label();
            quantityLabel = new Label();
            panel1 = new Panel();
            label2 = new Label();
            button100 = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // foodSalesButton
            // 
            foodSalesButton.BackColor = Color.FromArgb(192, 255, 192);
            foodSalesButton.Font = new Font("Arial", 13F, FontStyle.Bold);
            foodSalesButton.Location = new Point(87, 805);
            foodSalesButton.Margin = new Padding(2, 1, 2, 1);
            foodSalesButton.Name = "foodSalesButton";
            foodSalesButton.Size = new Size(190, 74);
            foodSalesButton.TabIndex = 0;
            foodSalesButton.Text = "Sales by Item";
            foodSalesButton.UseVisualStyleBackColor = false;
            foodSalesButton.Click += foodSalesButton_Click;
            // 
            // employeeSalesButton
            // 
            employeeSalesButton.BackColor = Color.FromArgb(192, 255, 192);
            employeeSalesButton.Font = new Font("Arial", 13F, FontStyle.Bold);
            employeeSalesButton.Location = new Point(305, 805);
            employeeSalesButton.Margin = new Padding(2, 1, 2, 1);
            employeeSalesButton.Name = "employeeSalesButton";
            employeeSalesButton.Size = new Size(204, 74);
            employeeSalesButton.TabIndex = 1;
            employeeSalesButton.Text = "Sales by Employee";
            employeeSalesButton.UseVisualStyleBackColor = false;
            employeeSalesButton.Click += employeeSalesButton_Click;
            // 
            // exitButton
            // 
            exitButton.BackColor = Color.IndianRed;
            exitButton.Font = new Font("Arial", 13F, FontStyle.Bold);
            exitButton.Location = new Point(788, 804);
            exitButton.Margin = new Padding(2, 1, 2, 1);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(128, 74);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = false;
            exitButton.Click += exitButton_Click;
            // 
            // employeeCategoryLabel
            // 
            employeeCategoryLabel.BackColor = Color.White;
            employeeCategoryLabel.BorderStyle = BorderStyle.Fixed3D;
            employeeCategoryLabel.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeeCategoryLabel.Location = new Point(139, 120);
            employeeCategoryLabel.Margin = new Padding(2, 0, 2, 0);
            employeeCategoryLabel.Name = "employeeCategoryLabel";
            employeeCategoryLabel.Size = new Size(138, 41);
            employeeCategoryLabel.TabIndex = 3;
            employeeCategoryLabel.Text = "Sales Type";
            employeeCategoryLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // salesPanel
            // 
            salesPanel.AutoScroll = true;
            salesPanel.BackColor = SystemColors.Control;
            salesPanel.BorderStyle = BorderStyle.FixedSingle;
            salesPanel.FlowDirection = FlowDirection.TopDown;
            salesPanel.Location = new Point(62, 182);
            salesPanel.Margin = new Padding(2, 1, 2, 1);
            salesPanel.Name = "salesPanel";
            salesPanel.Size = new Size(869, 592);
            salesPanel.TabIndex = 4;
            salesPanel.WrapContents = false;
            // 
            // salesLabel
            // 
            salesLabel.BackColor = Color.White;
            salesLabel.BorderStyle = BorderStyle.Fixed3D;
            salesLabel.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salesLabel.Location = new Point(717, 122);
            salesLabel.Margin = new Padding(2, 0, 2, 0);
            salesLabel.Name = "salesLabel";
            salesLabel.Size = new Size(128, 39);
            salesLabel.TabIndex = 5;
            salesLabel.Text = "Sales";
            salesLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // quantityLabel
            // 
            quantityLabel.BackColor = Color.White;
            quantityLabel.BorderStyle = BorderStyle.Fixed3D;
            quantityLabel.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantityLabel.Location = new Point(417, 120);
            quantityLabel.Margin = new Padding(2, 0, 2, 0);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(145, 41);
            quantityLabel.TabIndex = 6;
            quantityLabel.Text = "Quantity";
            quantityLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 26, 46);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(993, 50);
            panel1.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Javanese Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(14, 9);
            label2.Name = "label2";
            label2.Size = new Size(160, 34);
            label2.TabIndex = 0;
            label2.Text = "RESTAURANT POS";
            // 
            // button100
            // 
            button100.BackColor = Color.LightYellow;
            button100.Font = new Font("Arial", 13F, FontStyle.Bold);
            button100.Location = new Point(557, 804);
            button100.Name = "button100";
            button100.Size = new Size(194, 74);
            button100.TabIndex = 8;
            button100.Text = "Go Back";
            button100.UseVisualStyleBackColor = false;
            button100.Click += button100_Click;
            // 
            // ReportsScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.PaleGoldenrod;
            Controls.Add(button100);
            Controls.Add(panel1);
            Controls.Add(quantityLabel);
            Controls.Add(salesLabel);
            Controls.Add(salesPanel);
            Controls.Add(employeeCategoryLabel);
            Controls.Add(exitButton);
            Controls.Add(employeeSalesButton);
            Controls.Add(foodSalesButton);
            Margin = new Padding(2);
            Name = "ReportsScreen";
            Size = new Size(993, 922);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Button foodSalesButton;
        private Button employeeSalesButton;
        private Button exitButton;
        private Label employeeCategoryLabel;
        private FlowLayoutPanel salesPanel;
        private Label salesLabel;
        private Label quantityLabel;
        private Panel panel1;
        private Label label2;
        private Button button100;
    }
}
