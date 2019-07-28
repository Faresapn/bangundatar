using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class PersegiPanjang
    {
        public int panjang;
        public int lebar;
        public double luas;
        public double keliling;
        public int persegipanjang()
        {
            Console.Write("Masukkan nilai panjang = ");
            panjang = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan nilai lebar = ");
            lebar = Convert.ToInt32(Console.ReadLine());
            luas = panjang * lebar;
            keliling = 2 * (panjang + lebar);
            Console.Write("Maka Luas Persegi Panjang = " + luas);
            Console.ReadLine();
            Console.Write("Maka Keliling Persegi Panjang = " + keliling);
            Console.ReadLine();
            return persegipanjang();
        }
        }
    }
