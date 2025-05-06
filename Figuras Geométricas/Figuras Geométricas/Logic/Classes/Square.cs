using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Geométricas.Logic.Classes
{
    internal class Square: Figure
    {
        private float sSide;

        public Square()
        {
            sSide = 0;
        }

        public void validationData(TextBox txtSide, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            try
            {
                sSide = float.Parse(txtSide.Text);

                if(sSide > 0)
                {
                    calculatePerimeter(sSide);
                    calculateArea(sSide);
                    printData(txtPerimeter, txtArea);
                    shapeSquare(picCanvas);
                }
                else
                {
                    txtSide.Text = "";
                    txtSide.Focus();
                    MessageBox.Show("Error en la entrada de datos...", "Error");
                }

            }
            catch
            {
                MessageBox.Show("Error en la entrada de datos...", "Error");
                initializeSquare(txtSide, txtPerimeter, txtArea, picCanvas);
            }
        }

        public void initializeSquare(TextBox txtSide, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            sSide = 0.0f;
            txtSide.Text = "";
            txtArea.Text = "";
            txtPerimeter.Text = "";
            txtSide.Focus();
            picCanvas.Refresh();

        }

        public override void calculatePerimeter(float nSide)
        {
            Perimeter = 4 * nSide;
        }

        public override void calculateArea(float nSide)
        {
            Area = (float)Math.Pow(nSide, 2);
        }

        public void shapeSquare(PictureBox picCanvas)
        {
            Graphics = picCanvas.CreateGraphics();
            Graphics.DrawRectangle(Pen, picCanvas.Width / 4, picCanvas.Height / 4, sSide+100,sSide+100 );

        }



    }
}
