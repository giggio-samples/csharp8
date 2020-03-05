using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static System.Console;

namespace CSharp8
{
    public class AsyncStreamAndDisposables
    {
        async Task M()
        {
            await foreach (var i in GetStream())
                WriteLine(i);
            await foreach (var i in MyIterator())
                WriteLine(i);
        }

        IAsyncEnumerable<int> GetStream() => new[] { 1, 2, 3 }.ToAsyncEnumerable();

        async IAsyncEnumerable<int> MyIterator()
        {
            for (int i = 0; i < 100; i++)
            {
                await Task.Delay(1000);
                yield return i;
            }
        }

        public class AsyncDisposableFoo : IAsyncDisposable
        {
            public async ValueTask DisposeAsync()
            {
                await Task.Delay(100);
                // ...
            }
        }

        public static async IAsyncEnumerable<Customer> GetCustomersAsync(string[] lastNames)
        {
            foreach (var lastName in lastNames)
                yield return await GetCustomerAsync(lastName);
        }

        public static Task<Customer> GetCustomerAsync(string lastName) =>
            lastName.Length < 6
            ? Task.FromResult(new Customer { LastName = lastName })
            : Task.FromResult(new Customer { FirstName = "Manoel", LastName = lastName });
    }

    public class Customer
    {
        public string? FirstName { get; internal set; }
        public string? LastName { get; internal set; }

        public void Deconstruct(out string? fn, out string? ln) =>
            (fn, ln) = (FirstName, LastName);
    }
}
