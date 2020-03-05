using System;

namespace CSharp8
{
    public class Spans
    {
        public static void M()
        {
            Floats();
            Decimals();
        }

        static void Floats()
        {
            var floats = new[] { 1.2f, 2.4f, 3.6f, 4.8f, 6.0f };
            var slice = floats[2..]; // <--- array!
            slice[1] = 100.1f;
            Write<float>(floats);
            Write<float>(slice);
        }

        static void Decimals()
        {
            var decimals = new[] { 1.2m, 2.4m, 3.6m, 4.8m, 6.0m };
            var slice = decimals.AsSpan()[2..]; // <--- span!
            slice[1] = 100.1m;
            Write<decimal>(decimals);
            Write(slice);
        }

        public static void Write<T>(Span<T> items)
        {
            foreach (var item in items)
                Console.Write($"{item}, ");
            Console.WriteLine();
        }
    }
}
