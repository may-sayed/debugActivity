using System;

namespace DebugActivity
{
    public class Shape
    {
       public  Color shapeColor = null;


        public virtual void draw()
        {
            Console.WriteLine("Drawing Shape");
        }

        public void fill(Color c)
        {
            shapeColor = c;
        }

    }
}
