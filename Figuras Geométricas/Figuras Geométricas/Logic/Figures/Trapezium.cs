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
    public partial class Trapezium : Form
    {
        public Trapezium()
        {
            InitializeComponent();
        }

        private Logic.Classes.Trapezium trapezium = new Logic.Classes.Trapezium();

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            trapezium.validationData(txtDiagonal, txtTop, txtBottom, txtSide1, txtSide2, txtSide3, txtSide4, txtPerimeter, txtArea, picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            trapezium.initializeTrapeze(txtDiagonal, txtTop, txtBottom, txtSide1, txtSide2, txtSide3, txtSide4, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
