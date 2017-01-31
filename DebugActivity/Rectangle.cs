using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugActivity
{
    class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Rectangle, color: " + shapeColor);
        }
    }
}
