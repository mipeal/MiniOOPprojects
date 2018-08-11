using SmallBankSystem.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmallBankSystem
{
    public partial class SmallBankUI : Form
    {
        private Customer _customer = null;
        public SmallBankUI()
        {
            InitializeComponent();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Account account = new Account();
            account.Number = accountNumberEntryTextBox.Text;
            account.OpeningDate = openingDateEntryTextBox.Text;
            if (_customer == null)
            {
                _customer = new Customer(account);
                _customer.Name = customerNameEntryTextBox.Text;
                _customer.Email = emailEntryTextBox.Text;
            }
            MessageBox.Show("Succesfull....!!!");
        }

        private void showDetailsButton_Click(object sender, EventArgs e)
        {
            if (_customer == null)
            {
                MessageBox.Show("No Customer!");
                return;
            }
            customerNameDisplayTextBox.Text = _customer.Name;
            emailDisplayTextBox.Text = _customer.Email;
            accountNumberDisplayTextBox.Text = _customer.AccountNumber;
            openingDateDisplayTextBox.Text = _customer.AccountOpeningDate;
            balanceTextBox.Text = _customer.AccountBalance.ToString();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            if (_customer == null)
            {
                MessageBox.Show("There's no customer or account!");
                return;
            }
            double amount = Convert.ToDouble(amountTextBox.Text);
            if (_customer.AccountDeposit(amount))
            {
                MessageBox.Show(amount + " Tk. Sueccesfully Deposited!");
            }
        }
        private void withdrawButton_Click(object sender, EventArgs e)
        {
            if (_customer == null)
            {
                MessageBox.Show("There's no customer or account!");
                return;
            }
            double amount = Convert.ToDouble(amountTextBox.Text);
            if (_customer.AccountWithdraw(amount))
            {
                MessageBox.Show(amount + " Tk. Sueccesfully Deposited!");
            }
        }
    }
}
