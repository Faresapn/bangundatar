using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Lingkaran
    {
        public int r;
        public double phi = 3.14;
        public double luas;
        public double keliling;
        public int lingkaran()
        {
            Console.Write("Masukkan jari jari lingkaran = ");
            r = Convert.ToInt32(Console.ReadLine());

            double luas = phi * r * r;
            double keliling = 2 * phi * r;
            Console.Write("Maka Luas lingkaran = " + luas);
            Console.ReadLine();
            Console.Write("Maka Keliling lingkaran = " + keliling);
            Console.ReadLine();
            return lingkaran();
        }
    }
}
