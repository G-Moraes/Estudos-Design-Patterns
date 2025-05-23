﻿using Exercises;

namespace Exercises._2___Structural.Section_6___Adapter
{
    public class AdapterTester : BaseTester
    {
        public override void Test()
        {
            Square square   = new Square();
            square.Side     = 4;

            IRectangle rectangle = new SquareToRectangleAdapter(square);

            Console.WriteLine($"Square is {square.ToString()}");
            Console.WriteLine($"Rectangle is {rectangle.ToString()}");
        }
    }
}
