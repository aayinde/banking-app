using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp1
{
    /*
     * This Static class handle basic input/output functions of the Banking App
     */
    static class HelperClass
    {

        public static string username;
        public static int users;


        public static decimal AddBalance(decimal num1,decimal num2)
        {
           return num1 + num2;
        }

        public static decimal SubtractBalance(decimal num1,decimal num2)
        {
            return num1 - num2;
        }

        

        public static string GetGetUsername()
        { return username; }


        public static void SetGetUsername(string value)
        { username = value; }

        public static void SetTotalUsers(int value)
        {
            users = value;
        }

        public static int GetTotalUsers()
        {
            return users;
        }

        public static string GetAccountNumberGenerator()
        {
            Random accountNumber = new Random();

            return accountNumber.Next().ToString();

        }
    }
}
