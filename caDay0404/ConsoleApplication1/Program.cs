using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = new[] { 800, 11, 50, 771, 649, 770, 240, 9 };

            BubbleSort(input);

            Array.ForEach(input, Console.WriteLine);

            Console.ReadKey();

            Console.ReadLine();
        }
    }
}
