using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankLogin
{
    public partial class frmBank : Form
    {
        private readonly List<BankAccount> bankAccounts = new List<BankAccount>
        {
            new BankAccount("Telreyne", 7777, 7777, AccountType.Gold, 6000),
            new BankAccount("Titan", 1234, 1234, AccountType.Silver, 2000),
            new BankAccount("Krooks", 5678, 5678, AccountType.Bronze, 250),
            new BankAccount("Klov", 4321, 4321, AccountType.Silver, 3000),
            new BankAccount("King Cobra", 8765, 8765, AccountType.Bronze, 25)
        };

        private BankAccount loggedInAccount;
        public frmBank()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            int accountNumber = int.Parse(txtAccount.Text);
            int pin = int.Parse(txtPin.Text);

            loggedInAccount = bankAccounts.FirstOrDefault(account => account.AccountNumber == accountNumber && account.Pin == pin);

            if (loggedInAccount != null)
            {
                DisplayAccountInfo();
            }
            else
            {
                MessageBox.Show("Invalid account number or pin.");
            }
        }

        private void DisplayAccountInfo()
        {
            lblWelcome.Text = "Welcome, " + loggedInAccount.Name;
            lblBalance.Text = "Balance: $" + loggedInAccount.Amount;
            lblType.Text = "Account Type: " + loggedInAccount.AccountType.ToString();
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (loggedInAccount != null)
            {
                double depositAmount = double.Parse(txtDeposit.Text);
                loggedInAccount.Deposit(depositAmount);
                DisplayAccountInfo();
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (loggedInAccount != null)
            {
                double withdrawalAmount = double.Parse(txtWithdraw.Text);
                bool success = loggedInAccount.Withdraw(withdrawalAmount);
                if (success)
                {
                    DisplayAccountInfo();
                }
                else
                {
                    MessageBox.Show("Withdrawal failed. Insufficient funds or below minimum balance.");
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (loggedInAccount != null)
            {
                string transactions = string.Join(Environment.NewLine, loggedInAccount.GetLastTransactions());
                MessageBox.Show(transactions, "Last 10 Transactions");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            loggedInAccount = null;
            lblWelcome.Text = "";
            lblBalance.Text = "";
            lblType.Text = "";
            txtAccount.Text = "";
            txtPin.Text = "";
            txtDeposit.Text = "";
            txtWithdraw.Text = "";
        }

        public enum AccountType
        {
            Bronze,
            Silver,
            Gold
        }

        public class BankAccount
        {
            public string Name { get; }
            public int AccountNumber { get; }
            public int Pin { get; }
            public AccountType AccountType { get; }
            public double Amount { get; private set; }
            private readonly List<string> transactions = new List<string>();

            public BankAccount(string name, int accountNumber, int pin, AccountType accountType, double amount)
            {
                Name = name;
                AccountNumber = accountNumber;
                Pin = pin;
                AccountType = accountType;
                Amount = amount;
            }

            public void Deposit(double amount)
            {
                Amount += amount;
                transactions.Add($"Credit: +${amount}");
            }

            public bool Withdraw(double amount)
            {
                if (AccountType == AccountType.Bronze)
                {
                    if (amount > Amount)
                        return false;
                }
                else
                {
                    double minimumBalance = AccountType == AccountType.Silver ? 1000 : 5000;
                    if (Amount - amount < minimumBalance)
                        return false;
                }

                double transactionFee = AccountType == AccountType.Gold ? 0 : amount * 0.01;
                Amount -= (amount + transactionFee);
                transactions.Add($"Debit: -${amount} (Transaction Fee: ${transactionFee})");
                return true;
            }

            public IEnumerable<string> GetLastTransactions()
            {
                int startIndex = Math.Max(transactions.Count - 10, 0);
                return transactions.GetRange(startIndex, Math.Min(10, transactions.Count - startIndex));
            }
        }
    }
}
