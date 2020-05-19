using System;
using System.Collections.Generic;
using System.Text;

namespace Lect_11_Shapes
{
    class Square : Shape
    {
        int storona = 4;
        public override void SquareShape()
        {
            int SqS = storona * storona;
        }
        public override void Name()
        {
            Console.WriteLine("Square");
        }
    }
}
