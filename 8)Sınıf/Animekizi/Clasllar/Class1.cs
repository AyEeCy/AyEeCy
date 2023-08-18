using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clasllar
{
    class AnimeKizi
    {
        public string ad;
        public string soyad;
        private int sevimlilik;
        public char durum;
        public int yas;

        public int Sev
        {
            get { return sevimlilik; }
            set { sevimlilik = Math.Abs(value); } 
        }

    }
}
