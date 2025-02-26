namespace SharedLibrary.Exercises._2___Structural.Section_6___Adapter
{
    /*
     * Here's a very synthetic example for you to try. You are given an IRectangle interface and an extension method on it. Try to define a SquareToRectangleAdapter that adapts the Square to the IRectangle interface.
    */

    public class Square
    {
        public int Side;

        public override string ToString()
        {
            return $"{nameof(Side)}: {Side}";
        }
    }

    public interface IRectangle
    {
        int Width { get; }
        int Height { get; }
    }

    public static class ExtensionMethods
    {
        public static int Area(this IRectangle rc)
        {
            return rc.Width * rc.Height;
        }
    }

    public class SquareToRectangleAdapter : IRectangle
    {
        private readonly Square square;

        public SquareToRectangleAdapter(Square square)
        {
            this.square = square;
        }

        public int Width => square.Side;

        public int Height => square.Side;

        public override string ToString()
        {
            return $"{nameof(Height)}: {Height}, {nameof(Width)}: {Width}";
        }
    }
}
