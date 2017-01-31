using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugActivity
{
    class Square : Shape
    {
        public override void draw()
        {
            Console.WriteLine("Square, color: " + shapeColor);
        }
    }
}
