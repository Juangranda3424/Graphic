using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Figuras_Geométricas.Logic.Classes
{
    internal class Deltoid: Figure
    {
        protected float dSide1;
        protected float dSide2;
        protected float dMinor;
        protected float dMajor;

        public Deltoid()
        {
            dSide1 = 0.0f;
            dSide2 = 0.0f;
            dMinor = 0.0f;
            dMajor = 0.0f;
        }

        public void validationData(TextBox txtSide1, TextBox txtSide2, TextBox txtMajor, TextBox txtMinor, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {


            try
            {
                dSide1 = float.Parse(txtSide1.Text);
                dSide2 = float.Parse(txtSide2.Text);
                dMajor = float.Parse(txtMajor.Text);
                dMinor = float.Parse(txtMinor.Text);

                if (dSide2 >= dSide1||dMinor >= dMajor)
                {
                    txtSide1.Text = "";
                    txtSide2.Text = "";
                    txtMinor.Text = "";
                    txtMajor.Text = "";
                    txtPerimeter.Text = "";
                    txtArea.Text = "";
                    picCanvas.Refresh();
                    txtMajor.Focus();
                    MessageBox.Show("Error diagonal menor es mayor o el lado menor es mayor", "Error");
                }
                else
                {
                    if (dSide1 > 0 && dSide1 > 0 && dMajor > 0 && dMinor > 0)
                    {
                        calculatePerimeter(dSide1, dSide2);
                        calculateArea(dMajor, dMinor);
                        printData(txtPerimeter, txtArea);
                        shapeDeltoid(picCanvas);
                    }
                    else
                    {
                        txtSide1.Text = "";
                        txtSide2.Text = "";
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
                initializeDeltoid(txtSide1, txtSide2, txtMajor, txtMinor, txtPerimeter, txtArea, picCanvas);
            }
        }

        public override void calculateArea(float dMajor, float dMinor)
        {
            Area = (dMajor * dMinor) / 2;
        }



        public override void calculatePerimeter(float dSide1, float dSide2)
        {
            Perimeter = 2 * dSide1 + 2 * dSide2;
        }

        public void initializeDeltoid(TextBox txtSide1, TextBox txtSide2, TextBox txtMajor, TextBox txtMinor, TextBox txtPerimeter, TextBox txtArea,PictureBox picCanvas)
        {
            dSide1 = 0.0f;
            dSide2 = 0.0f;
            dMinor = 0.0f;
            dMajor = 0.0f;
            txtSide1.Text = "";
            txtSide2.Text = "";
            txtMajor.Text = "";
            txtMinor.Text = "";
            txtMajor.Focus();
            picCanvas.Refresh();
        }

        public void shapeDeltoid(PictureBox picCanvas) {

            Graphics = picCanvas.CreateGraphics();
            PointF[] point = {
                 new PointF(picCanvas.Width/2f,picCanvas.Height/8f-dSide2-dMinor),
                 new PointF(picCanvas.Width/4f-dSide2-dMinor, picCanvas.Height/3f),
                 new PointF(picCanvas.Width/2f,picCanvas.Height - picCanvas.Height/8f +dSide1 + dMajor),
                 new PointF(picCanvas.Width-picCanvas.Width/4f + dSide2+dMinor,picCanvas.Height/3f)
            };

            Graphics.DrawPolygon(Pen, point);

        }

    }
}
