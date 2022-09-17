namespace BankingApp1
{
    partial class Deposit
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
            this.depositMoneyBtn = new System.Windows.Forms.Button();
            this.amountToDepositTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.accountNumberTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.adminUsernameLb = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.depositBtn = new System.Windows.Forms.Button();
            this.withdrawBtn = new System.Windows.Forms.Button();
            this.allAccountsBtn = new System.Windows.Forms.Button();
            this.createAccountBtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dashboardBtn = new System.Windows.Forms.Button();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // depositMoneyBtn
            // 
            this.depositMoneyBtn.Location = new System.Drawing.Point(413, 164);
            this.depositMoneyBtn.Name = "depositMoneyBtn";
            this.depositMoneyBtn.Size = new System.Drawing.Size(75, 23);
            this.depositMoneyBtn.TabIndex = 17;
            this.depositMoneyBtn.Text = "Deposit";
            this.depositMoneyBtn.UseVisualStyleBackColor = true;
            this.depositMoneyBtn.Click += new System.EventHandler(this.DepositMoneyBtn_Click);
            // 
            // amountToDepositTxt
            // 
            this.amountToDepositTxt.Location = new System.Drawing.Point(121, 40);
            this.amountToDepositTxt.Name = "amountToDepositTxt";
            this.amountToDepositTxt.Size = new System.Drawing.Size(306, 20);
            this.amountToDepositTxt.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Amount to Deposit";
            // 
            // accountNumberTxt
            // 
            this.accountNumberTxt.Location = new System.Drawing.Point(121, 14);
            this.accountNumberTxt.Name = "accountNumberTxt";
            this.accountNumberTxt.Size = new System.Drawing.Size(306, 20);
            this.accountNumberTxt.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Account Number";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.amountToDepositTxt);
            this.groupBox4.Controls.Add(this.accountNumberTxt);
            this.groupBox4.Location = new System.Drawing.Point(19, 48);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(451, 77);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Depositor Details";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.logoutBtn);
            this.groupBox3.Controls.Add(this.adminUsernameLb);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(483, 11);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(291, 45);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Location = new System.Drawing.Point(208, 19);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(75, 23);
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.Text = "Logout";
            this.logoutBtn.UseVisualStyleBackColor = true;
            this.logoutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // adminUsernameLb
            // 
            this.adminUsernameLb.AutoSize = true;
            this.adminUsernameLb.Location = new System.Drawing.Point(92, 8);
            this.adminUsernameLb.Name = "adminUsernameLb";
            this.adminUsernameLb.Size = new System.Drawing.Size(55, 13);
            this.adminUsernameLb.TabIndex = 1;
            this.adminUsernameLb.Text = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome back:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.depositMoneyBtn);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Location = new System.Drawing.Point(278, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(496, 230);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deposit";
            // 
            // depositBtn
            // 
            this.depositBtn.Enabled = false;
            this.depositBtn.Location = new System.Drawing.Point(6, 150);
            this.depositBtn.Name = "depositBtn";
            this.depositBtn.Size = new System.Drawing.Size(192, 23);
            this.depositBtn.TabIndex = 3;
            this.depositBtn.Text = "Deposit";
            this.depositBtn.UseVisualStyleBackColor = true;
            this.depositBtn.Click += new System.EventHandler(this.DepositBtn_Click);
            // 
            // withdrawBtn
            // 
            this.withdrawBtn.Location = new System.Drawing.Point(6, 111);
            this.withdrawBtn.Name = "withdrawBtn";
            this.withdrawBtn.Size = new System.Drawing.Size(192, 23);
            this.withdrawBtn.TabIndex = 2;
            this.withdrawBtn.Text = "Withdraw";
            this.withdrawBtn.UseVisualStyleBackColor = true;
            this.withdrawBtn.Click += new System.EventHandler(this.WithdrawBtn_Click);
            // 
            // allAccountsBtn
            // 
            this.allAccountsBtn.Location = new System.Drawing.Point(6, 73);
            this.allAccountsBtn.Name = "allAccountsBtn";
            this.allAccountsBtn.Size = new System.Drawing.Size(192, 23);
            this.allAccountsBtn.TabIndex = 1;
            this.allAccountsBtn.Text = "All Accounts";
            this.allAccountsBtn.UseVisualStyleBackColor = true;
            this.allAccountsBtn.Click += new System.EventHandler(this.AllAccountsBtn_Click);
            // 
            // createAccountBtn
            // 
            this.createAccountBtn.Location = new System.Drawing.Point(6, 36);
            this.createAccountBtn.Name = "createAccountBtn";
            this.createAccountBtn.Size = new System.Drawing.Size(192, 23);
            this.createAccountBtn.TabIndex = 0;
            this.createAccountBtn.Text = "Create New Account";
            this.createAccountBtn.UseVisualStyleBackColor = true;
            this.createAccountBtn.Click += new System.EventHandler(this.CreateAccountBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.depositBtn);
            this.groupBox1.Controls.Add(this.withdrawBtn);
            this.groupBox1.Controls.Add(this.allAccountsBtn);
            this.groupBox1.Controls.Add(this.createAccountBtn);
            this.groupBox1.Location = new System.Drawing.Point(26, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 187);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // dashboardBtn
            // 
            this.dashboardBtn.Location = new System.Drawing.Point(26, 24);
            this.dashboardBtn.Name = "dashboardBtn";
            this.dashboardBtn.Size = new System.Drawing.Size(75, 34);
            this.dashboardBtn.TabIndex = 10;
            this.dashboardBtn.Text = "Dashboard";
            this.dashboardBtn.UseVisualStyleBackColor = true;
            this.dashboardBtn.Click += new System.EventHandler(this.DashboardBtn_Click);
            // 
            // Deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 363);
            this.ControlBox = false;
            this.Controls.Add(this.dashboardBtn);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Deposit";
            this.Text = "Deposit";
            this.Load += new System.EventHandler(this.Deposit_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button depositMoneyBtn;
        private System.Windows.Forms.TextBox amountToDepositTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox accountNumberTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.Label adminUsernameLb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button depositBtn;
        private System.Windows.Forms.Button withdrawBtn;
        private System.Windows.Forms.Button allAccountsBtn;
        private System.Windows.Forms.Button createAccountBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button dashboardBtn;
    }
}