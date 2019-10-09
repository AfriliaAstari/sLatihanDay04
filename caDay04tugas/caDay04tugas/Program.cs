using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay04tugas
{
    public class Program
    {
       public static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string[] pemisah = { " " };

            string[] pecah = name.Split(pemisah, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(name);

            foreach (string item in pecah)
            {
                int i = item.Length;
                Console.WriteLine("*" + item.Substring(1, i - 2) + "*"); 
            }

            Console.ReadLine();
        }
    }
}
