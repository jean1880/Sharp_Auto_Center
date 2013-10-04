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
 */
namespace Sharp_Auto_Center
{
    public partial class teslaSForm : Form
    {
        // set constants
        private static decimal METAL_PAINT_COST     = 800m;
        private static decimal GLASS_ROOFTOP_COST   = 2800m;

        // set adding variables
        private decimal Total;
        private decimal roofCost    = 0;
        private decimal paintCost   = 0;

        public teslaSForm()
        {
            InitializeComponent();
        }
        
        private void PaintButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (solidPaintButton.Checked && this.paintCost > -METAL_PAINT_COST)
            {
                colourOptionBox.Visible = true;
                colourOptionBox.DataSource = colours(0);

                // check if the price has been set already, if it has, exit the method and save processor cycles
                if (this.paintCost == 0)
                {
                    return;
                }

                this.paintCost = 0-METAL_PAINT_COST;                

                // Set solid paint price label
                solidPaintLabel.Text = (METAL_PAINT_COST - METAL_PAINT_COST).ToString("C");
                solidPaintLabel.ForeColor = Color.White;

                // set metal paint price label
                metalPaintLabel.Text = METAL_PAINT_COST.ToString("C");
                metalPaintLabel.ForeColor = Color.PaleGreen;
            }
            else
            {
                // Set colour choices
                colourOptionBox.Visible = true;
                colourOptionBox.DataSource = colours(1);

                // check if the price has been set already, if it has, exit the method and save processor cycles
                if (this.paintCost == METAL_PAINT_COST)
                {
                    return;
                }

                // Set solid paint price label
                solidPaintLabel.Text = (0-METAL_PAINT_COST).ToString("C");
                solidPaintLabel.ForeColor = Color.Red;

                // set metal paint price label
                metalPaintLabel.Text = (METAL_PAINT_COST - METAL_PAINT_COST).ToString("C");
                metalPaintLabel.ForeColor = Color.White;

                this.paintCost = METAL_PAINT_COST;
            }

            addToTotal(this.paintCost);
        }

        private void roofButtons_CheckedChanged(object sender, EventArgs e)
        {
            

            if(solidRoofButton.Checked)
            {
                if (this.roofCost == GLASS_ROOFTOP_COST)
                {
                    this.roofCost = -GLASS_ROOFTOP_COST;
                }
            }
            else
            {
                this.roofCost = GLASS_ROOFTOP_COST;
            }

            addToTotal(this.roofCost);
        }

        private Array colours(int selection)
        {
            if (selection == 0)
            {
                return new string[3] { "Black", "White", "Red" };
            }
            else
            {
                return new string[5] { "Silver", "Steel", "Ebony", "Metallic Red", "Metallic Blue" };
            }
        }

        

        private void teslaSForm_Load(object sender, EventArgs e)
        {
            tabMenu.Size    = new Size(420,415);
            this.Size       = new Size(420,450);
        }

        /**
         * Adds the cost of an item to the total
         */
        private void addToTotal(decimal Cost)
        {
            // Add cost to total
            this.Total += Cost;

            // assign total to total text box
            totalBox.Text = Total.ToString("C");
        }
    }
}
