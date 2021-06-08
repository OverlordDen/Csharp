using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp
{
    class Program
    {
        static async void Print()
        {
            List<char> sharp = new List<char>() { 'C', 's', 'h', 'a', 'r', 'p' };
            foreach (var letter in sharp)
            {
                await Task.Factory.StartNew(() => Console.WriteLine(letter));
            }
        }
        static void Main(string[] args)
        {
            Print();
            Console.Read();
        }
    }
}

