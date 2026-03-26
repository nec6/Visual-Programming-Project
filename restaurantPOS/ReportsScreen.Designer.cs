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
            SuspendLayout();
            // 
            // foodSalesButton
            // 
            foodSalesButton.Location = new Point(604, 1722);
            foodSalesButton.Name = "foodSalesButton";
            foodSalesButton.Size = new Size(352, 158);
            foodSalesButton.TabIndex = 0;
            foodSalesButton.Text = "Sales by Item";
            foodSalesButton.UseVisualStyleBackColor = true;
            foodSalesButton.Click += foodSalesButton_Click;
            // 
            // employeeSalesButton
            // 
            employeeSalesButton.Location = new Point(1213, 1722);
            employeeSalesButton.Name = "employeeSalesButton";
            employeeSalesButton.Size = new Size(352, 158);
            employeeSalesButton.TabIndex = 1;
            employeeSalesButton.Text = "Sales by Employee";
            employeeSalesButton.UseVisualStyleBackColor = true;
            employeeSalesButton.Click += employeeSalesButton_Click;
            // 
            // exitButton
            // 
            exitButton.Location = new Point(1956, 1800);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(248, 154);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // employeeCategoryLabel
            // 
            employeeCategoryLabel.AutoSize = true;
            employeeCategoryLabel.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeeCategoryLabel.Location = new Point(278, 60);
            employeeCategoryLabel.Name = "employeeCategoryLabel";
            employeeCategoryLabel.Size = new Size(234, 59);
            employeeCategoryLabel.TabIndex = 3;
            employeeCategoryLabel.Text = "Sales Type";
            // 
            // salesPanel
            // 
            salesPanel.AutoScroll = true;
            salesPanel.BorderStyle = BorderStyle.FixedSingle;
            salesPanel.FlowDirection = FlowDirection.TopDown;
            salesPanel.Location = new Point(28, 160);
            salesPanel.Name = "salesPanel";
            salesPanel.Size = new Size(2156, 1508);
            salesPanel.TabIndex = 4;
            salesPanel.WrapContents = false;
            // 
            // salesLabel
            // 
            salesLabel.AutoSize = true;
            salesLabel.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            salesLabel.Location = new Point(1774, 60);
            salesLabel.Name = "salesLabel";
            salesLabel.Size = new Size(126, 59);
            salesLabel.TabIndex = 5;
            salesLabel.Text = "Sales";
            // 
            // ReportsScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(salesLabel);
            Controls.Add(salesPanel);
            Controls.Add(employeeCategoryLabel);
            Controls.Add(exitButton);
            Controls.Add(employeeSalesButton);
            Controls.Add(foodSalesButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ReportsScreen";
            Size = new Size(2219, 1966);
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private Button foodSalesButton;
        private Button employeeSalesButton;
        private Button exitButton;
        private Label employeeCategoryLabel;
        private FlowLayoutPanel salesPanel;
        private Label salesLabel;
    }
}
