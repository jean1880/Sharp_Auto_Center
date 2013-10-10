using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
 * @author Jean-Luc Desroches
 * 
 * This form displays the calculated totals to the user, using the paramaters passed to it 
 * by the design form
 */
namespace Sharp_Auto_Center
{
    public partial class purchaseForm : Form
    {
        private static decimal TAX_HST = 0.13m; // Ontario tax rate

        // Set variables for the class
        private decimal subTotal;
        private decimal taxTotal;
        private decimal total;

        /**
         * Constructor of the form, rewuires the subtotal to output the results to the user
         * @param subTotal Subtotal to be used in order to calculate the total
         */
        public purchaseForm()
        {
            InitializeComponent();
        }

        /**
         * @param subTotal Set the subtotal
         */
        public void setSubTotal(decimal subTotal)
        {
            this.subTotal = subTotal;
        }

                
        /**
         * When the user cliccks the confirm button show a message box congratulating
         * the user on their new purchase and close out the program
         */
        private void buyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Congratulations");
            Application.Exit();
        }

        /**
         * Catches closing event and close hidden form as well as current form
         */
        private void purchaseForm_Close(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        //When the form activates calculate the subtotal
        private void purchaseForm_Activate(object sender, EventArgs e)
        {
            // Set the subtotal box text to the value of subtotal, and display as currency
            subTotalBox.Text = subTotal.ToString("C");

            // Calculate the tax and display the result to the user
            taxTotal = (subTotal * TAX_HST);
            taxBox.Text = taxTotal.ToString("C");

            // calculate the total and display the results to the user
            total = subTotal + taxTotal;
            totalBox.Text = total.ToString("C");
        }
    }
}
