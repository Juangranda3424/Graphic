using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Figuras_Geométricas.Logic.Classes
{
    internal class Rhomboid:Rectangle
    {
        public override void shapeRectangle(PictureBox picCanvas)
        {
            Graphics = picCanvas.CreateGraphics();

            PointF[] point =
            {
                new PointF(picCanvas.Width/3f-rBase,picCanvas.Height/3-rHeight),
                new PointF(picCanvas.Width/6f-rBase,picCanvas.Height - picCanvas.Height/3f+rHeight),
                new PointF(picCanvas.Width - picCanvas.Width/3f +rBase, picCanvas.Height - picCanvas.Height/3f+rHeight),
                new PointF(picCanvas.Width-picCanvas.Width/6f+rBase, picCanvas.Height/3f-rHeight)
            };

            Graphics.DrawPolygon(Pen, point);
        }
    }
}
