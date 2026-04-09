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
            managerMainButton = new Button();
            SuspendLayout();
            // 
            // foodSalesButton
            // 
            foodSalesButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            foodSalesButton.Image = Properties.Resources.icons8_spoon_and_fork_96;
            foodSalesButton.ImageAlign = ContentAlignment.TopCenter;
            foodSalesButton.Location = new Point(604, 1722);
            foodSalesButton.Name = "foodSalesButton";
            foodSalesButton.Size = new Size(352, 158);
            foodSalesButton.TabIndex = 0;
            foodSalesButton.Text = "Sales by Item";
            foodSalesButton.TextAlign = ContentAlignment.BottomCenter;
            foodSalesButton.UseVisualStyleBackColor = true;
            foodSalesButton.Click += foodSalesButton_Click;
            // 
            // employeeSalesButton
            // 
            employeeSalesButton.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeeSalesButton.Image = Properties.Resources.icons8_employees_96;
            employeeSalesButton.ImageAlign = ContentAlignment.TopCenter;
            employeeSalesButton.Location = new Point(1213, 1722);
            employeeSalesButton.Name = "employeeSalesButton";
            employeeSalesButton.Size = new Size(352, 158);
            employeeSalesButton.TabIndex = 1;
            employeeSalesButton.Text = "Sales by Employee";
            employeeSalesButton.TextAlign = ContentAlignment.BottomCenter;
            employeeSalesButton.UseVisualStyleBackColor = true;
            employeeSalesButton.Click += employeeSalesButton_Click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.Image = Properties.Resources.icons8_sign_out_96;
            exitButton.Location = new Point(1986, 1786);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(216, 168);
            exitButton.TabIndex = 2;
            exitButton.Text = "Exit";
            exitButton.TextAlign = ContentAlignment.BottomCenter;
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // employeeCategoryLabel
            // 
            employeeCategoryLabel.AutoSize = true;
            employeeCategoryLabel.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            employeeCategoryLabel.Location = new Point(212, 60);
            employeeCategoryLabel.Name = "employeeCategoryLabel";
            employeeCategoryLabel.Size = new Size(234, 59);
            employeeCategoryLabel.TabIndex = 3;
            employeeCategoryLabel.Text = "Sales Type";
            // 
            // salesPanel
            // 
            salesPanel.AutoScroll = true;
            salesPanel.BackColor = SystemColors.Control;
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
            salesLabel.Location = new Point(1854, 60);
            salesLabel.Name = "salesLabel";
            salesLabel.Size = new Size(126, 59);
            salesLabel.TabIndex = 5;
            salesLabel.Text = "Sales";
            // 
            // quantityLabel
            // 
            quantityLabel.AutoSize = true;
            quantityLabel.Font = new Font("Segoe UI", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quantityLabel.Location = new Point(1000, 60);
            quantityLabel.Name = "quantityLabel";
            quantityLabel.Size = new Size(202, 59);
            quantityLabel.TabIndex = 6;
            quantityLabel.Text = "Quantity";
            // 
            // managerMainButton
            // 
            managerMainButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            managerMainButton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            managerMainButton.Image = Properties.Resources.icons8_manager_100;
            managerMainButton.ImageAlign = ContentAlignment.TopCenter;
            managerMainButton.Location = new Point(1741, 1786);
            managerMainButton.Name = "managerMainButton";
            managerMainButton.Size = new Size(216, 168);
            managerMainButton.TabIndex = 7;
            managerMainButton.Text = "Manager Operations";
            managerMainButton.TextAlign = ContentAlignment.BottomCenter;
            managerMainButton.UseVisualStyleBackColor = true;
            managerMainButton.Click += managerMainButton_Click;
            // 
            // ReportsScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Info;
            Controls.Add(managerMainButton);
            Controls.Add(quantityLabel);
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
        private Label quantityLabel;
        private Button managerMainButton;
    }
}
