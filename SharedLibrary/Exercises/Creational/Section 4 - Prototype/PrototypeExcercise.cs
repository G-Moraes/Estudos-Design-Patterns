namespace Estudo_Design_Patterns.Exercises.Section_4____Prototype
{
    public interface ICopyable<T>
    {
        T DeepCopy();
    }

    public class Point : ICopyable<Point>
    {
        public int X, Y;

        public Point()
        {
            
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return new string($"X: {X}, Y:{Y}");
        }

        public Point DeepCopy()
        {
            return new Point(X, Y);
        }
    }

    public class Line : ICopyable<Line>
    {
        public Point Start, End;

        public Line()
        {
            
        }

        public Line(Point start, Point end)
        {
            Start   = start;
            End     = end;
        }

        public Line DeepCopy()
        {
            return new Line(Start.DeepCopy(), End.DeepCopy());
        }

        public override string ToString()
        {
            return new string($"Start: {Start.ToString()}, End: {End.ToString()}");
        }
    }
}
