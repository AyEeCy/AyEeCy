using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilgiTopla
{
    internal class Bilgiler
    {
        public void bilgiler(string adsoyad)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(adsoyad);

            }
        }
        public void bilgiler(int yas)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(yas);
              
            }
          
        }
        public void bilgiler1(int dogumtarihi)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(dogumtarihi);

            }
        }
    }
}
