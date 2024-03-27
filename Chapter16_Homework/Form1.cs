using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter16_Homework
{
    public partial class frmDelivery : Form
    {
        private const int MaxLetters = 10;
        private readonly Letter[] sentLetters = new Letter[MaxLetters];
        private int letterCount = 0;

        public frmDelivery()
        {
            InitializeComponent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRecipient.Clear();
            txtDate.Clear();
            txtTracking.Clear();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (letterCount >= MaxLetters)
            {
                MessageBox.Show("You have reached the maximum limit of letters that can be sent.");
                return;
            }

            string recipient = txtRecipient.Text.Trim();
            DateTime sentDate;

            if (!DateTime.TryParse(txtDate.Text, out sentDate))
            {
                MessageBox.Show("Please enter a valid date.");
                return;
            }

            Letter letter;
            if (string.IsNullOrWhiteSpace(txtTracking.Text))
            {
                letter = new Letter(recipient, sentDate);
            }
            else
            {
                string trackingNumber = txtTracking.Text.Trim();
                letter = new CertifiedLetter(recipient, sentDate, trackingNumber);
            }

            sentLetters[letterCount++] = letter;
            UpdateTransactionLog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void UpdateTransactionLog()
        {
            lblOutput.Text = "Transaction Log:\n\n";
            for (int i = letterCount - 1; i >= 0; i--)
            {
                lblOutput.Text += sentLetters[i].ToString() + "\n";
            }
        }

        public class Letter
        {
            public string Recipient { get; }
            public DateTime SentDate { get; }

            public Letter(string recipient, DateTime sentDate)
            {
                Recipient = recipient;
                SentDate = sentDate;
            }

            public virtual double Price => 0.50;

            public override string ToString()
            {
                return $"Recipient: {Recipient}, Sent Date: {SentDate.ToShortDateString()}, Price: {Price:C}";
            }
        }

        public class CertifiedLetter : Letter
        {
            public string TrackingNumber { get; }

            public CertifiedLetter(string recipient, DateTime sentDate, string trackingNumber) : base(recipient, sentDate)
            {
                TrackingNumber = trackingNumber;
            }

            public override double Price => 0.50 + 0.15;

            public override string ToString()
            {
                return base.ToString() + $", Tracking Number: {TrackingNumber}";
            }
        }
    }
}
