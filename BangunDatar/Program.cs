using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BangunDatar
    //created by faresa 27/07/2019
{
    class Program
    {
        static void Main(string[] args)
        {
        Volume:
            Console.WriteLine("Rumus Untuk Menghitung Keliling dan luas Bangun Datar");
            Console.WriteLine("1.Persegi");
            Console.WriteLine("2.Persegi panjang");
            Console.WriteLine("3.Segitiga sama sisi");
            Console.WriteLine("4.Trapesium sama sisi");
            Console.WriteLine("5.Lingkaran");
            Console.Write("Pilihlah Salah Satu Bangun Datar Di atas : ");
            int a = Convert.ToInt16(Console.ReadLine());
            switch (a)
            {
                case 1:

                    Persegi persegi1 = new Persegi();
                    persegi1.persegi();
                    Console.ReadLine();
                    
                    goto Volume;
                case 2:
                    PersegiPanjang persegi = new PersegiPanjang();
                    persegi.persegipanjang();
                    Console.ReadLine();
                    goto Volume;

                case 3:
                    Segitiga segitiga = new Segitiga();
                    segitiga.segitiga();
                    Console.ReadLine();
                    goto Volume;
                case 4:
                    Trapesium trapesi = new Trapesium();
                    trapesi.trapesium();
                    Console.ReadLine();
                    goto Volume;
                case 5:
                    Lingkaran ling = new Lingkaran();
                    ling.lingkaran();
                    Console.ReadLine();
                    goto Volume;



            }
        }
    }
}
