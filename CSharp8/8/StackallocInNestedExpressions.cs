using System;

namespace CSharp8
{
    public class StackallocInNestedExpressions
    {
        public static void M()
        {
            Span<int> numbers = stackalloc[] { 1, 2, 3, 4, 5, 6 };
            var ind = numbers.IndexOfAny(stackalloc[] { 2, 4, 6, 8 });
            Console.WriteLine(ind);  // 1
        }
    }
}
