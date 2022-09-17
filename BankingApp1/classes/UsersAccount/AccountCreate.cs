using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp1.classes.UsersAccount
{
    /*
     * This method extend the database Abstract class to provide with layer for accessing the database to perform queries.
     */
    class AccountCreate : DatabaseAbstractClass
    {
        /*
         * properties declearation
         */

        public string AccountID { get; set; }
        public string Surname { get; set; }
        public string LastName { get; set; }

        public string Phone { get; set; }

        public string DateOfBirth { get; set; }
        public string Salary { get; set; }

        public string Gender { get; set; }
        public string Occupation { get; set; }

        /*
         * This method will the user profile bank account.
         */
        public bool CreateNewAccount()
        {
            const string query = "INSERT INTO bank_users(surname,lastname,date_of_birth,gender,phone,occupation,salary) VALUES(@firstname,@lastname,@dateOfBirth,@gender,@phone,@occupation,@salary)";


            var args = new Dictionary<string, object>
            {
                {"@firstname",Surname },
                {"@lastname",LastName },
                {"@dateOfBirth",DateOfBirth },
                {"@gender",Gender },
                {"@phone",Phone },

                {"@occupation",Occupation },
                {"@salary",Salary }

            };

            this.Query(query, args);

            return this.numberOfRowsAffected > 0 ? true : false;

        }

        /*
         * This will method will create the account number for the user.
         */
        public bool AccountNumber()
        {
            const string query = "INSERT INTO bank_accounts (user_id,number) VALUES(@user_id,@number)";
            this.AccountID = HelperClass.GetAccountNumberGenerator();
            var args = new Dictionary<string, object>
            {
                {"@user_id",this.lastInsertId},
                {"@number",this.AccountID}
            };

            this.Query(query, args);            
            return this.numberOfRowsAffected > 0 ? true : false;
        }


    }
}
