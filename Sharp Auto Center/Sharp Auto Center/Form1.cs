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
        private static decimal METAL_PAINT_COST         = 800m;
        private static decimal GLASS_ROOFTOP_COST       = 2800m;
        private static decimal WHEEL_19_CYCLONE_COST    = 2800m;
        private static decimal WHEEL_21_CYCLONE_COST    = 4900m;
        private static decimal BASE_CAR_COST            = 78970m;
        private static decimal NONE                     = 0m;

        // set adding variables
        private decimal total       = BASE_CAR_COST;
        private decimal roofCost    = 0;
        private decimal paintCost   = 0;
        private decimal wheelCost   = 0;

        public teslaSForm()
        {
            InitializeComponent();
        }
        
        private void PaintButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (solidPaintButton.Checked && this.paintCost > -METAL_PAINT_COST)
            {
                // set colour options
                colourOptionBox.Visible = true;
                colourOptionBox.DataSource = colours(0);

                // check if the price has been set already, if it has, exit the method and save processor cycles
                if (this.paintCost == 0)
                {
                    return;
                }

                this.paintCost = 0;                

                // Set solid paint price label
                solidPaintLabel.Text = NONE.ToString("C");
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
                metalPaintLabel.Text = NONE.ToString("C");
                metalPaintLabel.ForeColor = Color.White;

                this.paintCost = METAL_PAINT_COST;
            }

            // add the paint cost to the total
            addToTotal();
        }

        private void roofButtons_CheckedChanged(object sender, EventArgs e)
        {
            

            if(solidRoofButton.Checked)
            {
                // Set roofcost to negative to subtract the cost from the total
                if (this.roofCost == GLASS_ROOFTOP_COST)
                {
                    this.roofCost = 0;
                }

                // Set solid paint price label
                solidRoofLabel.Text = NONE.ToString("C");
                solidRoofLabel.ForeColor = Color.White;

                // set metal paint price label
                glassRoofLabel.Text = (GLASS_ROOFTOP_COST).ToString("C");
                glassRoofLabel.ForeColor = Color.PaleGreen;
            }
            else
            { 
                // check if the price has been set already, if it has, exit the method and save processor cycles
                if (this.roofCost == GLASS_ROOFTOP_COST)
                {
                    return;
                }

                this.roofCost = GLASS_ROOFTOP_COST; // set roof cost to constant value of the roof cost set on clas creation

                // Set solid paint price label
                solidRoofLabel.Text = (0 - GLASS_ROOFTOP_COST).ToString("C");
                solidRoofLabel.ForeColor = Color.Red;

                // set metal paint price label
                glassRoofLabel.Text = NONE.ToString("C");
                glassRoofLabel.ForeColor = Color.White;
            }

            // Add the  roof cost to the total
            addToTotal();
        }

        /**
         * Returns the colour options based on the selected option
         */
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
            // Set window size
            /*tabMenu.Size    = new Size(420,415);
            this.Size       = new Size(420,450);*/

            // Set total box to base car cost
            totalBox.Text   = total.ToString("C");

            // Set costs from constants
            solidPaintLabel.Text    = NONE.ToString("C");

            metalPaintLabel.Text    = METAL_PAINT_COST.ToString("C");
            glassRoofLabel.Text     = GLASS_ROOFTOP_COST.ToString("C");

            Standard19Label.Text    = NONE.ToString("C");
            cyclone19Label.Text     = WHEEL_19_CYCLONE_COST.ToString("C");
            cyclone21Label.Text     = WHEEL_21_CYCLONE_COST.ToString("C");


        }

        /**
         * Adds the cost of an item to the total
         */
        private void addToTotal()
        {
            // Add cost to total
            this.total = this.wheelCost + this.roofCost + this.paintCost + BASE_CAR_COST;

            // assign total to total text box
            totalBox.Text = total.ToString("C");
        }

        private void WheelButton_CheckedChanged(object sender, EventArgs e)
        {

            if(Standard19Button.Checked)
            {
                if (this.wheelCost == 0)
                {
                    return;
                }

                // Set standard wheel price label colour and price
                Standard19Label.Text = NONE.ToString("C");
                Standard19Label.ForeColor = Color.White;

                cyclone19Label.Text = WHEEL_19_CYCLONE_COST.ToString("C");
                cyclone19Label.ForeColor = Color.PaleGreen;
            }
            else if (cyclone19Button.Checked)
            {
                this.wheelCost = WHEEL_19_CYCLONE_COST;
            }
            else
            {
                this.wheelCost = WHEEL_21_CYCLONE_COST;
            }

            addToTotal();
        }

    }
}
