using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBankSystem.Model
{

    class Account
    {
        public Account()
        {
            balance = 0;
        }
        private double balance;
        public string Number { get; set; }
        public string OpeningDate { get; set; }

        public double Balance
        {
            get { return balance; }
        }

        public bool Deposit(double amount)
        {
            balance += amount;
            return true;
        }

        public bool Withdraw(double amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                return true;
            }
            return false;
        }
    }
}
