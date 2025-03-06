using Exercises;

namespace Exercises._1___Creational.Section_4___Prototype
{
    public class PrototypeTester : BaseTester
    { 
        public override void Test()
        {
            Point start = new Point();

            start.X = 10;
            start.Y = 5;

            Point end = new Point();
            end.X = 12;
            end.Y = 10;

            Line line1 = new Line();
            line1.Start = start;
            line1.End = end;

            Line line2 = line1.DeepCopy();

            line2.End = new Point() { X = 17, Y = 15 };

            Console.WriteLine(line1.ToString());
            Console.WriteLine(line2.ToString());
        } 

        public static bool AreTwoLinesEqual(Line line1, Line line2)
        {
            return line1.Equals(line2);
        }
    }
}
