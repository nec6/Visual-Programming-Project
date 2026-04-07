namespace restaurantPOS
{
    partial class Form1
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
            screenHost = new Panel();
            SuspendLayout();
            // 
            // screenHost
            // 
            screenHost.Dock = DockStyle.Fill;
            screenHost.Location = new Point(0, 0);
            screenHost.Margin = new Padding(2, 2, 2, 2);
            screenHost.Name = "screenHost";
            screenHost.Size = new Size(1283, 844);
            screenHost.TabIndex = 0;
            screenHost.Paint += screenHost_Paint;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1283, 844);
            Controls.Add(screenHost);
            Margin = new Padding(2, 2, 2, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screenHost;
    }
}

