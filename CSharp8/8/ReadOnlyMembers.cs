using System;

namespace CSharp8
{
    public class ReadOnlyMembers
    {

        public static void M()
        {
            var p = new ROMPoint { X = 1, Y = 2 };
            Console.WriteLine(p);
        }
    }

    public struct ROMPoint
    {
        public double X { get; set; }
        public double Y { get; set; }
        public readonly double Distance => Math.Sqrt(X * X + Y * Y);
        public readonly override string ToString() => $"({X}, {Y}) is {Distance} from the origin";
    }
}
