using System;
namespace IlkProje.Classes
{
	public class Urun
	{
        /*  Aşağıdakileri oluşturma kısayolu prop + Tab x 2 
         *  Aşağıdaki prop'lar java'da yaptığımız sınıf değişkenleri ile aynı.
         *  Yazım şekli farklılık göstermekte. 
         *  Bu tanımlamalarda getter ve setter yazılmıyor. Kendisi atama yapıyor.
         *  Aşağıdaki gibi 2 farklı prop kullanımı vardır!!!!:
         */


        private double _fiyat;
        internal double fiyat { get { return _fiyat; } set { _fiyat = value; } }
        internal int stok { get; set; }


        public Urun(double fiyat, int stok)
        {
            this.fiyat = fiyat;
            this.stok = stok;
        }

        public Urun()
        {
            this.fiyat = 0.0;
            this.stok = 0;
        }

        internal void Yazdir ()
        {
            if (fiyat == _fiyat) Console.WriteLine("!--> fiyat = _fiyat !!!!");
            Console.WriteLine($"Fiyat: {fiyat}  Stok: {stok}");
            Console.WriteLine("Oluşturulma zamani: " + DateTime.Now + "\n");
        }


        // Bu metot başka sınıfa miras olarak aktarılamaz (Çünkü private) !!!:
        private void Deneme ()
        {
            // Bu metot başka sınıfa miraz olarak aktarılamaz !!!
        }

    }
}

