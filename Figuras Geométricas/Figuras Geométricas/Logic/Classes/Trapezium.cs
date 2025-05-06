using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Figuras_Geométricas.Logic.Figures;

namespace Figuras_Geométricas.Logic.Classes
{
    internal class Trapezium:Figure
    {

        protected float tDiagonal;
        protected float tTop;
        protected float tBottom;
        protected float tSide1;
        protected float tSide2;
        protected float tSide3;
        protected float tSide4;

        public Trapezium()
        {
            tDiagonal = 0.0f;
            tTop = 0.0f;
            tSide1 = 0.0f;
            tSide2 = 0.0f;
            tBottom = 0.0f;
            tSide3 = 0.0f;
            tSide4 = 0.0f;
        }

        public void validationData(TextBox txtDiagonal, TextBox txtTop, TextBox txtBottom, TextBox txtSide1, TextBox txtSide2, TextBox txtSide3, TextBox txtSide4, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {


            try
            {
                tDiagonal = float.Parse(txtDiagonal.Text);
                tTop = float.Parse(txtTop.Text);
                tBottom = float.Parse(txtBottom.Text);
                tSide1 = float.Parse(txtSide1.Text);
                tSide2 = float.Parse(txtSide2.Text);
                tSide3 = float.Parse(txtSide3.Text);
                tSide4 = float.Parse(txtSide4.Text);

                if (tDiagonal > 0 || tTop > 0 || tBottom > 0 || tSide1 > 0 || tSide2 > 0 || tSide3 > 0 || tSide4 > 0 )
                {
                    calculatePerimeter(tSide1, tSide2, tSide3, tSide4);
                    calculateArea(tDiagonal, tTop, tBottom);
                    printData(txtPerimeter, txtArea);
                    shapeTrapeze(picCanvas);
                }
                else
                {
                    txtDiagonal.Text = "";
                    txtTop.Text = "";
                    txtBottom.Text = "";
                    txtSide1.Text = "";
                    txtSide2.Text = "";
                    txtSide3.Text = "";
                    txtSide4.Text = "";
                    txtSide1.Focus();
                    MessageBox.Show("Error en la entrada de datos...", "Error");
                }



            }
            catch
            {
                MessageBox.Show("Error en la entrada de datos...", "Error");
                initializeTrapeze(txtDiagonal,txtTop,txtBottom,txtSide1,txtSide2,txtSide3,txtSide4,txtPerimeter,txtArea,picCanvas);
            }
        }

        public void calculateArea(float tDiagonal, float tTop, float tBottom)
        {
            float Area1 = (tDiagonal * tTop) / 2;
            float Area2 = (tDiagonal * tBottom) / 2;
            Area = Area1 + Area2;
        }

        public void calculatePerimeter(float tMinor, float tMajor, float tSide1, float tSide2)
        {
            float PerimeterAux = tMinor + tMajor + tSide1 + tSide2;
            Perimeter = PerimeterAux;
        }

        public void initializeTrapeze(TextBox txtDiagonal, TextBox txtTop, TextBox txtBottom, TextBox txtSide1, TextBox txtSide2, TextBox txtSide3, TextBox txtSide4, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            tDiagonal = 0.0f;
            tTop = 0.0f;
            tSide1 = 0.0f;
            tSide2 = 0.0f;
            tBottom = 0.0f;
            tSide3 = 0.0f;
            tSide4 = 0.0f;
            txtDiagonal.Text = "";
            txtTop.Text = "";
            txtBottom.Text = "";
            txtSide1.Text = "";
            txtSide2.Text = "";
            txtSide3.Text = "";
            txtSide4.Text = "";
            txtPerimeter.Text = "";
            txtArea.Text = "";
            txtSide1.Focus();
            picCanvas.Refresh();

        }

        public void shapeTrapeze(PictureBox picCanvas)
        {
            Graphics = picCanvas.CreateGraphics();
            PointF[] point =
            {
                new PointF(picCanvas.Width/5.5f - tSide1, picCanvas.Height - picCanvas.Height/4f + tSide1),
                new PointF(picCanvas.Width-picCanvas.Width/4f+tSide2,picCanvas.Height - picCanvas.Height/3f+ tSide2),
                new PointF(picCanvas.Width-picCanvas.Width/6f+tSide3,picCanvas.Height/3f-tSide3),
                new PointF(picCanvas.Width/4f-tSide4,picCanvas.Height/2f-tSide4)
            };

            Graphics.DrawPolygon(Pen, point);

        }
    }
}
