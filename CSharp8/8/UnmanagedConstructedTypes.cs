using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    public class UnmanagedConstructedTypes
    {
        unsafe void M()
        {
            Span<Coords<int>> coordinates = stackalloc[]
            {
                new Coords<int> { X = 0, Y = 0 },
                new Coords<int> { X = 0, Y = 3 },
                new Coords<int> { X = 4, Y = 0 }
            };
            Console.WriteLine($"{typeof(Coords<int>)} is unmanaged and its size is {sizeof(Coords<int>)} bytes");
        }

        public struct Coords<T> where T : unmanaged
        {
            public T X;
            public T Y;
        }
    }
}
