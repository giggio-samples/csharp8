using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyConsoleApp1
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var names = Names(args).ToArray();
            IAsyncEnumerable<Customer?> customers = GetCustomersAsync(names);
            await foreach (Customer? customer in customers)
            {
                string? name = customer switch
                {
                    null => null,
                    (null, string ln) => $"Ms/Mr {ln}",
                    (string fn, string ln) => $"{fn[0]}. {ln}",
                };
                if (name != null) Console.WriteLine(name);
            }
        }

        private static Span<string> Names(string[] args)
        {
            var namesCopy = new string[args.Length - 2];
            for (int i = 2; i < args.Length; i++)
                namesCopy[i - 2] = args[i];
            Span<string> argsSpan = args;
            var names = argsSpan[2..];
            names[1] = "Ottovordemgentschenfelde";
            return names;
        }

        private static async IAsyncEnumerable<Customer> GetCustomersAsync(string[] lastNames)
        {
            foreach (var lastName in lastNames)
                yield return await GetCustomerAsync(lastName);
        }


        public static Task<Customer> GetCustomerAsync(string lastName) =>
            Task.FromResult(new Customer { FirstName = "Marcos", LastName = lastName });

    }

    public class Customer
    {
        public string? FirstName { get; internal set; }
        public string? LastName { get; internal set; }

        public void Deconstruct(out string? fn, out string? ln) => (fn, ln) = (FirstName, LastName);
    }
}
