namespace restaurantPOS
{
    partial class EmployeeManagement
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
            groupBox1 = new GroupBox();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            tbID = new TextBox();
            tbPay = new TextBox();
            tbName = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            Current = new GroupBox();
            lstEmployees = new ListView();
            addEmployee = new Button();
            removeEmployeeButton = new Button();
            button1 = new Button();
            panel1 = new Panel();
            label3 = new Label();
            label5 = new Label();
            managerMainButton = new Button();
            groupBox1.SuspendLayout();
            Current.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(tbID);
            groupBox1.Controls.Add(tbPay);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(1382, 222);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(5);
            groupBox1.Size = new Size(396, 440);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Employee";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(109, 346);
            radioButton2.Margin = new Padding(5);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(140, 36);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "Manager";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(109, 286);
            radioButton1.Margin = new Padding(5);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(150, 36);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Employee";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // tbID
            // 
            tbID.Location = new Point(154, 217);
            tbID.Margin = new Padding(5);
            tbID.Name = "tbID";
            tbID.Size = new Size(201, 39);
            tbID.TabIndex = 7;
            // 
            // tbPay
            // 
            tbPay.Location = new Point(154, 138);
            tbPay.Margin = new Padding(5);
            tbPay.Name = "tbPay";
            tbPay.Size = new Size(201, 39);
            tbPay.TabIndex = 5;
            // 
            // tbName
            // 
            tbName.Location = new Point(154, 64);
            tbName.Margin = new Padding(5);
            tbName.Name = "tbName";
            tbName.Size = new Size(201, 39);
            tbName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 224);
            label4.Margin = new Padding(5, 0, 5, 0);
            label4.Name = "label4";
            label4.Size = new Size(42, 32);
            label4.TabIndex = 3;
            label4.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 145);
            label2.Margin = new Padding(5, 0, 5, 0);
            label2.Name = "label2";
            label2.Size = new Size(55, 32);
            label2.TabIndex = 1;
            label2.Text = "Pay:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 71);
            label1.Margin = new Padding(5, 0, 5, 0);
            label1.Name = "label1";
            label1.Size = new Size(83, 32);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            // 
            // Current
            // 
            Current.Controls.Add(lstEmployees);
            Current.Location = new Point(164, 222);
            Current.Margin = new Padding(5);
            Current.Name = "Current";
            Current.Padding = new Padding(5);
            Current.Size = new Size(946, 747);
            Current.TabIndex = 7;
            Current.TabStop = false;
            Current.Text = "Current Employees";
            // 
            // lstEmployees
            // 
            lstEmployees.FullRowSelect = true;
            lstEmployees.GridLines = true;
            lstEmployees.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            lstEmployees.Location = new Point(37, 42);
            lstEmployees.Margin = new Padding(5);
            lstEmployees.Name = "lstEmployees";
            lstEmployees.Size = new Size(868, 679);
            lstEmployees.TabIndex = 3;
            lstEmployees.UseCompatibleStateImageBehavior = false;
            lstEmployees.View = View.Details;
            // 
            // addEmployee
            // 
            addEmployee.Location = new Point(1628, 670);
            addEmployee.Name = "addEmployee";
            addEmployee.Size = new Size(150, 46);
            addEmployee.TabIndex = 8;
            addEmployee.Text = "Add";
            addEmployee.UseVisualStyleBackColor = true;
            addEmployee.Click += addEmployee_Click;
            // 
            // removeEmployeeButton
            // 
            removeEmployeeButton.Location = new Point(919, 977);
            removeEmployeeButton.Name = "removeEmployeeButton";
            removeEmployeeButton.Size = new Size(150, 46);
            removeEmployeeButton.TabIndex = 9;
            removeEmployeeButton.Text = "Remove";
            removeEmployeeButton.UseVisualStyleBackColor = true;
            removeEmployeeButton.Click += removeEmployeeButton_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = Properties.Resources.icons8_sign_out_96;
            button1.Location = new Point(1978, 1753);
            button1.Name = "button1";
            button1.Size = new Size(216, 182);
            button1.TabIndex = 10;
            button1.Text = "Exit";
            button1.TextAlign = ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(26, 26, 46);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(2219, 107);
            panel1.TabIndex = 11;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(233, 69, 96);
            label3.Location = new Point(3033, 28);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(139, 36);
            label3.TabIndex = 1;
            label3.Text = "Manager";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Javanese Text", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(26, 19);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(313, 69);
            label5.TabIndex = 0;
            label5.Text = "RESTAURANT POS";
            // 
            // managerMainButton
            // 
            managerMainButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            managerMainButton.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            managerMainButton.Image = Properties.Resources.icons8_manager_100;
            managerMainButton.ImageAlign = ContentAlignment.TopCenter;
            managerMainButton.Location = new Point(1742, 1753);
            managerMainButton.Name = "managerMainButton";
            managerMainButton.Size = new Size(216, 182);
            managerMainButton.TabIndex = 12;
            managerMainButton.Text = "Manager Operations";
            managerMainButton.TextAlign = ContentAlignment.BottomCenter;
            managerMainButton.UseVisualStyleBackColor = true;
            managerMainButton.Click += managerMainButton_Click;
            // 
            // EmployeeManagement
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Info;
            Controls.Add(managerMainButton);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(removeEmployeeButton);
            Controls.Add(addEmployee);
            Controls.Add(Current);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "EmployeeManagement";
            Size = new Size(2219, 1966);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Current.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox tbID;
        private TextBox tbPay;
        private TextBox tbName;
        private Label label4;
        private Label label2;
        private Label label1;
        private GroupBox Current;
        private ListView lstEmployees;
        private Button addEmployee;
        private Button removeEmployeeButton;
        private Button button1;
        private Panel panel1;
        private Label label3;
        private Label label5;
        private Button managerMainButton;
    }
}
