using BankingApp1.classes.Helpers;
using BankingApp1.classes.UsersAccount;
using System;
using System.Windows.Forms;

namespace BankingApp1
{
    public partial class CreateAccount : Form, ISessions
    {
        public CreateAccount()
        {
            InitializeComponent();
        }

        private void LogOutBtn_Click(object sender, EventArgs e) => LogOut();


        private void CreateAccountBtn_Click(object sender, EventArgs e) => ViewCreateAccount();

        private void AllAccountsBtn_Click(object sender, EventArgs e) => ViewListOfAccounts();

        private void WithdrawBtn_Click(object sender, EventArgs e) => ViewWithdraw();

        private void DepositBtn_Click(object sender, EventArgs e) => ViewDeposit();

        private void CreateAccount_Load(object sender, EventArgs e)
        {
            adminUsernameLb.Text = HelperClass.GetGetUsername();
            errorProvider1.ContainerControl = this;
        }
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

        private void RegisterBtn_Click(object sender, EventArgs e)
        {

            bool ValidSurname = ValidateSurname();
            bool ValidLastname = ValidateLastname();
            bool ValidBirth = ValidateBirth();
            bool ValidGender = ValidateGender();
            bool ValidPhone = ValidatePhone();
            bool ValidOccupation = ValidateOccupation();
            bool ValidSalary = ValidateSalary();

            if (ValidSurname && ValidLastname && ValidBirth && ValidGender && ValidPhone && ValidOccupation && ValidSalary)
            {
                AccountCreate accountCreate = new AccountCreate();
                accountCreate.Surname = surnameTxt.Text;
                accountCreate.LastName = lastnameTxt.Text;
                accountCreate.DateOfBirth = dateOfBirthPicker.Text;
                accountCreate.Gender = genderCb.SelectedItem.ToString();
                accountCreate.Phone = phoneTxt.Text;
                accountCreate.Occupation = occupationCb.SelectedItem.ToString();
                accountCreate.Salary = salaryTxt.Text;

                var success1 = accountCreate.CreateNewAccount();
                var success2 = accountCreate.AccountNumber();

                if (success1 && success2)
                {
                    // Clear controls once the employee is inserted successfully
                    ClearForm();
                    MessageBox.Show(FormsClass.AccountCreated+FormsClass.AccountNumber+accountCreate.AccountID.ToString()+FormsClass.FundAccount);
                }
                else
                {

                    MessageBox.Show(FormsClass.AccountNotCreated);
                }
            }
            else
            {
                MessageBox.Show(FormsClass.FieldRequired);
            }
          
        }

        private void ClearForm()
        {
            surnameTxt.Text = "";
            lastnameTxt.Text = "";
            dateOfBirthPicker.Text = "";
            genderCb.Text = "";
            phoneTxt.Text = "";
            salaryTxt.Text = "";
            occupationCb.Text = "";

        }

        private void DashboardBtn_Click(object sender, EventArgs e) => ViewDashboard();

  
        private bool ValidateSurname()
        {
            bool surnameStatus = true;
            if (string.IsNullOrEmpty(surnameTxt.Text))
            {
                errorProvider1.SetError(surnameTxt, FormsClass.EnterSurname);
                surnameStatus = false;

            }
            else

                errorProvider1.SetError(surnameTxt, "");
            return surnameStatus;

        }

        private bool ValidateLastname()
        {
            bool lastnameStatus = true;
            if (string.IsNullOrEmpty(lastnameTxt.Text))
            {
                errorProvider1.SetError(lastnameTxt, FormsClass.EnterLastname);
                lastnameStatus = false;

            }
            else

                errorProvider1.SetError(lastnameTxt, "");
            return lastnameStatus;

        }

        private bool ValidateGender()
        {
            bool genderStatus = true;
            if (string.IsNullOrEmpty(genderCb.Text))
            {
                errorProvider1.SetError(genderCb, FormsClass.SelectGender);
                genderStatus = false;

            }
            else

                errorProvider1.SetError(genderCb, "");
            return genderStatus;
        }
        private bool ValidatePhone()
        {
            bool phoneStatus = true;
            if (string.IsNullOrEmpty(phoneTxt.Text))
            {
                errorProvider1.SetError(phoneTxt, FormsClass.EnterPhone);
                phoneStatus = false;

            }
            else
            {
                errorProvider1.SetError(phoneTxt, "");
                try
                {
                    double validPhone = double.Parse(phoneTxt.Text);
                    if (validPhone < 0)
                    {
                        errorProvider1.SetError(phoneTxt, FormsClass.EnterPhone);
                        phoneStatus = false;

                    }
                    else if (validPhone.ToString().Length < 12 || validPhone.ToString().Length >= 14)
                    {
                        errorProvider1.SetError(phoneTxt, FormsClass.PhoneLength);
                        phoneStatus = false;
                    }
                    else
                    {
                        errorProvider1.SetError(phoneTxt, "");
                    }


                }
                catch
                {
                    errorProvider1.SetError(phoneTxt, FormsClass.NumbersOnly);
                    phoneStatus = false;
                }
            }


            return phoneStatus;
        }
        private bool ValidateOccupation()
        {
            bool occupationStatus = true;
            if (string.IsNullOrEmpty(occupationCb.Text))
            {
                errorProvider1.SetError(occupationCb, FormsClass.SelectOccupation);
                occupationStatus = false;

            }
            else

                errorProvider1.SetError(occupationCb, "");
            return occupationStatus;
        }
        private bool ValidateSalary()
        {
            bool salaryStatus = true;
            if (string.IsNullOrEmpty(salaryTxt.Text))
            {
                errorProvider1.SetError(salaryTxt, FormsClass.EnterSalary);
                salaryStatus = false;

            }
            else
            {
                errorProvider1.SetError(salaryTxt, "");
                try
                {
                    int validSalary = int.Parse(salaryTxt.Text);
                    errorProvider1.SetError(salaryTxt, "");
                    if (validSalary < 0)
                    {
                        errorProvider1.SetError(salaryTxt, FormsClass.NumbersOnly);
                        salaryStatus = false;
                    }
                    else
                    {
                        errorProvider1.SetError(salaryTxt, "");
                    }

                }
                catch
                {
                    errorProvider1.SetError(salaryTxt, FormsClass.NumbersOnly);
                    salaryStatus = false;
                }
            }


            return salaryStatus;
        }
        private bool ValidateBirth()
        {
            bool birthStatus = true;
            if (dateOfBirthPicker.Value.Year > 2005 || dateOfBirthPicker.Value.Year > DateTime.Now.Year)
            {
                errorProvider1.SetError(dateOfBirthPicker, FormsClass.DateOfBirth);
                birthStatus = false;

            }
            else

                errorProvider1.SetError(dateOfBirthPicker, "");
            return birthStatus;
        }
    }
}
