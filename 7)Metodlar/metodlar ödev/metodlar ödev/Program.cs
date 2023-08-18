using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodlar_ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string yazi;
            int sayi,sayi2;

            Console.WriteLine("Ad, Soyad, Doğduğu Şehir ve Mesleğini giriniz;");
            yazi = Console.ReadLine();
            Console.WriteLine("Yaşı Giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Doğum Tarihini Giriniz:");
            sayi2 = Convert.ToInt32(Console.ReadLine());

            Bilgiler bgl = new Bilgiler(yazi+" "+sayi+" "+sayi2);
            Console.Read();
        }
    }
}
