using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ÇokBiçimlilik
{
    public class URUN
    {
        public string urunadi { set; get; }
        public double Fiyat {  set; get; }
        public virtual double kdvuygula()
        {
            return Fiyat*1.08;
        }
        public URUN()
        {

        }
        public URUN(string ad, double fiyat)
        {
            urunadi = ad;
            fiyat = Fiyat;
        }
    }
}

