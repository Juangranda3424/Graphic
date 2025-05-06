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
    public partial class Circle : Form
    {
        public Circle()
        {
            InitializeComponent();
        }

        private Logic.Classes.Circle circle = new Logic.Classes.Circle();

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            circle.validationData(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            circle.initializeCircle(txtRadius, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Circle_Load(object sender, EventArgs e)
        {
            circle.initializeCircle(txtRadius,txtPerimeter,txtArea,picCanvas);
        }
    }
}
