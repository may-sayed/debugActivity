using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugActivity
{
    class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Circle, color: " + shapeColor);
        }
    }
}
