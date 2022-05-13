using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Hamburgerci
{ 
    // Bir siparişin ... özellikleri vardır.
    public class Siparis
    {
        public Menu SeciliMenu { get; set; }
        public List<Ekstra> EkstaMalzemeler { get; set; }//Sos
        //public List<Sos> Soslar { get; set; }//Sos
        public Boyut Boyutu { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }

        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenu.Fiyati;
            switch (Boyutu)
            {
                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 0.10m;
                    break;
                case Boyut.Buyuk:
                    ToplamTutar += ToplamTutar * 0.25m;
                    break; 
            }
            foreach (Ekstra ekstra in EkstaMalzemeler)
            {
                ToplamTutar += ekstra.Fiyat;
            }
            ToplamTutar = ToplamTutar * Adet;
        }
        public override string ToString()
        {
            if (EkstaMalzemeler.Count<1)
            {
                return string.Format("{0} Menu x {1} Adet, {2} Boy, Toplam: {3}", SeciliMenu.MenuAdi, Adet, Boyutu.ToString(), ToplamTutar.ToString("C2"));
            }
            else
            {
                string ekstraMalzemeler = null;
                foreach (Ekstra ekstra in EkstaMalzemeler)
                {
                    ekstraMalzemeler += ekstra.EkstraAdi + ",";
                }
                ekstraMalzemeler = ekstraMalzemeler.Trim(',');

                //Whooper Menu,1 Adet, Orta Boy, (Ketçap,Mayonez) Toplam:60 TL
                return string.Format("{0} x {1} Adet, {2} Boy,({3}) Toplam: {4}", SeciliMenu.ToString(), Adet, Boyutu.ToString(), ekstraMalzemeler, ToplamTutar.ToString("C2"));


            }
        }
    }
}
