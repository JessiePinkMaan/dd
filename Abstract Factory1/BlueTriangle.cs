using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory1
{
    public class BlueTriangle : IShape
    {
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Blue, 2);
            Point[] points = { new Point(350, 150), new Point(400, 50), new Point(450, 150) };
            g.DrawPolygon(pen, points);
        }
    }
}
