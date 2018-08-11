using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmallBankSystem.Model
{
    class Customer
    {
        public Customer(Account account)
        {
            CustomerAccount = account;
        }
        public string Name { get; set; }
        public string Email { get; set; }
        private Account CustomerAccount { get; set; }

        public string AccountNumber
        {
            get { return CustomerAccount.Number; }
        }
        public double AccountBalance
        {
            get { return CustomerAccount.Balance; }
        }
        public string AccountOpeningDate
        {
            get { return CustomerAccount.OpeningDate; }
        }

        public bool AccountDeposit(double amount)
        {
            return CustomerAccount.Deposit(amount);
        }
        public bool AccountWithdraw(double amount)
        {
            return CustomerAccount.Withdraw(amount);
        }
    }
}
