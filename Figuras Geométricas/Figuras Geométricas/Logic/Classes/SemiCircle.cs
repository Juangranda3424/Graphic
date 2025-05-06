using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Geométricas.Logic.Classes
{
    internal class SemiCircle: Circle
    {
        public override void calculateArea(float cRadius)
        {
            float areaAux = (2 * (float)Math.PI * (float)(Math.Pow(cRadius, 2))) / 2;
            Area = areaAux / 2;
            Console.WriteLine(Area);
        }

        public override void calculatePerimeter(float cRadius)
        {
            Perimeter = (float)Math.PI * cRadius + 2 * cRadius;
        }

        public override void shapeCircle(PictureBox picCanvas)
        {
            Graphics = picCanvas.CreateGraphics();
            Graphics.DrawArc(Pen, 40, 0, 200+cRadius, 200+cRadius, 0, 180);
        }

    }
}
