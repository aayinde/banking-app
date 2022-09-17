using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp1.classes.UsersAccount
{
    /*
     * This method will perform operations involving the user withdrawing funds
     */
    class WithdrawClass : Accounts,IAccount
    {
        /*
         * This method will perform the withdraw process
         */
        public bool WithdrawMoney()
        {
            const string query = "UPDATE bank_accounts SET balance = @amount WHERE id = @id";

            var args = new Dictionary<string, object>
            {
                {"@amount", BalanceAfterWithdraw },
                {"@id",AccountId }
            };

            this.Query(query, args);

            return this.numberOfRowsAffected > 0 ? true : false;

        }

        /*
         * This method will peform the withdraw operation
         */
        public void UpdateAccountBalance()
        {
            this.BalanceAfterWithdraw = HelperClass.SubtractBalance(this.GetBalance(this.AccountId), this.WithdrawAmount);
        }

        /*
         * This method will check maybe the user balance is sufficient enough in order to be able to withdraw.
         */
        public bool CheckSufficentFund()
        {
            return this.GetBalance(this.AccountId) >= this.WithdrawAmount ? true : false;
        }
    }
}
