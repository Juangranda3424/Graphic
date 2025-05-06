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
    public partial class Rhomboid : Form
    {
        public Rhomboid()
        {
            InitializeComponent();
        }

        private Logic.Classes.Rhomboid rhomboid = new Logic.Classes.Rhomboid();

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            rhomboid.validationData(txtHeight, txtBase, txtPerimeter, txtArea, picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rhomboid.initializeRectangle(txtBase, txtHeight, txtPerimeter, txtArea, picCanvas);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
