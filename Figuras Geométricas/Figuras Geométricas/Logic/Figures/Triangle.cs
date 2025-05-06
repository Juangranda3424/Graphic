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
    public partial class Triangle : Form
    {
        public Triangle()
        {
            InitializeComponent();
        }

        private Logic.Classes.Triangle triangle = new Logic.Classes.Triangle();

        private void Triangle_Load(object sender, EventArgs e)
        {
            triangle.initializeTriangle(txtBase, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            triangle.validationData(txtHeight, txtBase, txtPerimeter, txtArea, picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            triangle.initializeTriangle(txtBase, txtHeight, txtPerimeter, txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
