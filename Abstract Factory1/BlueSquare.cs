using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory1
{
    public class BlueSquare : IShape
    {
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Blue, 2);
            g.DrawRectangle(pen, 200, 50, 100, 100);
        }
    }
}
