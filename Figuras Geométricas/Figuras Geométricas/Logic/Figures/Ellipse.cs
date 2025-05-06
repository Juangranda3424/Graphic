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
    public partial class Ellipse : Form
    {
        public Ellipse()
        {
            InitializeComponent();
        }

        private Logic.Classes.Ellipse ellipse = new Logic.Classes.Ellipse();

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            ellipse.validationData(txtMinor, txtMajor, txtPerimeter, txtArea, picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ellipse.initializeEllipse(txtMinor, txtMajor, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Ellipse_Load_1(object sender, EventArgs e)
        {
            ellipse.initializeEllipse(txtMinor, txtMajor, txtPerimeter, txtArea, picCanvas);
        }

    }
}
