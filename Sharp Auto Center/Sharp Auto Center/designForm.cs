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
 * This form allows the user to customise their Tesla Model S car, while outputing the running subtotal.
 * When the user is finished they may click the buy button which will call the purchasing form. For the 
 * purpose of this assignment, purchase form only displays the calculated totals, showing the subtotal
 * amount of tax charged to the purchase, as well as the final post tax total
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

        // Set colours to be used for the themes
        private static Color DARK_BACKGROUND            = Color.FromArgb(64, 64, 64);
        private static Color DARK_TEXT                  = Color.White;
        private static Color LIGHT_BACKGROUND           = Color.FromArgb(220, 220, 220);
        private static Color LIGHT_TEXT                 = Color.Black;

        // set adding variables
        private decimal total       = BASE_CAR_COST;
        private decimal roofCost    = 0m;
        private decimal paintCost   = 0m;
        private decimal wheelCost   = 0m;
        private decimal batteryCost = 0m;
        private decimal optionsCost = 0m;
        private decimal highPwrPck  = 0m;
        private decimal smartSpns   = 0m;
        private decimal techPkg     = 0m;
        private decimal fogLmps     = 0m;
        private string formTheme    = "darkUI";


        public teslaSForm()
        {
            InitializeComponent();
        }
        
        /**
         * Check which paint option has been selected and update costs shown to the user
         */
        private void PaintButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (solidPaintButton.Checked && this.paintCost > NONE-METAL_PAINT_COST)
            {
                // set colour options
                colourOptionBox.DataSource  = colours(0);

                // check if the price has been set already, if it has, exit the method and save processor cycles
                if (this.paintCost == 0)
                {
                    return;
                }

                this.paintCost = 0;                

                // Set solid paint price label
                solidPaintLabel.Text        = NONE.ToString("C");
                solidPaintLabel.ForeColor = formTheme == "darkUI" ? DARK_TEXT : LIGHT_TEXT;

                // set metal paint price label
                metalPaintLabel.Text        = METAL_PAINT_COST.ToString("C");
                metalPaintLabel.ForeColor   = Color.PaleGreen;
            }
            else
            {
                // Set colour choices
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
                metalPaintLabel.ForeColor = formTheme == "darkUI" ? DARK_TEXT : LIGHT_TEXT;

                this.paintCost = METAL_PAINT_COST;
            }

            // add the paint cost to the total
            calculateTotal();
        }

        /**
         * Checks which roof option has been selected and updates the costs shown to the user
         */
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
                solidRoofLabel.ForeColor = formTheme == "darkUI" ? DARK_TEXT : LIGHT_TEXT;

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
                glassRoofLabel.ForeColor    = formTheme == "darkUI" ? DARK_TEXT : LIGHT_TEXT;
            }

            // Add the  roof cost to the total
            calculateTotal();
        }

        /**
         * Returns the colour options based on the selected option, 
         * 0 is solid colours, 1 is  metallic colours
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

        
        /**
         * Sets form settings and initialises various settings for the form
         */
        private void teslaSForm_Load(object sender, EventArgs e)
        {
            // Set window size
            tabMenu.Size    = new Size(420,415);
            this.Size       = new Size(420,450);

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

            // Set colour options to initial option
            colourOptionBox.DataSource = colours(0);

            // Set settings labels
            checkThemeLabel();
            checkFontLabel();

            // Set colours of form based on starting theme
            if(formTheme == "darkUI")
            {
                darkUIToolStripMenuItem_Click(sender,e);
            }
            else
            {
                lightUIToolStripMenuItem_Click(sender,e);
            }
            changeColors(DARK_BACKGROUND, DARK_TEXT);  
        }

        private void calculateOptions()
        {
            this.optionsCost = this.smartSpns + this.highPwrPck + this.fogLmps + this.techPkg;
        }

        /**
         * Adds the cost of an item to the total
         */
        private void calculateTotal()
        {
            // Add cost to total
            this.total = this.wheelCost + this.roofCost + this.paintCost + this.batteryCost + this.optionsCost + BASE_CAR_COST;

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
                Standard19Label.ForeColor = formTheme == "darkUI" ? DARK_TEXT : LIGHT_TEXT;

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
                cyclone19Label.ForeColor    = formTheme == "darkUI" ? DARK_TEXT : LIGHT_TEXT;

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
                cyclone21Label.ForeColor    = formTheme == "darkUI" ? DARK_TEXT : LIGHT_TEXT;

                this.wheelCost = WHEEL_21_CYCLONE_COST;
            }

            calculateTotal();
        }

        /**
         * On click event of any of the battery options, check which battery the user has selected and
         * update the costs
         */
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
                baseBatteryLabel.ForeColor  = formTheme == "darkUI" ? DARK_TEXT : LIGHT_TEXT;

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
                upgradeBatteryLabel.ForeColor   = formTheme == "darkUI" ? DARK_TEXT : LIGHT_TEXT;

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
                baseBatteryLabel.Text       = (NONE - PERFORMANCE_BATTERY_COST).ToString("C");
                baseBatteryLabel.ForeColor  = Color.Red;

                // Set upgraded battery label price and font colour
                upgradeBatteryLabel.Text        = (UPGRADE_BATTERY_COST - PERFORMANCE_BATTERY_COST).ToString("C");
                upgradeBatteryLabel.ForeColor   = Color.Red;

                // Set performance battery label price and font colour
                performanceBatteryLabel.Text        = NONE.ToString("C");
                performanceBatteryLabel.ForeColor   = formTheme == "darkUI" ? DARK_TEXT : LIGHT_TEXT;

                this.batteryCost = PERFORMANCE_BATTERY_COST;
            }

            calculateTotal();
        }

        /**
         * Check if the high power option has been selected, update costs for the user
         */
        private void highPowerBox_CheckedChanged(object sender, EventArgs e)
        {
            // Check state of the button
            if (highPowerBox.Checked)
            {
                // set label price and colour
                highPowerLabel.Text         = (NONE - HIGH_POWER_CHARGER).ToString("C");
                highPowerLabel.ForeColor    = Color.Red;

                // add cost to options
                this.highPwrPck = HIGH_POWER_CHARGER;
            }
            else
            {
                // set label price and colour
                highPowerLabel.Text         = HIGH_POWER_CHARGER.ToString("C");
                highPowerLabel.ForeColor    = Color.PaleGreen;

                // add cost to options
                this.highPwrPck = NONE;
            }

            // Calculate the costs
            calculateOptions();
            calculateTotal();
        }

        /**
         * Check if the tech upgrade option has been selected, update costs for the user
         */
        private void techBox_CheckedChanged(object sender, EventArgs e)
        {
            // Check state of the button
            if (techBox.Checked)
            {
                // set label price and colour
                techLabel.Text      = (NONE - TECH_PACKAGE).ToString("C");
                techLabel.ForeColor = Color.Red;

                // add cost to options
                this.techPkg = TECH_PACKAGE;
            }
            else
            {
                // set label price and colour
                techLabel.Text      = TECH_PACKAGE.ToString("C");
                techLabel.ForeColor = Color.PaleGreen;

                // add cost to options
                this.techPkg = NONE;
            }

            // Calculate the costs
            calculateOptions();
            calculateTotal();
        }

        /**
         * Check if the smart suspension option has been selected, update costs for the user
         */
        private void smartSuspensionBox_CheckedChanged(object sender, EventArgs e)
        {
            // Check state of the button
            if (smartSuspensionBox.Checked)
            {
                // set label price and colour
                smartSuspensionLabel.Text       = (NONE - SMART_SUSPENSION).ToString("C");
                smartSuspensionLabel.ForeColor  = Color.Red;

                // add cost to options
                this.smartSpns = SMART_SUSPENSION;
            }
            else
            {
                // set label price and colour
                smartSuspensionLabel.Text       = SMART_SUSPENSION.ToString("C");
                smartSuspensionLabel.ForeColor  = Color.PaleGreen;

                // add cost to options
                this.smartSpns = NONE;
            }

            // calculate the costs
            calculateOptions();
            calculateTotal();
        }

        /**
         * Check if the fog light option has been selected, update costs for the user
         */
        private void fogBox_CheckedChanged(object sender, EventArgs e)
        {
            // Check state of the button
            if (fogBox.Checked)
            {
                // set label price and colour
                fogLabel.Text       = (NONE - FOG_LAMPS).ToString("C");
                fogLabel.ForeColor  = Color.Red;

                // add cost to options
                this.fogLmps = FOG_LAMPS;
            }
            else
            {
                // set label price and colour
                fogLabel.Text       = FOG_LAMPS.ToString("C");
                fogLabel.ForeColor  = Color.PaleGreen;

                // add cost to options
                this.fogLmps = NONE;
            }

            // calculate the costs
            calculateOptions();
            calculateTotal();
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

        /**
         * Reset all options to default, and update costs accordingly
         */
        private void resetButton_Click(object sender, EventArgs e)
        {
            // Set all options to maximum
            solidPaintButton.PerformClick();
            solidRoofButton.PerformClick();
            Standard19Button.PerformClick();
            baseBatteryButton.PerformClick();
            fabricSeatButton.PerformClick();

            // turn checkboxes on to call function
            highPowerBox.Checked        = false;
            techBox.Checked             = false;
            smartSuspensionBox.Checked  = false;
            fogBox.Checked              = false;
        }
        
        /**
         * Set fonts on the form to Franklin Gothic
         */
        private void franklinGothic12ptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // change the font
            changeFont(new Font("Forte",12));
            checkFontLabel();
        }

        /**
         * Set fonts on the form to Microsoft Sans Serif
         */
        private void microsoftSansSerif12ptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // change the font
            changeFont(new Font("Microsoft Sans Serif", 12));
            checkFontLabel();
        }

        /**
         * Set fonts on the form to Segoe UI Black
         */
        private void segoeUI12ptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // change the font
            changeFont(new Font("Segoe UI Black", 12));
            checkFontLabel();
        }

        /**
         * Changes the fonts of the form to the font passed into the function
         * @param fontaFamilyName Name of font to change interfaces to
         */
        private void changeFont(Font fontFamilyName)
        {
            solidPaintButton.Font           = fontFamilyName;
            solidPaintLabel.Font            = fontFamilyName;
            metallicPaintButton.Font        = fontFamilyName;
            metalPaintLabel.Font            = fontFamilyName;
            colourGroup.Font                = fontFamilyName;
            colourOptionBox.Font            = fontFamilyName;
            roofGroup.Font                  = fontFamilyName;
            solidRoofButton.Font            = fontFamilyName;
            solidRoofLabel.Font             = fontFamilyName;
            glassRoofButton.Font            = fontFamilyName;
            glassRoofLabel.Font             = fontFamilyName;
            wheelGroup.Font                 = fontFamilyName;
            Standard19Button.Font           = fontFamilyName;
            Standard19Label.Font            = fontFamilyName;
            cyclone19Button.Font            = fontFamilyName;
            cyclone21Label.Font             = fontFamilyName;
            cyclone21Button.Font            = fontFamilyName;
            baseBatteryButton.Font          = fontFamilyName;
            baseBatteryLabel.Font           = fontFamilyName;
            performanceBatteryButton.Font   = fontFamilyName;
            performanceBatteryLabel.Font    = fontFamilyName;
            upgradeBatteryButton.Font       = fontFamilyName;
            upgradeBatteryLabel.Font        = fontFamilyName;
            batteryGroup.Font               = fontFamilyName;
            interiorOptionBox.Font          = fontFamilyName;
            fabricSeatButton.Font           = fontFamilyName;
            fabricSeatLabel.Font            = fontFamilyName;
            leatherSeatButton.Font          = fontFamilyName;
            leatherSeatLabel.Font           = fontFamilyName;
            extraOptionsBox.Font            = fontFamilyName;
            highPowerBox.Font               = fontFamilyName;
            highPowerLabel.Font             = fontFamilyName;
            techBox.Font                    = fontFamilyName;
            techLabel.Font                  = fontFamilyName;
            smartSuspensionBox.Font         = fontFamilyName;
            smartSuspensionLabel.Font       = fontFamilyName;
            fogBox.Font                     = fontFamilyName;
            fogLabel.Font                   = fontFamilyName;
            resetButton.Font                = fontFamilyName;
            maximizeButton.Font             = fontFamilyName;
            buyButton.Font                  = fontFamilyName;
            themeBox.Font                   = fontFamilyName;
            themeLabel.Font                 = fontFamilyName;
            fontSelectionBox.Font           = fontFamilyName;
            fontSelectionLabel.Font         = fontFamilyName;
            titleLabel.Font                 = fontFamilyName;
        }

        /**
         * @param fontColor Color object to be set for text
         * @param x         dummy Object to be able to call the button functions
         * @param y         dummy EventArgs to be able to call the button functions
         */
        private void changeFontColor(Color fontColor, Object x, EventArgs y)
        {
            // Change button and group text colours
            solidPaintButton.ForeColor          = fontColor;
            metallicPaintButton.ForeColor       = fontColor;
            colourGroup.ForeColor               = fontColor;
            roofGroup.ForeColor                 = fontColor;
            solidRoofButton.ForeColor           = fontColor;
            glassRoofButton.ForeColor           = fontColor;
            wheelGroup.ForeColor                = fontColor;
            Standard19Button.ForeColor          = fontColor;
            cyclone19Button.ForeColor           = fontColor;
            cyclone21Button.ForeColor           = fontColor;
            baseBatteryButton.ForeColor         = fontColor;
            performanceBatteryButton.ForeColor  = fontColor;
            upgradeBatteryButton.ForeColor      = fontColor;
            batteryGroup.ForeColor              = fontColor;
            interiorOptionBox.ForeColor         = fontColor;
            fabricSeatButton.ForeColor          = fontColor;
            leatherSeatButton.ForeColor         = fontColor;
            extraOptionsBox.ForeColor           = fontColor;
            highPowerBox.ForeColor              = fontColor;
            techBox.ForeColor                   = fontColor;
            smartSuspensionBox.ForeColor        = fontColor;
            fogBox.ForeColor                    = fontColor;
            themeBox.ForeColor                  = fontColor;
            fontSelectionBox.ForeColor          = fontColor;

            // Run through label colours
            PaintButtons_CheckedChanged(x, y);
            roofButtons_CheckedChanged(x, y);
            WheelButton_CheckedChanged(x, y);
            BatteryButton_CheckedChanged(x, y);
            themeLabel.ForeColor            = fontColor;
            fontSelectionLabel.ForeColor    = fontColor;
            fabricSeatLabel.ForeColor       = fontColor;
            leatherSeatLabel.ForeColor      = fontColor;
            titleLabel.ForeColor            = fontColor;
        }

        /**
         * Sets forms theme to the dark theme
         */
        private void darkUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formTheme = "darkUI";
            checkThemeLabel();
            changeColors(DARK_BACKGROUND, DARK_TEXT);
            changeFontColor(DARK_TEXT, sender, e);
        }

        /**
         * Sets forms theme to the light theme
         */
        private void lightUIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.formTheme = "lightUI";
            checkThemeLabel();
            changeColors(LIGHT_BACKGROUND, LIGHT_TEXT);
            changeFontColor(LIGHT_TEXT, sender, e);
        }

        /**
         * Set the label text for the current theme in the settings tab, to the currently selected theme
         */
        private void checkThemeLabel()
        {
            themeLabel.Text = formTheme == "darkUI" ? "Dark UI Theme" : "Light UI Theme";
        }

        /**
         * Set the label text for the current font in the settings tab, to the currently selected font
         */
        private void checkFontLabel()
        {
            fontSelectionLabel.Text = fontSelectionLabel.Font.Name;
        }

        /**
         * change the form background colour to the specified colour
         */
        private void changeColors(Color formBackground, Color textColor)
        {
            designTab.BackColor     = formBackground;
            settingsTab.BackColor   = formBackground;
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            purchaseForm endForm = new purchaseForm(total);
            endForm.Show();
            this.Hide();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To use this form, please select your car options in the design tab. After completing your selection continue with your purchase by clicking on the buy button located at the bottom of the screen. Alternatively you can quickly max out your Tesla S buy clicking on the 'Maximise' button on the bottom of the screen, you can also reset the car options as well by pressing the 'Reset' Button","Help");
        }
    }
}
