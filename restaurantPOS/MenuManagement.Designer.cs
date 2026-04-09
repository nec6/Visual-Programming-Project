namespace restaurantPOS
{
    partial class MenuManagement
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
            Current = new GroupBox();
            lstEmployees = new ListView();
            groupBox1 = new GroupBox();
            tbCat = new TextBox();
            tbMods = new TextBox();
            tbPrice = new TextBox();
            tbName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnDel = new Button();
            btnAdd = new Button();
            exitButton = new Button();
            panel1 = new Panel();
            label5 = new Label();
            label6 = new Label();
            managerMainButton = new Button();
            Current.SuspendLayout();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // Current
            // 
            Current.Controls.Add(lstEmployees);
            Current.Location = new Point(20, 200);
            Current.Margin = new Padding(5);
            Current.Name = "Current";
            Current.Padding = new Padding(5);
            Current.Size = new Size(946, 747);
            Current.TabIndex = 7;
            Current.TabStop = false;
            Current.Text = "Current Items";
            // 
            // lstEmployees
            // 
            lstEmployees.FullRowSelect = true;
            lstEmployees.GridLines = true;
            lstEmployees.Location = new Point(10, 42);
            lstEmployees.Margin = new Padding(5);
            lstEmployees.Name = "lstEmployees";
            lstEmployees.Size = new Size(868, 679);
            lstEmployees.TabIndex = 3;
            lstEmployees.UseCompatibleStateImageBehavior = false;
            lstEmployees.View = View.Details;
            lstEmployees.SelectedIndexChanged += lstEmployees_SelectedIndexChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tbCat);
            groupBox1.Controls.Add(tbMods);
            groupBox1.Controls.Add(tbPrice);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1058, 242);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(406, 603);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Item";
            // 
            // tbCat
            // 
            tbCat.Location = new Point(154, 245);
            tbCat.Margin = new Padding(5);
            tbCat.Name = "tbCat";
            tbCat.Size = new Size(84, 39);
            tbCat.TabIndex = 10;
            tbCat.TextChanged += tbCat_TextChanged;
            // 
            // tbMods
            // 
            tbMods.Location = new Point(154, 381);
            tbMods.Margin = new Padding(5);
            tbMods.Name = "tbMods";
            tbMods.Size = new Size(201, 39);
            tbMods.TabIndex = 7;
            tbMods.TextChanged += tbMods_TextChanged;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(154, 138);
            tbPrice.Margin = new Padding(5);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(201, 39);
            tbPrice.TabIndex = 5;
            tbPrice.TextChanged += tbPrice_TextChanged;
            // 
            // tbName
            // 
            tbName.Location = new Point(154, 64);
            tbName.Margin = new Padding(5);
            tbName.Name = "tbName";
            tbName.Size = new Size(201, 39);
            tbName.TabIndex = 4;
            tbName.TextChanged += tbName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 386);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(120, 32);
            label4.TabIndex = 3;
            label4.Text = "Modifiers:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 245);
            label3.Margin = new Padding(5, 0, 5, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 32);
            label3.TabIndex = 2;
            label3.Text = "Category:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 149);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 32);
            label2.TabIndex = 1;
            label2.Text = "Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 64);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // btnDel
            // 
            btnDel.Location = new Point(135, 1101);
            btnDel.Margin = new Padding(5);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(153, 46);
            btnDel.TabIndex = 9;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(748, 1101);
            btnAdd.Margin = new Padding(5);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(153, 46);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button2_Click;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            exitButton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exitButton.Image = Properties.Resources.icons8_sign_out_96;
            exitButton.Location = new Point(1956, 1754);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(216, 182);
            exitButton.TabIndex = 12;
            exitButton.Text = "Exit";
            exitButton.TextAlign = ContentAlignment.BottomCenter;
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 26, 46);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(2219, 107);
            panel1.TabIndex = 13;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(233, 69, 96);
            label5.Location = new Point(3033, 28);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(139, 36);
            label5.TabIndex = 1;
            label5.Text = "Manager";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Javanese Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.ButtonHighlight;
            label6.Location = new Point(26, 19);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(313, 69);
            label6.TabIndex = 0;
            label6.Text = "RESTAURANT POS";
            // 
            // managerMainButton
            // 
            managerMainButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            managerMainButton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            managerMainButton.Image = Properties.Resources.icons8_manager_100;
            managerMainButton.ImageAlign = ContentAlignment.TopCenter;
            managerMainButton.Location = new Point(1707, 1754);
            managerMainButton.Name = "managerMainButton";
            managerMainButton.Size = new Size(216, 182);
            managerMainButton.TabIndex = 14;
            managerMainButton.Text = "Manager Operations";
            managerMainButton.TextAlign = ContentAlignment.BottomCenter;
            managerMainButton.UseVisualStyleBackColor = true;
            managerMainButton.Click += managerMainButton_Click;
            // 
            // MenuManagement
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Info;
            Controls.Add(managerMainButton);
            Controls.Add(panel1);
            Controls.Add(exitButton);
            Controls.Add(btnAdd);
            Controls.Add(btnDel);
            Controls.Add(groupBox1);
            Controls.Add(Current);
            Name = "MenuManagement";
            Size = new Size(2219, 1966);
            Load += MenuManagement_Load;
            Current.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private GroupBox Current;
        private ListView lstEmployees;
        private GroupBox groupBox1;
        private TextBox tbCat;
        private TextBox tbMods;
        private TextBox tbPrice;
        private TextBox tbName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btnDel;
        private Button btnAdd;
        private Button exitButton;
        private Panel panel1;
        private Label label5;
        private Label label6;
        private Button managerMainButton;
    }
}
