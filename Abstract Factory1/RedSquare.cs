using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory1
{
    public class RedSquare : IShape
    {
        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Red, 2);
            g.DrawRectangle(pen, 200, 50, 100, 100);
        }
    }
}
