using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Csharp
{
    class Program
    {
        static AutoResetEvent waitHandler = new AutoResetEvent(true);
        static List<char> sharp = new List<char>() { 'C', 's', 'h', 'a', 'r', 'p' };
        static void Main(string[] args)
        {

            for (int i = 0; i < sharp.Count; i++)
            {
                Thread myThread = new Thread(Count);
                myThread.Name = $"{i}";
                myThread.Start(sharp[i]);
            }

            Console.ReadLine();
        }
        public static void Count(object letter)
        {
            if (Convert.ToInt32(Thread.CurrentThread.Name) > 0)
            waitHandler.WaitOne(3000, letter.ToString().StartsWith(sharp[Convert.ToInt32(Thread.CurrentThread.Name) - 1]));
            Console.WriteLine($"{Thread.CurrentThread.Name}: {letter}");
            waitHandler.Set();
        }
    }
}

