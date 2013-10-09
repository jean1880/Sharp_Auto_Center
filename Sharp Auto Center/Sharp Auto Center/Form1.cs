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
        private static decimal UPGRADE_BATTERY_COST     = 10700m;
        private static decimal PERFORMANCE_BATTERY_COST = 21700m;
        private static decimal HIGH_POWER_CHARGER       = 2900m;
        private static decimal TECH_PACKAGE             = 3900m;
        private static decimal SMART_SUSPENSION         = 2500m;
        private static decimal FOG_LAMPS                = 550m;
        private static decimal BASE_CAR_COST            = 78970m;
        private static decimal NONE                     = 0m;

        // set adding variables
        private decimal total       = BASE_CAR_COST;
        private decimal roofCost    = 0;
        private decimal paintCost   = 0;
        private decimal wheelCost   = 0;
        private decimal batteryCost = 0;
        private decimal optionCost  = 0;

        public teslaSForm()
        {
            InitializeComponent();
        }
        
        private void PaintButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (solidPaintButton.Checked && this.paintCost > NONE-METAL_PAINT_COST)
            {
                // set colour options
                colourOptionBox.Visible     = true;
                colourOptionBox.DataSource  = colours(0);

                // check if the price has been set already, if it has, exit the method and save processor cycles
                if (this.paintCost == 0)
                {
                    return;
                }

                this.paintCost = 0;                

                // Set solid paint price label
                solidPaintLabel.Text        = NONE.ToString("C");
                solidPaintLabel.ForeColor   = Color.White;

                // set metal paint price label
                metalPaintLabel.Text        = METAL_PAINT_COST.ToString("C");
                metalPaintLabel.ForeColor   = Color.PaleGreen;
            }
            else
            {
                // Set colour choices
                colourOptionBox.Visible     = true;
                colourOptionBox.DataSource  = colours(1);

                // check if the price has been set already, if it has, exit the method and save processor cycles
                if (this.paintCost == METAL_PAINT_COST)
                {
                    return;
                }

                // Set solid paint price label
                solidPaintLabel.Text        = (0-METAL_PAINT_COST).ToString("C");
                solidPaintLabel.ForeColor   = Color.Red;

                // set metal paint price label
                metalPaintLabel.Text        = NONE.ToString("C");
                metalPaintLabel.ForeColor   = Color.White;

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
                solidRoofLabel.Text         = NONE.ToString("C");
                solidRoofLabel.ForeColor    = Color.White;

                // set metal paint price label
                glassRoofLabel.Text         = (GLASS_ROOFTOP_COST).ToString("C");
                glassRoofLabel.ForeColor    = Color.PaleGreen;
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
                solidRoofLabel.Text         = (0 - GLASS_ROOFTOP_COST).ToString("C");
                solidRoofLabel.ForeColor    = Color.Red;

                // set metal paint price label
                glassRoofLabel.Text         = NONE.ToString("C");
                glassRoofLabel.ForeColor    = Color.White;
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
            //tabMenu.Size    = new Size(420,415);
            //this.Size       = new Size(420,450);

            // Set total box to base car cost
            totalBox.Text   = total.ToString("C");

            // Set costs from constants
            solidPaintLabel.Text            = NONE.ToString("C");

            metalPaintLabel.Text            = METAL_PAINT_COST.ToString("C");
            glassRoofLabel.Text             = GLASS_ROOFTOP_COST.ToString("C");

            Standard19Label.Text            = NONE.ToString("C");
            cyclone19Label.Text             = WHEEL_19_CYCLONE_COST.ToString("C");
            cyclone21Label.Text             = WHEEL_21_CYCLONE_COST.ToString("C");

            baseBatteryLabel.Text           = NONE.ToString("C");
            upgradeBatteryLabel.Text        = UPGRADE_BATTERY_COST.ToString("C");
            performanceBatteryLabel.Text    = PERFORMANCE_BATTERY_COST.ToString("C");

            highPowerLabel.Text             = HIGH_POWER_CHARGER.ToString("C");
            techLabel.Text                  = TECH_PACKAGE.ToString("C");
            smartSuspensionLabel.Text       = SMART_SUSPENSION.ToString("C");
            fogLabel.Text                   = FOG_LAMPS.ToString("C");
        }

        /**
         * Adds the cost of an item to the total
         */
        private void addToTotal()
        {
            // Add cost to total
            this.total = this.wheelCost + this.roofCost + this.paintCost + this.batteryCost + this.optionCost + BASE_CAR_COST;

            // assign total to total text box
            totalBox.Text = total.ToString("C");
        }

        private void WheelButton_CheckedChanged(object sender, EventArgs e)
        {

            if(Standard19Button.Checked)
            {
                // check if the price has been set already, if it has, exit the method and save processor cycles
                if (this.wheelCost == 0)
                {
                    return;
                }

                // Set standard wheel label colour and price
                Standard19Label.Text        = NONE.ToString("C");
                Standard19Label.ForeColor   = Color.White;

                // set 19" wheel label colour and price 
                cyclone19Label.Text         = WHEEL_19_CYCLONE_COST.ToString("C");
                cyclone19Label.ForeColor    = Color.PaleGreen;

                // set 21" wheel label colour and price
                cyclone21Label.Text         = WHEEL_21_CYCLONE_COST.ToString("C");
                cyclone21Label.ForeColor    = Color.PaleGreen;

                this.wheelCost = 0;
            }
            else if (cyclone19Button.Checked)
            {
                // check if the price has been set already, if it has, exit the method and save processor cycles
                if (this.wheelCost == WHEEL_19_CYCLONE_COST)
                {
                    return;
                }

                // Set standard wheel label colour and price
                Standard19Label.Text        = (NONE - WHEEL_19_CYCLONE_COST).ToString("C");
                Standard19Label.ForeColor   = Color.Red;

                // set 19" wheel label colour and price 
                cyclone19Label.Text         = NONE.ToString("C");
                cyclone19Label.ForeColor    = Color.White;

                // set 21" wheel label colour and price
                cyclone21Label.Text         = (WHEEL_21_CYCLONE_COST - WHEEL_19_CYCLONE_COST).ToString("C");
                cyclone21Label.ForeColor    = Color.PaleGreen;

                this.wheelCost = WHEEL_19_CYCLONE_COST;

            }
            else
            {
                // check if the price has been set already, if it has, exit the method and save processor cycles
                if(this.wheelCost == WHEEL_21_CYCLONE_COST)
                {
                    return;
                }

                // Set standard wheel label colour and price
                Standard19Label.Text        = (NONE - WHEEL_21_CYCLONE_COST).ToString("C");
                Standard19Label.ForeColor   = Color.Red;

                // set 19" wheel label colour and price 
                cyclone19Label.Text         = (WHEEL_19_CYCLONE_COST-WHEEL_21_CYCLONE_COST).ToString("C");
                cyclone19Label.ForeColor    = Color.Red;

                // set 21" wheel label colour and price
                cyclone21Label.Text         = NONE.ToString("C");
                cyclone21Label.ForeColor    = Color.White;

                this.wheelCost = WHEEL_21_CYCLONE_COST;
            }

            addToTotal();
        }

        private void BatteryButton_CheckedChanged(object sender, EventArgs e)
        {
            if (baseBatteryButton.Checked)
            {
                // check if the price has been set already, if it has, exit the method and save processor cycles
                if (this.batteryCost == 0)
                {
                    return;
                }

                // Set base battery label price and font colour
                baseBatteryLabel.Text       = NONE.ToString("C");
                baseBatteryLabel.ForeColor  = Color.White;

                // Set upgraded battery label price and font colour
                upgradeBatteryLabel.Text        = UPGRADE_BATTERY_COST.ToString("C");
                upgradeBatteryLabel.ForeColor   = Color.PaleGreen;

                // Set performance battery label price and font colour
                performanceBatteryLabel.Text        = PERFORMANCE_BATTERY_COST.ToString("C");
                performanceBatteryLabel.ForeColor   = Color.PaleGreen;

                this.batteryCost = 0;
            }
            else if (upgradeBatteryButton.Checked)
            {
                // If base battery already selected, exit method to save processor cycles
                if (this.batteryCost == UPGRADE_BATTERY_COST)
                {
                    return;
                }

                // Set base battery label price and font colour
                baseBatteryLabel.Text       = (NONE - UPGRADE_BATTERY_COST).ToString("C");
                baseBatteryLabel.ForeColor  = Color.Red;

                // Set upgraded battery label price and font colour
                upgradeBatteryLabel.Text        = NONE.ToString("C");
                upgradeBatteryLabel.ForeColor   = Color.White;

                // Set performance battery label price and font colour
                performanceBatteryLabel.Text        = (PERFORMANCE_BATTERY_COST - UPGRADE_BATTERY_COST).ToString("C");
                performanceBatteryLabel.ForeColor   = Color.PaleGreen;

                this.batteryCost = UPGRADE_BATTERY_COST;
            }
            else
            {
                // check if the price has been set already, if it has, exit the method and save processor cycles
                if (this.batteryCost == PERFORMANCE_BATTERY_COST)
                {
                    return;
                }

                // Set base battery label price and font colour
                baseBatteryLabel.Text = (NONE - PERFORMANCE_BATTERY_COST).ToString("C");
                baseBatteryLabel.ForeColor = Color.Red;

                // Set upgraded battery label price and font colour
                upgradeBatteryLabel.Text = (UPGRADE_BATTERY_COST - PERFORMANCE_BATTERY_COST).ToString("C");
                upgradeBatteryLabel.ForeColor = Color.Red;

                // Set performance battery label price and font colour
                performanceBatteryLabel.Text = NONE.ToString("C");
                performanceBatteryLabel.ForeColor = Color.White;

                this.batteryCost = PERFORMANCE_BATTERY_COST;
            }

            addToTotal();
        }

        private void highPowerBox_CheckedChanged(object sender, EventArgs e)
        {
            // Check state of the button
            if (highPowerBox.Checked)
            {
                // set label price and colour
                highPowerLabel.Text = (NONE - HIGH_POWER_CHARGER).ToString("C");
                highPowerLabel.ForeColor = Color.Red;

                // add cost to options
                this.optionCost += HIGH_POWER_CHARGER;
            }
            else
            {
                // set label price and colour
                highPowerLabel.Text = HIGH_POWER_CHARGER.ToString("C");
                highPowerLabel.ForeColor = Color.PaleGreen;

                // add cost to options
                this.optionCost -= HIGH_POWER_CHARGER;
            }

            addToTotal();
        }

        private void techBox_CheckedChanged(object sender, EventArgs e)
        {
            // Check state of the button
            if (techBox.Checked)
            {
                // set label price and colour
                techLabel.Text = (NONE - TECH_PACKAGE).ToString("C");
                techLabel.ForeColor = Color.Red;

                // add cost to options
                this.optionCost += TECH_PACKAGE;
            }
            else
            {
                // set label price and colour
                techLabel.Text = TECH_PACKAGE.ToString("C");
                techLabel.ForeColor = Color.PaleGreen;

                // add cost to options
                this.optionCost -= TECH_PACKAGE;
            }

            addToTotal();
        }

        private void smartSuspensionBox_CheckedChanged(object sender, EventArgs e)
        {
            // Check state of the button
            if (smartSuspensionBox.Checked)
            {
                // set label price and colour
                smartSuspensionLabel.Text = (NONE - SMART_SUSPENSION).ToString("C");
                smartSuspensionLabel.ForeColor = Color.Red;

                // add cost to options
                this.optionCost += TECH_PACKAGE;
            }
            else
            {
                // set label price and colour
                smartSuspensionLabel.Text = SMART_SUSPENSION.ToString("C");
                smartSuspensionLabel.ForeColor = Color.PaleGreen;

                // add cost to options
                this.optionCost -= SMART_SUSPENSION;
            }

            addToTotal();
        }

        private void fogBox_CheckedChanged(object sender, EventArgs e)
        {
            // Check state of the button
            if (fogBox.Checked)
            {
                // set label price and colour
                fogLabel.Text = (NONE - FOG_LAMPS).ToString("C");
                fogLabel.ForeColor = Color.Red;

                // add cost to options
                this.optionCost += FOG_LAMPS;
            }
            else
            {
                // set label price and colour
                fogLabel.Text = FOG_LAMPS.ToString("C");
                fogLabel.ForeColor = Color.PaleGreen;

                // add cost to options
                this.optionCost -= FOG_LAMPS;
            }

            addToTotal();
        }

        private void maximizeButton_Click(object sender, EventArgs e)
        {
            // Set all options to maximum
            metallicPaintButton.PerformClick();
            glassRoofButton.PerformClick();
            cyclone21Button.PerformClick();
            performanceBatteryButton.PerformClick();
            leatherSeatButton.PerformClick();

            // turn checkboxes on to call function
            highPowerBox.Checked        = true;
            techBox.Checked             = true;
            smartSuspensionBox.Checked  = true;
            fogBox.Checked              = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Set all options to maximum
            solidPaintButton.PerformClick();
            solidRoofButton.PerformClick();
            Standard19Button.PerformClick();
            baseBatteryButton.PerformClick();
            fabricSeatButton.PerformClick();

            // turn checkboxes on to call function
            highPowerBox.Checked = false;
            techBox.Checked = false;
            smartSuspensionBox.Checked = false;
            fogBox.Checked = false;
        }
        
        private void franklinGothic12ptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            changeFont("Franklin Gothic","12pt");
        }

        private void changeFont(string fontFamilyName, string fontSize)
        {
        }
    }
}
