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
    public partial class Star : Form
    {
        public Star()
        {
            InitializeComponent();
        }

        private Logic.Classes.Star star = new Logic.Classes.Star();

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            star.validationData(txtInRadius, txtOuRadius, txtSide, txtArea, txtPerimeter, picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            star.initializeStar(txtInRadius, txtOuRadius, txtSide, txtArea, txtPerimeter, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
