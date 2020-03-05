using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    public class ExampleDisposableRefStruct
    {
        void M()
        {
            using var s = new MyRefStruct();
        }
    }

    public ref struct MyRefStruct
    {
        public void Dispose()
        {
        }
    }
}
