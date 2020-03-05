using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp8
{
    public class StaticLocalFn
    {
        int M()
        {
            int y = 5;
            int x = 7;
            return Add(x, y);
            static int Add(int left, int right) => left + right;
        }
    }
}
