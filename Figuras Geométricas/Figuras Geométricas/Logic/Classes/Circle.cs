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
    internal class Circle: Figure
    {
        protected float cRadius;

        public Circle()
        {
            cRadius = 0.0f;
        }

        public void validationData(TextBox txtRadius, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            try
            {
                cRadius = float.Parse(txtRadius.Text);
                if (cRadius > 0)
                {
                    calculatePerimeter(cRadius);
                    calculateArea(cRadius);
                    printData(txtPerimeter, txtArea);
                    shapeCircle(picCanvas);
                }
                else
                {
                    txtRadius.Text = "";
                    txtRadius.Focus();
                    MessageBox.Show("Error en la entrada de datos...", "Error");
                }



            }
            catch
            {
                MessageBox.Show("Error en la entrada de datos...", "Error");
                initializeCircle(txtRadius,txtPerimeter,txtArea,picCanvas);
            }
        }

        public override void calculatePerimeter(float cRadius)
        {
            Perimeter = 2 * (float)Math.PI * cRadius;
        }

        public override void calculateArea(float cRadius)
        {
            Area = (float)Math.PI * (float)(Math.Pow(cRadius, 2));
        }

        public void initializeCircle(TextBox txtRadius, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            cRadius = 0.0f;
            txtRadius.Text = "";
            txtArea.Text = "";
            txtPerimeter.Text = "";
            txtRadius.Focus();
            picCanvas.Refresh();

        }

        public virtual void shapeCircle(PictureBox picCanvas)
        {
            Graphics = picCanvas.CreateGraphics();
            Graphics.DrawEllipse(Pen,picCanvas.Width/4,picCanvas.Height/4,cRadius,cRadius);

        }


    }
}
