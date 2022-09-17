using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp1.classes.UsersAccount
{
    /*
     * This will will perform operations involving the user account, and it extend the database Abstract class to provide it with functionality.
     */
    abstract class Accounts : DatabaseAbstractClass
    {

        /*
         * properties declearation
         */
        public decimal WithdrawAmount { get; set; }
        public decimal DepositAmount { get; set; }

        public decimal BalanceAfterDeposit { get; set; }

        public decimal BalanceAfterWithdraw { get; set; }

        public int AccountId
        {
            get; set; }

        /*
         * This method will check for the given account number maybe it exists.
         */
        public bool CheckAccountNumberExists(int number)
        {
            const string query = "SELECT DISTINCT id FROM bank_accounts WHERE number = @number";

            var args = new Dictionary<string, object>
            {
                {"@number",number}               

            };

            DataTable dt = this.SelectQuery(query, args);
                       
            return dt.Rows.Count > 0 ? true : false;

        }

        /*
         * This method will fetch the Users ID using the given account number
         */
        public int GetUserAccountId(int number)
        {
            const string query = "SELECT DISTINCT id FROM bank_accounts WHERE number = @number";

            var args = new Dictionary<string, object>
            {
                {"@number",number}

            };

            DataTable dt = this.SelectQuery(query,args);


            this.AccountId = Convert.ToInt32(dt.Rows[0]["id"]);

            return this.AccountId;


        }

        /*
         * This method will return the given user account balances
         */
        public decimal GetBalance(int id)
        {
            const string query = "SELECT balance FROM bank_accounts WHERE id = @id";

            var args = new Dictionary<string, object>
            {
                {"@id",id}

            };

            DataTable dt = this.SelectQuery(query, args);
            return dt.Rows.Count == 0 ?  0 : Convert.ToDecimal(dt.Rows[0]["balance"]);
        }
    }
}
