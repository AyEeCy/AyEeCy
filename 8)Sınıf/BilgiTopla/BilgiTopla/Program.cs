using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiTopla
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bilgiler bg = new Bilgiler();
            string isim;
            int yas, dogumtarihi;
            Console.WriteLine("İsimi giriniz:");
            isim = Console.ReadLine();
            Console.WriteLine("Yaşı giriniz:");
            yas = Convert.ToInt32(Console.ReadLine()) ;
            Console.WriteLine("Dogum tarihini giriniz:");
            dogumtarihi = Convert.ToInt32(Console.ReadLine()) ;
            bg.bilgiler(isim);
            bg.bilgiler(yas) ;
            bg.bilgiler1(dogumtarihi);
            Console.Read();

        }
    }
}
