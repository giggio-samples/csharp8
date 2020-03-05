using System;
using static System.Console;
using System.Collections.Generic;

namespace CSharp8
{
    public class NullCoalescingAssignment
    {
        public static void M()
        {
            List<int>? numbers = null;
            int? i = null;
            numbers ??= new List<int>();
            numbers.Add(i ??= 17);
            numbers.Add(i ??= 20);
            WriteLine(string.Join(" ", numbers)); // 17 17
            WriteLine(i); // 17
        }
    }
}
