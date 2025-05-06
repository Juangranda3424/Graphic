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
    internal class Star: Figure
    {
        private float sInRadius;
        private float sOuRadius;
        private float sSide;


        public Star()
        {
            sInRadius = 0.0f;
            sOuRadius = 0.0f;
            sSide = 0.0f;
        }

        public void validationData(TextBox txtInRadius, TextBox txtOuRadius, TextBox txtSide, TextBox txtArea, TextBox txtPerimeter, PictureBox picCanvas)
        {
            try
            {
                sInRadius = float.Parse(txtInRadius.Text);
                sOuRadius = float.Parse(txtOuRadius.Text);
                sSide = float.Parse(txtSide.Text);

                if (sInRadius>sOuRadius || verificateSide(sOuRadius)==false)
                {
                    txtInRadius.Text = "";
                    txtOuRadius.Text = "";
                    txtSide.Text = "";
                    txtPerimeter.Text = "";
                    txtArea.Text = "";
                    picCanvas.Refresh();
                    txtInRadius.Focus();
                    MessageBox.Show("Error radio menor es mayor o la media del lado esta mal", "Error");

                }
                else
                {
                    if (sInRadius > 0 && sOuRadius > 0 && sSide > 0)
                    {
                        calculatePerimeter(sSide);
                        calculateArea(sInRadius, sOuRadius);
                        printData(txtPerimeter, txtArea);
                        shapeStar(picCanvas);
                    }
                    else
                    {
                        txtInRadius.Text = "";
                        txtOuRadius.Text = "";
                        txtSide.Text = "";
                        txtInRadius.Focus();
                        MessageBox.Show("Error en la entrada de datos...", "Error");
                    }
                }


            }
            catch
            {
                MessageBox.Show("Error en la entrada de datos...", "Error");
                initializeStar(txtInRadius,txtOuRadius, txtSide, txtArea, txtPerimeter, picCanvas);
            }
        }

        public override void calculatePerimeter(float sSide)
        {
            Perimeter = sSide * 10;

        }

        public override void calculateArea(float sInRadius, float sOuRadius)
        {
            Area = (5f / 4f) * ((float)Math.Pow(sOuRadius, 2)) * (float)(1f / (float)Math.Tan((float)Math.PI / 5f)) - (float)((float)(5f / 2f) * (float)Math.Pow(sInRadius, 2) * (float)Math.Tan((float)Math.PI / 5f));
        }

        public void initializeStar(TextBox txtInRadius, TextBox txtOuRadius, TextBox txtSide, TextBox txtArea, TextBox txtPerimeter, PictureBox picCanvas)
        {

            Area = 0;
            Perimeter = 0;
            sInRadius = 0.0f;
            sOuRadius = 0.0f;
            sSide = 0.0f;
            txtInRadius.Text = "";
            txtOuRadius.Text = "";
            txtSide.Text = "";
            txtArea.Text = "";
            txtPerimeter.Text = "";
            txtInRadius.Focus();
            picCanvas.Refresh();

        }

        public bool verificateSide(float OuRadius)
        {
            float sSideAux = 2 * OuRadius * (float)Math.Sin((float)Math.PI / 5);
            if (sSide >= sSideAux-0.2 && sSide <= sSideAux+0.2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual void shapeStar(PictureBox picCanvas)
        {
            Graphics = picCanvas.CreateGraphics();

            PointF[] point =
            {
                new PointF(picCanvas.Width / 2f, picCanvas.Height/5.5f+sOuRadius),
                new PointF(picCanvas.Width/2.5f-sInRadius,picCanvas.Height/2.6f),
                new PointF(picCanvas.Width / 4f - sOuRadius,picCanvas.Height/2f),
                new PointF(picCanvas.Width/3f - sInRadius,picCanvas.Height/1.5f),
                new PointF(picCanvas.Width/3f - sOuRadius,picCanvas.Height - picCanvas.Height/8f + sOuRadius),
                new PointF(picCanvas.Width/2f,picCanvas.Height-picCanvas.Height/5+sInRadius),
                new PointF(picCanvas.Width-picCanvas.Width/3f+sOuRadius,picCanvas.Height- picCanvas.Height/8f + sOuRadius),
                new PointF(picCanvas.Width-picCanvas.Width/3f + sInRadius,picCanvas.Height/1.5f),
                new PointF(picCanvas.Width-picCanvas.Width / 4f + sOuRadius,picCanvas.Height/2f),
                new PointF(picCanvas.Width-picCanvas.Width/2.5f + sInRadius,picCanvas.Height/2.6f),
            };

            Graphics.DrawPolygon(Pen, point);

        }
    }
}
