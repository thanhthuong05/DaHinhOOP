using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_BanKing
{
    class Account
    {
        private double _balance;

        public double Balance
        {
            set { _balance = value;  }
            get { return _balance; }
        }
        public virtual bool WithDraw(double amount)
        {
            return false;
        }
        public virtual bool Deposit(double amount)
        {
            return false;
        }
        public void PrintBalance()
        {
            Console.WriteLine("Balance: {0}", _balance);
        }
    }

    //dinh nghia lop SavingAccount
    class SavingAccount : Account
    {
        private double _IntereRate = 0.8;

        public  SavingAccount() : base () { }
        public SavingAccount(double balance) : base(balance)
        {
        }
        public double InteresRate
        {
            set { _IntereRate = value; }
            get { return _IntereRate; }
        }
        public override bool WithDraw(double amount)
        {
            return false;
        }
        public override bool Deposit(double amount)
        {
            return false;
        }
        class CheckingAccount : Account
        {
            public CheckingAccount() : base() { }
            public CheckingAccount(double balance ) : base(balance)
            {
            }
        }
        public override bool WithDraw(double amount)
        {
            return false;
        }
        public override bool Deposit(double amount)
        {
            return false;
        }
    }
}
