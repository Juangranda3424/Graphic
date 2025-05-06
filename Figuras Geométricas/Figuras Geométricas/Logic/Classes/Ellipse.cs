using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Geométricas.Logic.Classes
{
    internal class Ellipse: Figure
    {
        private float eMinor;
        private float eMajor;


        public Ellipse()
        {
            eMinor = 0.0f;
            eMajor = 0.0f;
        }

        public void validationData(TextBox txtMinor, TextBox txtMajor, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            try
            {
                eMinor = float.Parse(txtMinor.Text);
                eMajor = float.Parse(txtMajor.Text);

                if (eMinor >= eMajor)
                {
                    txtMinor.Text = "";
                    txtMajor.Text = "";
                    txtMinor.Focus();
                    MessageBox.Show("Error el semieje menor es mayor o igual", "Error");
                }
                else
                {
                    if (eMinor > 0 && eMajor > 0)
                    {
                        calculatePerimeter(eMinor, eMajor);
                        calculateArea(eMinor, eMajor);
                        printData(txtPerimeter, txtArea);
                        shapeEllipse(picCanvas);
                    }
                    else
                    {
                        txtMinor.Text = "";
                        txtMajor.Text = "";
                        txtMinor.Focus();
                        MessageBox.Show("Error en la entrada de datos...", "Error");
                    }
                }


            }
            catch
            {
                MessageBox.Show("Error en la entrada de datos...", "Error");
                initializeEllipse(txtMinor, txtMajor, txtPerimeter, txtArea, picCanvas);
            }
        }

        public override void calculatePerimeter(float eMinor, float eMajor)
        {
            float H = (float)Math.Pow((eMajor - eMinor) / (eMajor + eMinor),2);
            float firstPart = (float)Math.PI * (eMinor + eMajor);
            float secondPart = 1 + ((3 * H) / (10 + (float)Math.Sqrt(4 - 3 * H)));
            float thirdPart = (4 / (float)Math.PI - 14 / 11) * (float)Math.Pow(H, 12);

            Perimeter = firstPart * (secondPart + thirdPart);
        }

        public override void calculateArea(float eMinor, float eMajor)
        {
            Area = (float)Math.PI * eMajor * eMinor;
        }

        public void initializeEllipse(TextBox txtMinor, TextBox txtMajor, TextBox txtPerimeter, TextBox txtArea, PictureBox picCanvas)
        {
            eMinor = 0;
            eMajor = 0;
            Area = 0;
            Perimeter = 0;
            txtMinor.Text = "";
            txtArea.Text = "";
            txtMajor.Text = "";
            txtPerimeter.Text = "";
            txtMinor.Focus();
            picCanvas.Refresh();

        }

        public void shapeEllipse(PictureBox picCanvas)
        {
            Graphics = picCanvas.CreateGraphics();
            Graphics.DrawEllipse(Pen, picCanvas.Width / 4, picCanvas.Height / 4,eMajor+80,eMinor+50);
        }


    }
}
