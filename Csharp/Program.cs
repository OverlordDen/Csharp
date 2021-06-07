using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            ParallelOptions options = new ParallelOptions();
            options.MaxDegreeOfParallelism = 1;
            var sharp = new List<string>() { "C", "s", "h", "a", "r", "p" };
            try
            {
                Parallel.For(
                        0,
                        6,
                        options,
                        (i) =>
                        {
                            Console.WriteLine("{0}", sharp[i]);
                        }
                    );
            }
            catch (AggregateException e)
            {
                Console.WriteLine("Parallel.For has thrown the following (unexpected) exception:\n{0}", e);
            }
            
        }
    }
}

