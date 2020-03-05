using System.Threading.Tasks;
using static System.Console;

namespace CSharp8
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Indexes.M();
            WriteLine();
            Spans.M();
            WriteLine();
            ReadOnlyMembers.M();
            WriteLine();
            NullCoalescingAssignment.M();
            WriteLine();
            StackallocInNestedExpressions.M();
            WriteLine();
            WriteLine();
        }
    }
}
