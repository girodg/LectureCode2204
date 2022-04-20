using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day07CL.Banking
{
    public enum BankAccountType
    {
        Checking,
        Savings,
        MoneyMarket
    }
    //Pascal Naming convention.
    //   PascalNamingConvention. every word in the compound word starts with a capital
    public class BankAccount
    {
        #region Fields
        //static means attached to the class.
        static int _numberOfAccounts;

        //non-static means attached to the instances of the class

        //private: ONLY this class can see it
        //public: EVERYONE can see it
        //protected: this class and all child (derived) classes

        //Fields:
        //data: (variables)
        //acct #, routing, balance, type (checking, savings)
        //_camelCasingNamingConvention
        //  evolved: m_iAcctNumber then m_AcctNumber then mAcctNumber or _acctNumber
        private int _acctNumber;
        private double _balance;
        private BankAccountType _accountType;
        #endregion

        #region Properties
        //Properties: gatekeepers
        //Full Property: has a separate backing field
        public BankAccountType TypeOfAccount
        {
            //getter (accessor)
            //same as writing...
            //   public BankAccountType GetTypeOfAccount() {return _accountType;}
            get { return _accountType; }

            //setter (mutator)
            //same as writing..
            //   public void SetTypeOfAccount(BankAccountType value) {_accountType = value;}
            set {
                if (value >= BankAccountType.Checking && value <= BankAccountType.MoneyMarket)
                    _accountType = value;
            }
        }

        //an auto-property. the compiler will provide the backing field
        public int Routing { get; private set; }
        #endregion

        #region Constructors
        //default constructor (no parameters)
        public BankAccount(int acctNum, int routing, double balance, BankAccountType acctType)
        {
            _acctNumber = acctNum;
            Routing = routing;
            _balance = balance;
            TypeOfAccount = acctType;

            //routing = Routing;//BACKWARDS!!!!
        }
        #endregion

        //behavior: (methods)
        //Withdraw, Deposit, Close
        #region Methods
        public double Close()
        {
            double closeAmount = _balance;
            _balance = 0;
            return closeAmount;
        }

        //non-static methods have a hidden parameter called "this"
        //"this" is the object or instance it was called on
        public double Withdraw(double withdrawAmount)
        {
            if (_balance - withdrawAmount >= 0)
            {
                _balance -= withdrawAmount;
                return withdrawAmount;
            }
            throw new InvalidOperationException("Balance cannot go negative.");
        }
        public void Deposit(double deposit)
        {
            _balance += deposit;
        }
        #endregion
    }
}
