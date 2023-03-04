using System;
namespace IlkProje.Classes
{
	public class Elma : Urun
	{
		public int agirlik { get; set; }


        public Elma(double fiyat,int stok, int agirlik)
        {
            this.agirlik = agirlik;
            this.fiyat = fiyat;
            this.stok = stok;
        }

        public Elma() { } // Boş constructor!


        internal void Yazdir()
        {
            Console.WriteLine($"Fiyat: {fiyat}  Stok: {stok} Agirlik: {agirlik} ");
            Console.WriteLine("Oluşturulma zamani: " + DateTime.Now + "\n");
        }
    }
}

