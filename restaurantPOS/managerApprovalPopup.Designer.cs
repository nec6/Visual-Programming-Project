namespace restaurantPOS
{
    partial class managerApprovalPopup
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
            idTextbox = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(211, 230);
            label1.Name = "label1";
            label1.Size = new Size(872, 128);
            label1.TabIndex = 0;
            label1.Text = "Enter Manager ID:";
            // 
            // idTextbox
            // 
            idTextbox.Location = new Point(521, 400);
            idTextbox.Name = "idTextbox";
            idTextbox.PlaceholderText = "Enter ID:";
            idTextbox.Size = new Size(200, 39);
            idTextbox.TabIndex = 1;
            // 
            // button1
            // 
            button1.DialogResult = DialogResult.OK;
            button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(479, 502);
            button1.Name = "button1";
            button1.Size = new Size(276, 132);
            button1.TabIndex = 2;
            button1.Text = "Confirm";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // managerApprovalPopup
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1269, 872);
            Controls.Add(button1);
            Controls.Add(idTextbox);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "managerApprovalPopup";
            StartPosition = FormStartPosition.CenterParent;
            Text = "managerApprovalPopup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox idTextbox;
        private Button button1;
    }
}