using BankingApp1.classes;
using BankingApp1.classes.Helpers;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text.ToString() != "" && txtPassword.Text.ToString() != "")
            {
                AdminLogin Admin = new AdminLogin();
                string username = txtUsername.Text.ToString();
                string password = txtPassword.Text.ToString();
                Admin.CheckLoginAdmin(username, password);
                if (Admin.id != 1)
                {
                    MessageBox.Show(FormsClass.InvalidLogin);
                }
                else
                {
                    MessageBox.Show("Welcome back " + username);
                    Dashboard dash = new Dashboard();
                    DashboardData dashboardData = new DashboardData();
                    HelperClass.SetGetUsername(Admin.GetAdminUsernameUsingId(Admin.id));
                    HelperClass.SetTotalUsers(dashboardData.GetTotalBankUsers());                    
                    this.Hide();
                    dash.Show();
                }
            }
            else
            {
                MessageBox.Show(FormsClass.FieldRequired);
            }
        }

    }
}
