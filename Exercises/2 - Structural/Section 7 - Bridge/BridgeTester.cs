using Exercises;

namespace Exercises._2___Structural.Section_7___Bridge
{
    public class BridgeTester : BaseTester
    {
        public override void Test()
        {
            Shape triangle  = new Triangle(new VectorRenderer());
            Shape square    = new Square(new VectorRenderer());

            Console.WriteLine($"Vector rendering a {triangle.Name}: {triangle.ToString()}");
            Console.WriteLine($"Vector rendering a {square.Name}: {triangle.ToString()}");

            triangle    = new Triangle(new RasterRenderer());
            square      = new Square(new VectorRenderer());

            Console.WriteLine($"Raster rendering a {triangle.Name}: {triangle.ToString()}");
            Console.WriteLine($"Raster rendering a {square.Name}: {triangle.ToString()}");
        }
    }
}
