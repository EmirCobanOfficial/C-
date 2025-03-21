using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÇokBiçimlilik
{
    public class Sepet
    {
        private List<URUN> urunler=new List<URUN>(); //ürünler adında bir değişken olusturdum.
        public double toplamtutar() // public bir değer
        {
            double toplamfiyat = 0;
            foreach (URUN item in urunler) // döngü çalıştığı sürece her eklediği ürüne kdv uygulayacak
            {
                toplamfiyat += item.kdvuygula();
            }
            return toplamfiyat; // toplamfiyatı geri döndür
        }
        public void Urunekle(URUN yeniurun)
        {
            urunler.Add(yeniurun);
        }
    }
}
