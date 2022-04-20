using Day07CL.Banking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL
{
    static class AccountFactory
    {
        public static BankAccount CreateBankAccount(int acctNum, int routing, double balance, BankAccountType acctType)
        {
            BankAccount acct = new BankAccount(acctNum, routing, balance, acctType);
            return acct;
        }
    }
}
