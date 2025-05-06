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
    internal class Rectangle: Figure
    {
        protected float rHeight;
        protected float rBase;


        public Rectangle()
        {
            rBase = 0.0f;
            rHeight = 0.0f;

        }
        public override void calculateArea(float nBase, float nHeight)
        {
            Area = nBase * nHeight;
        }

        public void validationData(TextBox txtHeight, TextBox txtBase, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            try
            {
                rBase = float.Parse(txtBase.Text);
                rHeight = float.Parse(txtHeight.Text);

                if (rBase > 0 && rHeight > 0)
                {
                    calculatePerimeter(rBase, rHeight);
                    calculateArea(rBase, rHeight);
                    printData(txtPerimeter, txtArea);
                    shapeRectangle(picCanvas);
                }
                else
                {
                    txtBase.Text = "";
                    txtHeight.Text = "";
                    txtBase.Focus();
                    MessageBox.Show("Error en la entrada de datos...", "Error");
                }
            }
            catch
            {
                MessageBox.Show("Error en la entrada de datos...", "Error");
                initializeRectangle(txtBase, txtHeight, txtPerimeter, txtArea, picCanvas);
            }
        }

        public override void calculatePerimeter(float nBase, float nHeight)
        {
            Perimeter = 2 * (nBase + nHeight);
        }

        public void initializeRectangle(TextBox txtBase, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            rBase = 0;
            rHeight = 0;
            Area = 0;
            Perimeter = 0;
            txtBase.Text = "";
            txtArea.Text = "";
            txtHeight.Text = "";
            txtPerimeter.Text = "";
            txtBase.Focus();
            picCanvas.Refresh();

        }

        public virtual void shapeRectangle(PictureBox picCanvas)
        {
            Graphics = picCanvas.CreateGraphics();

            Graphics.DrawRectangle(Pen, picCanvas.Width / 4, picCanvas.Height / 4, rBase + 100, rHeight + 50);
            
        }
    }
}
