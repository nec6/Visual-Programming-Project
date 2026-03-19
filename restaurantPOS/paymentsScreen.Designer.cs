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
            label2.Location = new Point(762, 108);
            label2.Name = "label2";
            label2.Size = new Size(137, 65);
            label2.TabIndex = 1;
            label2.Text = "Card:";
            // 
            // tenDollarCash
            // 
            tenDollarCash.Location = new Point(140, 228);
            tenDollarCash.Name = "tenDollarCash";
            tenDollarCash.Size = new Size(164, 124);
            tenDollarCash.TabIndex = 2;
            tenDollarCash.Tag = "10";
            tenDollarCash.Text = "$10";
            tenDollarCash.UseVisualStyleBackColor = true;
            tenDollarCash.Click += applyPaymentButton_Click;
            // 
            // fiftyCashButton
            // 
            fiftyCashButton.Location = new Point(140, 420);
            fiftyCashButton.Name = "fiftyCashButton";
            fiftyCashButton.Size = new Size(164, 124);
            fiftyCashButton.TabIndex = 3;
            fiftyCashButton.Tag = "50";
            fiftyCashButton.Text = "$50";
            fiftyCashButton.UseVisualStyleBackColor = true;
            fiftyCashButton.Click += applyPaymentButton_Click;
            // 
            // twentyCashButton
            // 
            twentyCashButton.Location = new Point(358, 228);
            twentyCashButton.Name = "twentyCashButton";
            twentyCashButton.Size = new Size(164, 124);
            twentyCashButton.TabIndex = 4;
            twentyCashButton.Tag = "20";
            twentyCashButton.Text = "$20";
            twentyCashButton.UseVisualStyleBackColor = true;
            twentyCashButton.Click += applyPaymentButton_Click;
            // 
            // hundredCashButton
            // 
            hundredCashButton.Location = new Point(358, 420);
            hundredCashButton.Name = "hundredCashButton";
            hundredCashButton.Size = new Size(164, 124);
            hundredCashButton.TabIndex = 5;
            hundredCashButton.Tag = "100";
            hundredCashButton.Text = "$100";
            hundredCashButton.UseVisualStyleBackColor = true;
            hundredCashButton.Click += applyPaymentButton_Click;
            // 
            // customCashTB
            // 
            customCashTB.Location = new Point(140, 596);
            customCashTB.Name = "customCashTB";
            customCashTB.PlaceholderText = "Enter Cash Amount:";
            customCashTB.Size = new Size(382, 39);
            customCashTB.TabIndex = 6;
            // 
            // applyCustomCash
            // 
            applyCustomCash.Location = new Point(140, 678);
            applyCustomCash.Name = "applyCustomCash";
            applyCustomCash.Size = new Size(382, 72);
            applyCustomCash.TabIndex = 7;
            applyCustomCash.Text = "Apply Custom Cash";
            applyCustomCash.UseVisualStyleBackColor = true;
            applyCustomCash.Click += applyCustomCash_Click;
            // 
            // button2
            // 
            button2.Location = new Point(520, 782);
            button2.Name = "button2";
            button2.Size = new Size(150, 46);
            button2.TabIndex = 8;
            button2.Text = "Done";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // paymentsScreen
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1269, 872);
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
    }
}