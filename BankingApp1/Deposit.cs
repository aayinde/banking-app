using BankingApp1.classes.Helpers;
using BankingApp1.classes.UsersAccount;
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
    public partial class Deposit : Form,ISessions
    {
        public Deposit()
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

        private void Deposit_Load(object sender, EventArgs e)
        {
            adminUsernameLb.Text = HelperClass.GetGetUsername();
        }

        private void DepositMoneyBtn_Click(object sender, EventArgs e)
        {
            if(accountNumberTxt.Text == "" && amountToDepositTxt.Text == "")
            {
                MessageBox.Show(FormsClass.AccountFieldRequired);
            } else
            {

                DepositClass depositClass = new DepositClass();
                if(depositClass.CheckAccountNumberExists(Convert.ToInt32(accountNumberTxt.Text))){
                    depositClass.GetUserAccountId(Convert.ToInt32(accountNumberTxt.Text));
                    if(depositClass.AccountId == 0 )
                    {
                        MessageBox.Show(FormsClass.AccountIdNotFound);
                    } else
                    {
                        depositClass.DepositAmount = Convert.ToDecimal(amountToDepositTxt.Text);
                        depositClass.UpdateAccountBalance();
                        if (depositClass.DepositMoney())
                        {
                            ClearForms();
                            MessageBox.Show(FormsClass.AccountFunded);
                        } else
                        {
                            MessageBox.Show(FormsClass.AccountNotFunded);
                        }

                    }
                    
                } else
                {
                    MessageBox.Show(FormsClass.AccountNotFound);
                }

            }
        }

        private void ClearForms()
        {
            accountNumberTxt.Text = "";
            amountToDepositTxt.Text = "";
        }

        private void DashboardBtn_Click(object sender, EventArgs e) => ViewDashboard();
       
    }
}
