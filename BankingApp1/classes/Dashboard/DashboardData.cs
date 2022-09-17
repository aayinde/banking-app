using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp1.classes
{
    /*
     * This is the Banking Dashboard that also extend the Database abstract class to provide it with database layers
     */
    class DashboardData : DatabaseAbstractClass
    {
        
        /*
         * This will return number of users the bank has.
         */
        public int GetTotalBankUsers()
        {
            const string query = "SELECT DISTINCT COUNT(*) FROM bank_users";

            return CountRecords(query);

        }

        /*
         * This methos will return the Bank users Data
         */
        public DataTable GetAllAccountsUsers()
        {
            const string query = "SELECT users.surname || ' ' || users.lastname AS FullName, acct.number AS AccountNumber,acct.balance AS Balance FROM bank_accounts acct INNER JOIN bank_users users ON acct.user_id = users.id GROUP BY FullName";


            DataTable dt = this.FetchAll(query);

            if(dt ==null || dt.Rows.Count == 0)
            {
                return null;
            }

            return dt;


        }
    }
}
