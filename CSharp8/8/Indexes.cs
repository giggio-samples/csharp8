using System;
using static System.Console;

namespace CSharp8
{
    public class Indexes
    {
        public static void M()
        {
            var list = new[] { 1, 2, 3, 4 };
            var ultimoItem = list[^1];          // list[Index.FromEnd(1)]
            WriteLine(ultimoItem);
            var penultimoItem = list[^2];       // list[Index.FromEnd(2)]
            WriteLine(penultimoItem);
            var copia = list[..];
            Write<int>(copia);
            var doisDoMeio = list[1..^1]; // começo: inclusivo | final: exclusivo
            Write<int>(doisDoMeio);
            var primeiros3 = list[..3];
            Write<int>(primeiros3);
            var ultimos3 = list[^3..];
            Write<int>(ultimos3);
        }
        public static void Write<T>(Span<T> items)
        {
            foreach (var item in items)
                Console.Write($"{item}, ");
            Console.WriteLine();
        }
    }
}
