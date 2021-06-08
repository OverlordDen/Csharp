using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp
{
    class Program
    {
        static async void Print(List<char> sharp)
        {  
            foreach (var letter in sharp)
            {
                await Task.Factory.StartNew(() => Console.WriteLine(letter));
            }
        }
        static void Main(string[] args)
        {
            List<char> sharp = new List<char>() { 'C', 's', 'h', 'a', 'r', 'p' };
            var task = Task.Factory.StartNew(() => Print(sharp));
            Console.Read();
        }
    }
}

