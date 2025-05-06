using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Geométricas.Logic.Classes
{
    internal class Trapeze: Figure
    {

        protected float tMinor;
        protected float tMajor;
        protected float tSide1;
        protected float tHeight;

        public Trapeze()
        {
            tMinor = 0.0f;
            tMajor = 0.0f;
            tSide1 = 0.0f;
            tHeight = 0.0f;
        }

        public void validationData(TextBox txtMinor, TextBox txtMajor, TextBox txtSide1, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {

            try
            {
                tMinor = float.Parse(txtMinor.Text);
                tMajor = float.Parse(txtMajor.Text);
                tSide1 = float.Parse(txtSide1.Text);
                tHeight = float.Parse(txtHeight.Text);

                if (tMinor > tMajor)
                {
                    txtMinor.Text = "";
                    txtMajor.Text = "";
                    txtSide1.Text = "";                    
                    txtHeight.Text = "";
                    txtMajor.Focus();
                    MessageBox.Show("Error en la entrada de datos...", "Error");
                }
                else
                {
                    if (tMinor > 0 && tMajor > 0 && tSide1 > 0 && tHeight > 0)
                    {
                        calculatePerimeter(tMinor, tMajor, tSide1);
                        calculateArea(tMinor, tMajor, tHeight);
                        printData(txtPerimeter, txtArea);
                        shapeTrapeze(picCanvas);
                    }
                    else
                    {
                        txtMinor.Text = "";
                        txtMajor.Text = "";
                        txtSide1.Text = "";
                        txtHeight.Text = "";
                        txtMajor.Focus();
                        MessageBox.Show("Error en la entrada de datos...", "Error");
                    }
                }





            }
            catch
            {
                MessageBox.Show("Error en la entrada de datos...", "Error");
                initializeTrapeze(txtMinor,txtMajor,txtSide1,txtHeight,txtPerimeter,txtArea,picCanvas);
            }
        }

        public void calculateArea(float tMinor, float tMajor, float tHeight)
        {
            Area = ((tMajor + tMinor) * tHeight) / 2;
        }

        public void calculatePerimeter(float tMinor, float tMajor, float tSide1)
        {
            float PerimeterAux = tMinor + tMajor + 2*tSide1;
            Perimeter = PerimeterAux;
        }

        public void initializeTrapeze(TextBox txtMinor, TextBox txtMajor, TextBox txtSide1, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            tMinor = 0.0f;
            tMajor = 0.0f;
            tSide1 = 0.0f;
            tHeight = 0.0f;
            Area = 0.0f;
            Perimeter = 0.0f;
            txtMinor.Text = "";
            txtMajor.Text = "";
            txtSide1.Text = "";
            txtHeight.Text = "";
            txtMajor.Focus();
            picCanvas.Refresh();

        }

        public void shapeTrapeze(PictureBox picCanvas)
        {
            Graphics = picCanvas.CreateGraphics();
            PointF[] point =
            {
                new PointF(picCanvas.Width/6f-tMajor-tSide1, picCanvas.Height - picCanvas.Height/4f + tHeight),
                new PointF(picCanvas.Width-picCanvas.Width/6f+tMajor,picCanvas.Height - picCanvas.Height/4f + tMajor),
                new PointF(picCanvas.Width - picCanvas.Width/4f+tMajor-tSide1,picCanvas.Height/2f+tHeight),
                new PointF(picCanvas.Width/4+tSide1,picCanvas.Height/2f+tHeight)
            };

            Graphics.DrawPolygon(Pen, point);

        }

    }
}
