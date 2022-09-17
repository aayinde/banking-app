using BankingApp1.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApp1
{
    public partial class AllAccounts : Form ,ISessions
    {
        public AllAccounts()
        {
            InitializeComponent();           
        }

        private void LogOutBtn_Click(object sender, EventArgs e) => LogOut();


        private void CreateAccountBtn_Click(object sender, EventArgs e) => ViewCreateAccount();

        private void AllAccountsBtn_Click(object sender, EventArgs e) => ViewListOfAccounts();

        private void WithdrawBtn_Click(object sender, EventArgs e) => ViewWithdraw();

        private void DepositBtn_Click(object sender, EventArgs e) => ViewDeposit();

        public void LogOut()
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.Show();
        }

        public void ViewListOfAccounts()
        {
            this.Close();
            AllAccounts accounts = new AllAccounts();
            accounts.Show();
        }

        public void ViewWithdraw()
        {
            this.Close();
            WithDraw withdraw = new WithDraw();
            withdraw.Show();
        }

        public void ViewDeposit()
        {
            this.Close();
            Deposit deposit = new Deposit();
            deposit.Show();
        }

        public void ViewDashboard()
        {
            this.Close();
            Dashboard dash = new Dashboard();
            dash.Show();
        }

        public void ViewCreateAccount()
        {
            this.Close();
            CreateAccount createAccount = new CreateAccount();
            createAccount.Show();
        }

        private void AllAccounts_Load(object sender, EventArgs e)
        {
            adminUsernameLb.Text = HelperClass.GetGetUsername();
            DashboardData dashboardData = new DashboardData();
            userDataTable.DataSource = dashboardData.GetAllAccountsUsers();
        }

        private void DashboardBtn_Click(object sender, EventArgs e) => ViewDashboard();
        
    }
}
