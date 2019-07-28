using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
{
    class Trapesium {

        public int atas;
        public int bawah;
        public int tinggi;
        public double luas;
       
        public double keliling;

        public int trapesium()
        {
            Console.Write("Masukkan nilai sisi sejajar atas = ");
            atas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan nilai sisi sejajar bawah = ");
            bawah = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan nilai tinggi = ");
            tinggi = Convert.ToInt32(Console.ReadLine());
            luas = 1 / 2.0 * (atas + bawah) * tinggi;
            keliling =  2*(atas - bawah) + (atas + bawah );
           
            Console.Write("Maka Luas Persegi Panjang = " + luas);
            Console.ReadLine();
            Console.Write("Maka Keliling Persegi Panjang = " + keliling);
            Console.ReadLine();
            
            return trapesium();
          
        }
    }
}
