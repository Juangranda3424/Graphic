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
    public partial class Square : Form
    {
        public Square()
        {
            InitializeComponent();
        }

        private Logic.Classes.Square square = new Logic.Classes.Square();

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            square.validationData(txtSide, txtPerimeter, txtArea, picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            square.initializeSquare(txtSide,txtPerimeter,txtArea,picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Square_Load(object sender, EventArgs e)
        {
            square.initializeSquare(txtSide, txtPerimeter, txtArea, picCanvas);
        }

    }
}
