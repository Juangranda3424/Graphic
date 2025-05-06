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
    public partial class Rectangle : Form
    {
        public Rectangle()
        {
            InitializeComponent();
        }

        private Logic.Classes.Rectangle rectangle = new Logic.Classes.Rectangle();

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            rectangle.validationData(txtHeight, txtBase, txtPerimeter, txtArea, picCanvas);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rectangle.validationData(txtBase,txtHeight,txtPerimeter,txtArea, picCanvas);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        private void Rectangle_Load(object sender, EventArgs e)
        {
            rectangle.initializeRectangle(txtBase, txtHeight, txtPerimeter, txtArea, picCanvas);
        }
    }
}
