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
        public paymentsScreen(int orderNum, decimal balanceDue)
        {
            InitializeComponent();
            this.orderNum = orderNum;
            this.balanceDue = balanceDue;
        }

        private void applyPaymentButton_Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            decimal paymentAmount = Convert.ToDecimal(clickedButton.Tag);

            if (balanceDue - paymentAmount < 0)
            {
                MessageBox.Show("Payment amount exceeds balance due. Please enter a valid amount.");
                return;
            }
            DatabaseHandler.ApplyPayment(orderNum, paymentAmount, "Cash");
            balanceDue -= paymentAmount;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void applyCustomCash_Click(object sender, EventArgs e)
        {
            decimal paymentAmount;

            paymentAmount = Convert.ToDecimal(customCashTB.Text);

            if (balanceDue - paymentAmount < 0)
            {
                MessageBox.Show("Payment amount exceeds balance due. Please enter a valid amount." + ( balanceDue - paymentAmount));
                return;
            }
            DatabaseHandler.ApplyPayment(orderNum, paymentAmount, "Cash");
            balanceDue -= paymentAmount;
        }
    }
}
