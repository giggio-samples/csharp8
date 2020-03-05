using System;
using System.IO;
using System.Threading.Tasks;

namespace CSharp8
{
    public class UsingDeclarations
    {
        async Task M()
        {
            await using var m = new MemoryStream();
            await using var w = new StreamWriter(m);
            w.Write("abc");
            using var r = new StreamReader(m);
            var t = await r.ReadToEndAsync();
            Console.WriteLine(t);
        } // all disposed here
    }
}
