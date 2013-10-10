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
        public purchaseForm(decimal subTotal)
        {
            this.subTotal = subTotal;
            InitializeComponent();
        }

        /**
         * On load of the form, take the subtotal passed to the form and calculate the amount 
         * of tax to be charged, as well as the total and display this to the user
         */
        private void purchaseForm_Load(object sender, EventArgs e)
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
