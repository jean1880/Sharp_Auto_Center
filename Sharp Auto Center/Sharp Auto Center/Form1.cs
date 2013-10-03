using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sharp_Auto_Center
{
    public partial class teslaSForm : Form
    {
        public teslaSForm()
        {
            InitializeComponent();
        }
        
        private void PaintButtons_CheckedChanged(object sender, EventArgs e)
        {
            if (solidPaintButton.Checked)
            {
                colourOptionBox.Visible = true;
                colourOptionBox.DataSource = colours(0);
            }
            else
            {
                colourOptionBox.Visible = true;
                colourOptionBox.DataSource = colours(1);
            }
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

        private void roofButtons_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void teslaSForm_Load(object sender, EventArgs e)
        {
            tabMenu.Size    = new Size(320,450);
            this.Size       = new Size(320, 450);
        }
           
    }
}
