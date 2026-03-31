namespace restaurantPOS
{
    partial class paymentsScreen
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
            label1 = new Label();
            label2 = new Label();
            tenDollarCash = new Button();
            fiftyCashButton = new Button();
            twentyCashButton = new Button();
            hundredCashButton = new Button();
            customCashTB = new TextBox();
            applyCustomCash = new Button();
            button2 = new Button();
            cardNumberTB = new TextBox();
            cardAmountTB = new TextBox();
            cardPaymentButton = new Button();
            appliedPaymentsLabel = new Label();
            balanceDueLabel = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(270, 108);
            label1.Name = "label1";
            label1.Size = new Size(139, 65);
            label1.TabIndex = 0;
            label1.Text = "Cash:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(854, 108);
            label2.Name = "label2";
            label2.Size = new Size(137, 65);
            label2.TabIndex = 1;
            label2.Text = "Card:";
            // 
            // tenDollarCash
            // 
            tenDollarCash.BackgroundImage = Properties.Resources.tenBill1;
            tenDollarCash.BackgroundImageLayout = ImageLayout.Zoom;
            tenDollarCash.Location = new Point(28, 228);
            tenDollarCash.Name = "tenDollarCash";
            tenDollarCash.Size = new Size(291, 124);
            tenDollarCash.TabIndex = 2;
            tenDollarCash.Tag = "10";
            tenDollarCash.UseVisualStyleBackColor = true;
            tenDollarCash.Click += applyPaymentButton_Click;
            // 
            // fiftyCashButton
            // 
            fiftyCashButton.BackgroundImage = Properties.Resources.fifty;
            fiftyCashButton.BackgroundImageLayout = ImageLayout.Zoom;
            fiftyCashButton.Location = new Point(28, 398);
            fiftyCashButton.Name = "fiftyCashButton";
            fiftyCashButton.Size = new Size(291, 124);
            fiftyCashButton.TabIndex = 3;
            fiftyCashButton.Tag = "50";
            fiftyCashButton.UseVisualStyleBackColor = true;
            fiftyCashButton.Click += applyPaymentButton_Click;
            // 
            // twentyCashButton
            // 
            twentyCashButton.BackgroundImage = Properties.Resources.twenty;
            twentyCashButton.BackgroundImageLayout = ImageLayout.Zoom;
            twentyCashButton.Location = new Point(340, 228);
            twentyCashButton.Name = "twentyCashButton";
            twentyCashButton.Size = new Size(291, 124);
            twentyCashButton.TabIndex = 4;
            twentyCashButton.Tag = "20";
            twentyCashButton.UseVisualStyleBackColor = true;
            twentyCashButton.Click += applyPaymentButton_Click;
            // 
            // hundredCashButton
            // 
            hundredCashButton.BackgroundImage = Properties.Resources.hundred;
            hundredCashButton.BackgroundImageLayout = ImageLayout.Zoom;
            hundredCashButton.Location = new Point(340, 398);
            hundredCashButton.Name = "hundredCashButton";
            hundredCashButton.Size = new Size(291, 124);
            hundredCashButton.TabIndex = 5;
            hundredCashButton.Tag = "100";
            hundredCashButton.UseVisualStyleBackColor = true;
            hundredCashButton.Click += applyPaymentButton_Click;
            // 
            // customCashTB
            // 
            customCashTB.Location = new Point(140, 580);
            customCashTB.Name = "customCashTB";
            customCashTB.PlaceholderText = "Enter Cash Amount:";
            customCashTB.Size = new Size(382, 39);
            customCashTB.TabIndex = 6;
            // 
            // applyCustomCash
            // 
            applyCustomCash.Location = new Point(140, 662);
            applyCustomCash.Name = "applyCustomCash";
            applyCustomCash.Size = new Size(382, 72);
            applyCustomCash.TabIndex = 7;
            applyCustomCash.Text = "Apply Custom Cash";
            applyCustomCash.UseVisualStyleBackColor = true;
            applyCustomCash.Click += applyCustomCash_Click;
            // 
            // button2
            // 
            button2.Location = new Point(964, 775);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 8;
            button2.Text = "Done";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cardNumberTB
            // 
            cardNumberTB.Location = new Point(764, 271);
            cardNumberTB.Name = "cardNumberTB";
            cardNumberTB.PlaceholderText = "16 Digit Card Number:";
            cardNumberTB.Size = new Size(322, 39);
            cardNumberTB.TabIndex = 9;
            // 
            // cardAmountTB
            // 
            cardAmountTB.Location = new Point(764, 441);
            cardAmountTB.Name = "cardAmountTB";
            cardAmountTB.PlaceholderText = "Card Payment Amount:";
            cardAmountTB.Size = new Size(322, 39);
            cardAmountTB.TabIndex = 10;
            // 
            // cardPaymentButton
            // 
            cardPaymentButton.Location = new Point(732, 662);
            cardPaymentButton.Name = "cardPaymentButton";
            cardPaymentButton.Size = new Size(382, 72);
            cardPaymentButton.TabIndex = 11;
            cardPaymentButton.Text = "Apply Card Payment";
            cardPaymentButton.UseVisualStyleBackColor = true;
            cardPaymentButton.Click += cardPaymentButton_Click;
            // 
            // appliedPaymentsLabel
            // 
            appliedPaymentsLabel.Location = new Point(408, 766);
            appliedPaymentsLabel.Name = "appliedPaymentsLabel";
            appliedPaymentsLabel.Size = new Size(416, 32);
            appliedPaymentsLabel.TabIndex = 12;
            appliedPaymentsLabel.Text = "Applied Payments: $0.00";
            appliedPaymentsLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // balanceDueLabel
            // 
            balanceDueLabel.Location = new Point(408, 808);
            balanceDueLabel.Name = "balanceDueLabel";
            balanceDueLabel.Size = new Size(416, 32);
            balanceDueLabel.TabIndex = 13;
            balanceDueLabel.Text = "Balance Due: $0.00";
            balanceDueLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // paymentsScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1269, 872);
            Controls.Add(balanceDueLabel);
            Controls.Add(appliedPaymentsLabel);
            Controls.Add(cardPaymentButton);
            Controls.Add(cardAmountTB);
            Controls.Add(cardNumberTB);
            Controls.Add(button2);
            Controls.Add(applyCustomCash);
            Controls.Add(customCashTB);
            Controls.Add(hundredCashButton);
            Controls.Add(twentyCashButton);
            Controls.Add(fiftyCashButton);
            Controls.Add(tenDollarCash);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "paymentsScreen";
            StartPosition = FormStartPosition.CenterParent;
            Text = "paymentsScreen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button tenDollarCash;
        private Button fiftyCashButton;
        private Button twentyCashButton;
        private Button hundredCashButton;
        private TextBox customCashTB;
        private Button applyCustomCash;
        private Button button2;
        private TextBox cardNumberTB;
        private TextBox cardAmountTB;
        private Button cardPaymentButton;
        private Label appliedPaymentsLabel;
        private Label balanceDueLabel;
    }
}