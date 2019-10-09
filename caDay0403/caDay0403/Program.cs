using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay0403
{
    public class Program
    {
        public static void Main(string[] args)
        {

            // tampung 2 nilai integer
            Console.WriteLine("masukkan nilai panjang :");
            int panjang = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("masukkan nilai lebar :");
            int lebar = Convert.ToInt32(Console.ReadLine());
           
           
            int luas = panjang * lebar;
            Console.WriteLine("luasnya adalah ={0} ", luas);

            Console.WriteLine("Ketikkan sembarang untuk keluar");
            Console.ReadKey(true);

            Console.ReadLine();
        }
        static void 
    }
}
