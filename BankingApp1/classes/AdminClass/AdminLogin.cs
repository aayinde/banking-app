using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp1
{
    /*
     * This class will handle functionality with the Admin login, this class extend the DatabaseAbstractClass to provide it with database access layers
     * 
     */
    class AdminLogin : DatabaseAbstractClass
    {

        public string adminUsername;

        /*
         * This method will check in the database to see if the given value corespond with what is in the database.
         */
        public int CheckLoginAdmin(string username, string password)
        {
            /*
             * Declearing properties and assigning value.
             */
            const string query = "SELECT * FROM bank_admins WHERE username = @username AND password = @password";

            var args = new Dictionary<string, object>
            {
                {"@username",username },
                {"@password",password }
            };

            DataTable dt = SelectQuery(query, args);
            if (dt == null || dt.Rows.Count == 0)
            {
                return this.numberOfRowsAffected;
            }

            this.id = Convert.ToInt32(dt.Rows[0]["id"]);

            return this.id;
        }

        /*
         * The method will return the ID of the given admin.
         */
        public string GetAdminUsernameUsingId(int adminID)
        {
            const string query = "SELECT * FROM bank_admins WHERE id = @id";

            var args = new Dictionary<string, object>
            {
                {"@id",adminID}

            };


            DataTable dt = SelectQuery(query, args);
            if (dt == null || dt.Rows.Count == 0)
            {
                return this.numberOfRowsAffected.ToString();
            }

            this.adminUsername = dt.Rows[0]["username"].ToString();

            return this.adminUsername;
        }
    }
}
