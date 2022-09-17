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
    public partial class WithDraw : Form,ISessions
    {
        public WithDraw()
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

        private void WithDraw_Load(object sender, EventArgs e)
        {
            adminUsernameLb.Text = HelperClass.GetGetUsername();
        }

        private void WithdrawMoneyBtn_Click(object sender, EventArgs e)
        {
            if (withdrawAccountTxt.Text == "" && withdrawAmountTxt.Text == "")
            {
                MessageBox.Show(FormsClass.FieldRequired);
            }
            else
            {
                WithdrawClass withdraw = new WithdrawClass();
                if (withdraw.CheckAccountNumberExists(Convert.ToInt32(withdrawAccountTxt.Text)))
                {
                    withdraw.GetUserAccountId(Convert.ToInt32(withdrawAccountTxt.Text));
                    if (withdraw.AccountId == 0)
                    {
                        MessageBox.Show(FormsClass.AccountIdNotFound);
                    } else
                    {
                        withdraw.WithdrawAmount = Convert.ToDecimal(withdrawAmountTxt.Text);
                        if (withdraw.CheckSufficentFund())
                        {
                            withdraw.UpdateAccountBalance();
                            if (withdraw.WithdrawMoney())
                            {
                                ClearForms();
                                MessageBox.Show(FormsClass.WithdrawSuccess);
                            } else
                            {
                                MessageBox.Show(FormsClass.CouldNotWithdraw);
                            }

                        } else
                        {
                            MessageBox.Show(FormsClass.InsuffientBalance);
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
            withdrawAmountTxt.Text = "";
            withdrawAccountTxt.Text = "";
        }

        private void DashboardBtn_Click(object sender, EventArgs e) => ViewDashboard();
        
    }
}
