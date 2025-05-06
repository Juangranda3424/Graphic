using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Geométricas.Logic.Classes
{
    internal class Triangle: Figure
    {
        protected float tHeight;
        protected float tBase;


        public Triangle()
        {
            tBase = 0.0f;
            tHeight = 0.0f;


        }

        public void validationData(TextBox txtHeight, TextBox txtBase, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            try
            {
                tBase = float.Parse(txtBase.Text);
                tHeight = float.Parse(txtHeight.Text);

                if (tBase > 0 && tHeight > 0)
                {
                    calculatePerimeter(tBase);
                    calculateArea(tBase, tHeight);
                    printData(txtPerimeter, txtArea);
                    shapeTriangle(picCanvas);
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
                initializeTriangle(txtBase, txtHeight, txtPerimeter, txtArea, picCanvas);
            }
        }

        public override void calculatePerimeter(float nBase)
        {
            Perimeter = nBase * 3;

        }

        public override void calculateArea(float nBase, float nHeight)
        {
            Area = (nBase * nHeight) / 2;
        }

        public void initializeTriangle(TextBox txtBase, TextBox txtHeight, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            tBase = 0;
            tHeight = 0;
            Area = 0;
            Perimeter = 0;
            txtBase.Text = "";
            txtArea.Text = "";
            txtHeight.Text = "";
            txtPerimeter.Text = "";
            txtBase.Focus();
            picCanvas.Refresh();
            
        }

        public virtual void shapeTriangle(PictureBox picCanvas)
        {
            Graphics = picCanvas.CreateGraphics();

            PointF[] point =
            {
                new PointF(picCanvas.Width / 4f -tBase,picCanvas.Height - picCanvas.Height/4f),
                new PointF(picCanvas.Width - picCanvas.Width/4f + tBase,picCanvas.Height - picCanvas.Height/4f),
                new PointF(picCanvas.Width/2f,picCanvas.Height/4f-tHeight)
            };

            Graphics.DrawPolygon(Pen, point);

        }

    }
}
