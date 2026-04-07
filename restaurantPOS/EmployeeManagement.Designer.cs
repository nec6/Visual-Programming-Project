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
            loginScreen1 = new LoginScreen();
            loginScreen2 = new LoginScreen();
            btnDel = new Button();
            btnAdd = new Button();
            btnExit = new Button();
            groupBox1 = new GroupBox();
            tbMan = new TextBox();
            tbEmploy = new TextBox();
            label6 = new Label();
            label5 = new Label();
            tbID = new TextBox();
            tbPay = new TextBox();
            tbName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Current = new GroupBox();
            lstEmployees = new ListView();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1.SuspendLayout();
            Current.SuspendLayout();
            SuspendLayout();
            // 
            // loginScreen1
            // 
            loginScreen1.Location = new Point(0, 0);
            loginScreen1.Margin = new Padding(2);
            loginScreen1.Name = "loginScreen1";
            loginScreen1.Size = new Size(1706, 1536);
            loginScreen1.TabIndex = 0;
            // 
            // loginScreen2
            // 
            loginScreen2.Location = new Point(0, 0);
            loginScreen2.Margin = new Padding(2);
            loginScreen2.Name = "loginScreen2";
            loginScreen2.Size = new Size(1706, 1536);
            loginScreen2.TabIndex = 1;
            loginScreen2.Load += loginScreen2_Load;
            // 
            // btnDel
            // 
            btnDel.Location = new Point(249, 524);
            btnDel.Name = "btnDel";
            btnDel.Size = new Size(94, 29);
            btnDel.TabIndex = 2;
            btnDel.Text = "Delete";
            btnDel.UseVisualStyleBackColor = true;
            btnDel.Click += btnDel_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(652, 524);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 3;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += button2_Click;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(864, 525);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 4;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(tbMan);
            groupBox1.Controls.Add(tbEmploy);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(tbID);
            groupBox1.Controls.Add(tbPay);
            groupBox1.Controls.Add(tbName);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(738, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 374);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "Add Item";
            // 
            // tbMan
            // 
            tbMan.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbMan.Location = new Point(111, 176);
            tbMan.Name = "tbMan";
            tbMan.Size = new Size(53, 38);
            tbMan.TabIndex = 10;
            // 
            // tbEmploy
            // 
            tbEmploy.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tbEmploy.Location = new Point(111, 123);
            tbEmploy.Name = "tbEmploy";
            tbEmploy.Size = new Size(53, 38);
            tbEmploy.TabIndex = 6;
            tbEmploy.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(170, 188);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 9;
            label6.Text = "Manager";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(170, 135);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 8;
            label5.Text = "Employee";
            // 
            // tbID
            // 
            tbID.Location = new Point(95, 238);
            tbID.Name = "tbID";
            tbID.Size = new Size(125, 27);
            tbID.TabIndex = 7;
            // 
            // tbPay
            // 
            tbPay.Location = new Point(95, 86);
            tbPay.Name = "tbPay";
            tbPay.Size = new Size(125, 27);
            tbPay.TabIndex = 5;
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
            label4.Size = new Size(27, 20);
            label4.TabIndex = 3;
            label4.Text = "ID:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 135);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "Position:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 93);
            label2.Name = "label2";
            label2.Size = new Size(34, 20);
            label2.TabIndex = 1;
            label2.Text = "Pay:";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 40);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Name:";
            label1.Click += label1_Click;
            // 
            // Current
            // 
            Current.Controls.Add(lstEmployees);
            Current.Location = new Point(37, 22);
            Current.Name = "Current";
            Current.Size = new Size(582, 467);
            Current.TabIndex = 6;
            Current.TabStop = false;
            Current.Text = "Current Employees";
            Current.Enter += Current_Enter;
            // 
            // lstEmployees
            // 
            lstEmployees.FullRowSelect = true;
            lstEmployees.GridLines = true;
            lstEmployees.Location = new Point(23, 26);
            lstEmployees.Name = "lstEmployees";
            lstEmployees.Size = new Size(536, 426);
            lstEmployees.TabIndex = 3;
            lstEmployees.UseCompatibleStateImageBehavior = false;
            lstEmployees.View = View.Details;
            lstEmployees.SelectedIndexChanged += lstEmployees_SelectedIndexChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(87, 296);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(96, 24);
            radioButton1.TabIndex = 11;
            radioButton1.TabStop = true;
            radioButton1.Text = "Employee";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(87, 325);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(89, 24);
            radioButton2.TabIndex = 12;
            radioButton2.TabStop = true;
            radioButton2.Text = "Manager";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // EmployeeManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Current);
            Controls.Add(groupBox1);
            Controls.Add(btnExit);
            Controls.Add(btnAdd);
            Controls.Add(btnDel);
            Controls.Add(loginScreen2);
            Controls.Add(loginScreen1);
            Margin = new Padding(2);
            Name = "EmployeeManagement";
            Size = new Size(1365, 1229);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            Current.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private LoginScreen loginScreen1;
        private LoginScreen loginScreen2;
        private Button btnDel;
        private Button btnAdd;
        private Button btnExit;
        private GroupBox groupBox1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox tbID;
        private TextBox tbPay;
        private TextBox tbName;
        private Label label6;
        private Label label5;
        private TextBox tbMan;
        private TextBox tbEmploy;
        private GroupBox Current;
        private ListView lstEmployees;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}
