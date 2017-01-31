using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugActivity
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape1 = new Rectangle();
            Shape shape2 = new Square();
            Shape shape3 = new Circle();
           

            Color color1 = new Red();  
            Color color2 = new Blue();
            Color color3 = new Yellow();

            shape1.fill(color1);
            shape3.fill(color3);
           

            shape1.draw();
            shape2.draw();
          
           
        }
    }
}
