using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Segitiga
    {
        public int alas;
        public int tinggi;
        public double luas;
        public double keliling;

        public int segitiga()
        {
            Console.Write("Masukkan nilai alas = ");
            alas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan nilai tinggi = ");
            tinggi = Convert.ToInt32(Console.ReadLine());
            luas = 1 / 2.0 * alas * tinggi;
            keliling = 3 * alas;
            Console.Write("Maka Luas Persegi Panjang = " + luas);
            Console.ReadLine();
            Console.Write("Maka Keliling Persegi Panjang = " + keliling);
            Console.ReadLine();
            return segitiga();
        }
    }
}
