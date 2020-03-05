using System.Collections.Generic;
using System.Xml;

namespace CSharp9
{
    public class TargetTypeNew
    {
        void M()
        {
            //Dictionary<string, List<int>> field = new() { { "item1", new() { 1, 2, 3 } } };
            //XmlReader.Create(reader, new() { IgnoreWhitespace = true });
        }
    }
}
