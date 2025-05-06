using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Geométricas.Logic.Classes
{
    internal class Diamond: Figure
    {

        protected float rSide;
        protected float rMinor;
        protected float rMajor;


        public Diamond()
        {
            rSide = 0.0f;
            rMinor = 0.0f;
            rMajor = 0.0f;
        }

        public void validationData(TextBox txtSide, TextBox txtMinor, TextBox txtMajor, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            try
            {
                rSide = float.Parse(txtSide.Text);
                rMinor = float.Parse(txtMinor.Text);
                rMajor = float.Parse(txtMajor.Text);

                if (rMinor >= rMajor || validateSide(rMinor,rMajor) == false )
                {
                    txtSide.Text = "";
                    txtMinor.Text = "";
                    txtMajor.Text = "";
                    txtPerimeter.Text = "";
                    txtArea.Text = "";
                    picCanvas.Refresh();
                    txtMajor.Focus();
                    MessageBox.Show("Error la diagonal menor es mayor o el lado no coincide con los valores ingresados", "Error");
                }
                else
                {
                    if (rMinor > 0 && rMajor > 0 && rSide > 0)
                    {
                        calculatePerimeter(rSide);
                        calculateArea(rMinor, rMajor);
                        printData(txtPerimeter, txtArea);
                        shapeDiamond(picCanvas);
                    }
                    else
                    {
                        txtSide.Text = "";
                        txtMinor.Text = "";
                        txtMajor.Text = "";
                        txtMajor.Focus();
                        MessageBox.Show("Error en la entrada de datos...", "Error");
                    }

                }

     
            }
            catch
            {
                MessageBox.Show("Error en la entrada de datos...", "Error");
                initializeDiamond(txtSide, txtMinor, txtMajor, txtPerimeter, txtArea, picCanvas);
            }
        }

        public override void calculatePerimeter(float rSide)
        {
            Perimeter = 4 * rSide;   
        }

        public override void calculateArea(float rMinor, float rMajor)
        {
            Area = (rMajor * rMinor) / 2;
        }

        public bool validateSide(float rMinor, float rMajor)
        {
            float rSideAux = (float)Math.Sqrt((float)Math.Pow(rMajor / 2, 2) + (float)Math.Pow(rMinor / 2, 2));
            if (rSide >= rSideAux-0.2 && rSide <= rSideAux+0.2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void initializeDiamond(TextBox txtSide, TextBox txtMinor, TextBox txtMajor, TextBox txtPerimeter, TextBox txtArea,PictureBox picCanvas)
        {
            rSide = 0.0f;
            rMinor = 0.0f;
            rMajor = 0.0f;
            txtSide.Text = "";
            txtMinor.Text = "";
            txtMajor.Text = "";
            txtArea.Text = "";
            txtPerimeter.Text = "";
            txtMajor.Focus();
            picCanvas.Refresh();
        }
             

        public void shapeDiamond(PictureBox picCanvas)
        {
            Graphics = picCanvas.CreateGraphics();

            PointF[] point =
            {
                new PointF(picCanvas.Width/2f,picCanvas.Height/4f-rMajor),
                new PointF(picCanvas.Width/4f+rMinor, picCanvas.Height/2f),
                new PointF(picCanvas.Width/2f, picCanvas.Height - picCanvas.Height/4f + rMajor),
                new PointF(picCanvas.Width - picCanvas.Width/4f - rMinor,picCanvas.Height/2f)
            };

            Graphics.DrawPolygon(Pen, point);
        }

    }
}
