using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp1.classes.UsersAccount
{
    /*
     * This class will handle operation involving Funding of the User Account.
     */
    class DepositClass : Accounts,IAccount
    {
        /*
         * This method will deposit the given amount into the user account number
         */
        public bool DepositMoney()
        {
            const string query = "UPDATE bank_accounts SET balance =@amount WHERE id = @id";

            var args = new Dictionary<string, object>
            {
                {"@id",AccountId },
                {"@amount", BalanceAfterDeposit }
            };

            this.Query(query, args);
                return this.numberOfRowsAffected > 0 ? true : false;


        }

        /*
         * This method will perform the addion operation for the user account
         */
        public void UpdateAccountBalance()
        {
            this.BalanceAfterDeposit =  HelperClass.AddBalance(this.GetBalance(this.AccountId), this.DepositAmount);
            
        }
    }
}
