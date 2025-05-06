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
    public partial class Trapeze : Form
    {
        public Trapeze()
        {
            InitializeComponent();
        }

        private Logic.Classes.Trapeze trapeze = new Logic.Classes.Trapeze();

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            trapeze.validationData(txtMinor, txtMajor, txtSide1, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            trapeze.initializeTrapeze(txtMinor, txtMajor, txtSide1, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Trapeze_Load(object sender, EventArgs e)
        {
            trapeze.initializeTrapeze(txtMinor, txtMajor, txtSide1, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

    }
}
