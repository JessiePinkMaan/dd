using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory1
{
    public class BlueFactory : IShapeFactory
    {
        public IShape CreateCircle()
        {
            return new BlueCircle();
        }

        public IShape CreateSquare()
        {
            return new BlueSquare();
        }

        public IShape CreateTriangle()
        {
            return new BlueTriangle();
        }
    }
}
