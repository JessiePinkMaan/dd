using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory1
{
    public class RedFactory : IShapeFactory
    {
        public IShape CreateCircle()
        {
            return new RedCircle();
        }

        public IShape CreateSquare()
        {
            return new RedSquare();
        }

        public IShape CreateTriangle()
        {
            return new RedTriangle();
        }
    }
}
