using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CSharp8.Statuses;
using static CSharp8.Requests;

namespace CSharp8
{
    public class Patterns
    {
        public static async Task M()
        {
            var names = new[] { "a", "b", "c", "d", "e", "f" };
            IAsyncEnumerable<Customer?> customers = AsyncStreamAndDisposables.GetCustomersAsync(names);
            await foreach (Customer? customer in customers)
            {
                string? name = customer switch
                {
                    null => null,
                    (null, string ln) => $"Ms/Mr {ln}",
                    (string fn, string ln) => $"{fn[0]}. {ln}",
                    _ => "we have a problem"
                };
                if (name != null) Console.WriteLine(name);
            }
        }

        void RecursivePatterns()
        {
            object o = new Point { X = 1, Y = 2 };
            var result = o switch
            {

                int i => $"Number {i}",
                Point { X: 0, Y: 0 } => "origin", // recursive pattern: property match
                Point(int x, int y) => $"({x},{y})", // recursive patterns: deconstruction
                string s when s.Length > 0 => s,
                null => "<null>",
                _ => "<other>"
            };
        }

        void TupleMatching()
        {

            var state = Statuses.Opened;
            var request = Requests.Close;
            var resultState = (state, request) switch // tuple patterns
            {
                (Closed, Open) => Opened,
                (Closed, Lock) => Locked,
                (Opened, Close) => Closed,
                (Locked, Unlock) => Closed,
            };
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
        public void Deconstruct(out int x, out int y) => (x, y) = (X, Y);
    }
    enum Statuses { Opened, Closed, Locked }
    enum Requests { Open, Lock, Close, Unlock }
}
