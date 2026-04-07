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
            btnExit = new Button();
            Current.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Current
            // 
            Current.Controls.Add(lstEmployees);
            Current.Location = new Point(12, 125);
            Current.Name = "Current";
            Current.Size = new Size(582, 467);
            Current.TabIndex = 7;
            Current.TabStop = false;
            Current.Text = "Current Items";
            // 
            // lstEmployees
            // 
            lstEmployees.FullRowSelect = true;
            lstEmployees.GridLines = true;
            lstEmployees.Location = new Point(6, 26);
            lstEmployees.Name = "lstEmployees";
            lstEmployees.Size = new Size(536, 426);
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
            groupBox1.Location = new Point(651, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 377);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Item";
            // 
            // tbCat
            // 
            tbCat.Location = new Point(95, 153);
            tbCat.Name = "tbCat";
            tbCat.Size = new Size(53, 27);
            tbCat.TabIndex = 10;
            tbCat.TextChanged += tbCat_TextChanged;
            // 
            // tbMods
            // 
            tbMods.Location = new Point(95, 238);
            tbMods.Name = "tbMods";
            tbMods.Size = new Size(125, 27);
            tbMods.TabIndex = 7;
            tbMods.TextChanged += tbMods_TextChanged;
            // 
            // tbPrice
            // 
            tbPrice.Location = new Point(95, 86);
            tbPrice.Name = "tbPrice";
            tbPrice.Size = new Size(125, 27);
            tbPrice.TabIndex = 5;
            tbPrice.TextChanged += tbPrice_TextChanged;
            // 
            // tbName
            // 
            tbName.Location = new Point(95, 40);
            tbName.Name = "tbName";
            tbName.Size = new Size(125, 27);
            tbName.TabIndex = 4;
            tbName.TextChanged += tbName_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 241);
            label4.Name = "label4";
            label4.Size = new Size(75, 20);
            label4.TabIndex = 3;
            label4.Text = "Modifiers:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 153);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 2;
            label3.Text = "Category:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 93);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 1;
            label2.Text = "Price:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 40);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // btnDel
            // 
            btnDel.Location = new Point(83, 688);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 9;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(460, 688);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button2_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(807, 688);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 11;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += button3_Click;
            // 
            // MenuManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(btnDel);
            Controls.Add(groupBox1);
            Controls.Add(Current);
            Margin = new Padding(2);
            Name = "MenuManagement";
            Size = new Size(1365, 1229);
            Load += MenuManagement_Load;
            Current.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
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
        private Button btnExit;
    }
}
