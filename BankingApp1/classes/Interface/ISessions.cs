using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp1
{
    /*
     * This Interface class allows forms to make use of the prefedined methods.
     */
    interface ISessions
    {
        void LogOut();

        void ViewListOfAccounts();

        void ViewCreateAccount();

        void ViewWithdraw();

        void ViewDeposit();

        void ViewDashboard();
    }
}
