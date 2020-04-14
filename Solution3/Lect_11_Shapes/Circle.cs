using System;
using System.Collections.Generic;
using System.Text;

namespace Lect_11_Shapes
{
    class Circle : Shape
    {
        int radius = 5;
        public override void SquareShape()
        {
            int SqS = radius * radius;
        }
        public override void Name()
        {
            Console.WriteLine("Circle");
        }
    }
}
