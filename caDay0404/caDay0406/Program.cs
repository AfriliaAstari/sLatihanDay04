using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay0406
{
    class Program
    {
        static void Main(string[] args)
        {
            // input angka atau huruf 
            // urutkan dari yang terkecil hingga terbesar
            // bubble sort

            char[] tk2 = Console.ReadLine().ToCharArray();
            Console.WriteLine(tk2.Length);
            // tk3 yang mau di ubah
            char[] tk3 = tk2;
            char[] up = new char[tk2.Length];
            int ctr = 0;

            foreach (var item in tk2)
            {
                up[ctr] = Char.ToUpper(item);
                ctr++;
            }
            char[] up2 = up;
            char tmpng;

            for (int i = 0; i < up.Length; i++)
            {
                for (int j = 0; j < up2.Length; j++)
                {
                    if (up[i] < up2[j])
                    {
                        tmpng = tk3[j];
                        tk3[j] = tk2[i];
                        tk3[i] = tmpng;

                        tmpng = up2[j];
                        up2[j] = up[i];
                        up2[i] = tmpng;

                    }
                }
            }

            foreach (var item in tk3)
            {
                Console.Write(item + " ");

                Console.ReadKey();
                Console.ReadLine();

            }

        }
    }
}
