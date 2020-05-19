using System;
using System.Collections.Generic;
using System.Text;

namespace Lect_11_Shapes
{
    class Triangle : Shape
    {
        int storonaA = 3;
        int visota = 6;
        
        public override void SquareShape()
        {
            int SqS = (storonaA * visota) / 2;
        }
        public override void Name()
        {
            Console.WriteLine("Triangle");
        }
    }
}
