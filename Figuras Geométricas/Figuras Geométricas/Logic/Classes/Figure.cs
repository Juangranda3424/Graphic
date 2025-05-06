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
    internal class Figure
    {
        protected float Perimeter;
        protected float Area;
        protected Pen Pen;
        protected Graphics Graphics;


        public Figure()
        {
            Perimeter = 0.0f;
            Area = 0.0f;
            Pen = new Pen(Color.Red, 5);
        }

        public virtual void calculatePerimeter(float nBase)
        {


        }

        public virtual void calculatePerimeter(float nBase, float nHeight)
        {
            

        }

        public virtual void calculateArea(float nBase, float nHeight)
        {
            
        }

        public virtual void calculateArea(float nBase)
        {

        }
        public void printData(TextBox txtPerimeter, TextBox txtArea)
        {
            txtPerimeter.Text = Perimeter.ToString();
            txtArea.Text = Area.ToString();
        }


    }
}
