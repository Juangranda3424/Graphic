using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Geométricas.Logic.Figures
{
    public partial class Diamond : Form
    {
        public Diamond()
        {
            InitializeComponent();
        }

        private Logic.Classes.Diamond diamond = new Logic.Classes.Diamond();

        private void Diamond_Load(object sender, EventArgs e)
        {
            diamond.initializeDiamond(txtSide, txtMinor, txtMajor, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            diamond.validationData(txtSide, txtMinor, txtMajor, txtPerimeter, txtArea, picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            diamond.initializeDiamond(txtSide, txtMinor, txtMajor, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
