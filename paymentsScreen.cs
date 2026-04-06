using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace restaurantPOS
{
    public partial class paymentsScreen : Form
    {
        int orderNum;
        decimal balanceDue;
        decimal paymentsApplied = 0;
        public paymentsScreen(int orderNum, decimal balanceDue)
        {
            InitializeComponent();
            this.orderNum = orderNum;
            this.balanceDue = balanceDue;
            cardAmountTB.Text = balanceDue.ToString("0.00"); // Autofill in balance due in credit card payment textbox
            updatePaymentInfo();
        }

        private void applyPaymentButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            decimal paymentAmount = Convert.ToDecimal(clickedButton.Tag); // Gets payment amount from button's Tag.

            if (balanceDue - paymentAmount < 0)
            {
                MessageBox.Show("Payment amount exceeds balance due. Please enter a valid amount.");
                return;
            }
            DatabaseHandler.ApplyPayment(orderNum, paymentAmount, "Cash");
            balanceDue -= paymentAmount;
            paymentsApplied += paymentAmount;
            updatePaymentInfo();
            cardAmountTB.Text = balanceDue.ToString("0.00");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void applyCustomCash_Click(object sender, EventArgs e)
        {
            decimal paymentAmount;

            try
            {
                paymentAmount = Math.Round(Convert.ToDecimal(customCashTB.Text), 2);
            }
            catch
            {
                paymentAmount = 0;
            }

            if (paymentAmount <= 0) // Do nothing if a negative or zero payment is entered
            {
                customCashTB.Text = "";
                return;
            }

            if (Math.Round((balanceDue - paymentAmount), 2) < 0)
            {
                MessageBox.Show("Payment amount exceeds balance due. Please enter a valid amount." + (balanceDue - paymentAmount));
                return;
            }
            DatabaseHandler.ApplyPayment(orderNum, paymentAmount, "Cash");
            balanceDue -= paymentAmount;
            paymentsApplied += paymentAmount;
            updatePaymentInfo();
            customCashTB.Text = "";
            cardNumberTB.Text = "";
            cardAmountTB.Text = balanceDue.ToString("0.00");
        }

        private void cardPaymentButton_Click(object sender, EventArgs e)
        {
            string cardNumber = cardNumberTB.Text;
            if (cardNumber.Length != 16)
            {
                MessageBox.Show("Please enter a valid 16-digit card number.");
                return;
            }

            decimal paymentAmount;
            try
            {
                paymentAmount = Math.Round(Convert.ToDecimal(cardAmountTB.Text), 2);
            }
            catch
            {
                paymentAmount = 0;
            }

            if (paymentAmount <= 0) // Do nothing if a negative or zero payment is entered
            {
                cardAmountTB.Text = "";
                return;
            }

            if (Math.Round((balanceDue - paymentAmount), 2) < 0)
            {
                MessageBox.Show("Payment amount exceeds balance due. Please enter a valid amount." + (balanceDue - paymentAmount));
                return;
            }
            DatabaseHandler.ApplyPayment(orderNum, paymentAmount, "Card-" + cardNumber);
            balanceDue -= paymentAmount;
            paymentsApplied += paymentAmount;
            updatePaymentInfo();
            cardAmountTB.Text = balanceDue.ToString("0.00");
            cardNumberTB.Text = "";
        }

        private void updatePaymentInfo()
        {
            appliedPaymentsLabel.Text = "Payments Applied: $" + paymentsApplied.ToString("0.00");
            balanceDueLabel.Text = "Balance Due: $" + balanceDue.ToString("0.00");

        }
    }
}
