using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp1.classes.Helpers
{
    /*
     * This Static class will handle text based output for the Bank Classes
     */
    static class FormsClass
    {
        static public string AccountNotFound = "Acccount Does not Exist";
        static public string AccountNotFunded = "Account Could'nt be Funded! \nTry Again Later";
        static public string AccountFunded = "Account funded Successfully!";
        static public string AccountIdNotFound = "Acccount ID not Found.\n please Contact Adminstrator!";
        static public string AccountFieldRequired = "Please Account number and Amount you'll like to deposit";
        static public string InsuffientBalance = "Sorry! Insufficient Balances";
        static public string CouldNotWithdraw = "Sorry! Couldn't withdraw. \n Please Contact Adminstrator";
        static public string WithdrawSuccess = "Withdraw Successful!\n Thank you for Choosing our Bank.";
        static public string FieldRequired = "Please all input fields are required.";
        static public string AccountCreated = "Account Created Successfully";
        static public string AccountNotCreated = "Sorry! Could'nt create an Account.\n Error Occured. Please try again..";
        static public string InvalidLogin = "Username or password incorrect";

        static public string EnterSurname = "Please provide your Surname!";
        static public string EnterLastname = "Please provide your Lastname!";
        static public string SelectGender = "Please select your Gender!";
        static public string EnterPhone = "Please provide your Phone Number!";
        static public string SelectOccupation = "Please select your Occupation!";
        static public string EnterSalary = "Please enter your Salary!";
        static public string DateOfBirth = "You must be atleast 18yrs before you can open a Bank Account!";

        static public string NumbersOnly = "Only Numberic character is allowed!";
        static public string PhoneLength = "Phone number must be atleast 13 in numbers!";
        static public string AccountNumber = "\nYour Account Number is: ";
        static public string FundAccount = "\nPlease Fund your Account, So you can start enjoying our services.";

    }
}
