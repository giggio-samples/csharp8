namespace CSharp9
{
    public class Ranges
    {
        void M()
        {
            //var slice1 = list[2..^3];               // list[Range.Create(2, Index.CreateFromEnd(3))]
            //var slice2 = list[..^3];                // list[Range.ToEnd(Index.CreateFromEnd(3))]
            //var slice3 = list[2..];                 // list[Range.FromStart(2)]
            //var slice4 = list[..];                  // list[Range.All]
            //var multiDimensional = list[1..2, ..]   // list[Range.Create(1, 2), Range.All]
        }
    }
}
