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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            screenHost = new Panel();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // screenHost
            // 
            screenHost.Dock = DockStyle.Fill;
            screenHost.Location = new Point(0, 0);
            screenHost.Margin = new Padding(3, 4, 3, 4);
            screenHost.Name = "screenHost";
            screenHost.Size = new Size(2219, 1966);
            screenHost.TabIndex = 0;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "Coke");
            imageList1.Images.SetKeyName(1, "Sprite");
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2219, 1966);
            Controls.Add(screenHost);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel screenHost;
        protected internal ImageList imageList1;
    }
}

