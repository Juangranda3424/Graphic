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
    public partial class Deltoid : Form
    {
        public Deltoid()
        {
            InitializeComponent();
        }

        private Logic.Classes.Deltoid deltoid = new Logic.Classes.Deltoid();

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            deltoid.validationData(txtSide1, txtSide2, txtMajor, txtMinor, txtPerimeter, txtArea, picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            deltoid.initializeDeltoid(txtSide1, txtSide2, txtMajor, txtMinor, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
