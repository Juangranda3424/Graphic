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
    public partial class Semicircle : Form
    {
        public Semicircle()
        {
            InitializeComponent();
        }

        private Logic.Classes.SemiCircle semiCircle = new Logic.Classes.SemiCircle();

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            semiCircle.validationData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            semiCircle.initializeCircle(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
