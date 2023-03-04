namespace IlkProje;

using Classes;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir isim gir: ");
        String isim = Console.ReadLine();
        Console.WriteLine(isim);
        Console.WriteLine(isim.Equals("ömer"));

        String yazi = "10";

        int sayi = int.Parse(yazi);
        int sayi2 = Convert.ToInt32(yazi);
    //  ToInt16 --> short int
    //  ToInt32 --> int
    //  ToInt64 --> float
        Console.WriteLine(sayi);
        Console.WriteLine(sayi2);



        /*
        // TRY - CATCH:

        try
        {
            Console.Write("TRY CATCH deneme - Bir karakter giriniz: ");
            int sayi3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Bir hata olmadı. Çünkü sayı girdiniz.");
            
        }

        catch (FormatException)
        {
            Console.WriteLine("Format hatası oldu!");
            return;
        }
        catch (Exception)
        {
            Console.WriteLine("Herhangi bir hata oluştu!");
        }
        */


        String name = "ömer";
        String sample = $"Benim adim: {name}";
        Console.WriteLine(sample);


      /* SABİT DEĞİŞKENLER !!!  */
        const Double PI = 3.14;
        Console.WriteLine("\nBu bir değiştirilemek değişken: " + PI);







      /*  RANDOM SAYI ÜRETME !!!  */

        Random random = new Random();
        int nmbr1 = random.Next(0, 10);
        // Parantezler içerisine girilen sayılar arasında rasgele sayı üretir.
        // 0 dahil, 10 dahil değil. (0 ile 9 dahil arasında sayı üretir)
        Console.WriteLine("Rastgele üretilmiş 0 ile 9 arasındaki sayi: " + nmbr1);





        /*  DİZİLER  */

        String[] dizi = new String[5] { "Ömer", "Yusuf", "Mehmet", "İrem", "Osman" };

        for (int i = 0; i < 5; i++) {
            Console.Write(dizi[i] + " ");
        }


        /*  FOREACH  */
        Console.WriteLine("\n\nForeach ile yazim: ");
        foreach (string str in dizi)
        {
            Console.Write(str + " ");
        }



        /*  OBJECT  */

        double nmbr2 = 14.1221;
        Object objct = nmbr2;
        double nmbr3 = (double)nmbr2;
        Console.WriteLine("\nnmbr3: " + nmbr3);





        /// ÇOK ÖNEMLİ BİR NOKTA \\\
        /// ÇOK ÖNEMLİ BİR NOKTA \\\
        /// ÇOK ÖNEMLİ BİR NOKTA \\\
        /// ÇOK ÖNEMLİ BİR NOKTA \\\

        /* Herhangi bir yerdeki değişkenin referansını göndererek, 
         * o değişkeni kullanma:
         */

        int nmbr4 = 20;
        Console.WriteLine("\n\nDeğişmemiş nmbr4: " + nmbr4);
        metot1(ref nmbr4);
        Console.WriteLine("Değişmiş nmbr4: " + nmbr4);

        /* Yukarıdaki kullanımda nmbr4 değişkenini metota referans olarak gönderiyoruz ve
         * o metotta yapılan değişiklikler metodun çağırıldığı yerden itibaren her yerde uygulanır.
        DİKKAT! : ref kullanımında değer atanmamış değişken gönderilemez! (Göndermenin yolu altta)
         */



        /*  OUT KEYWORD  */

        int nmbr5;
        metot2(out nmbr5);
        Console.WriteLine("\nnmbr5: " + nmbr5);

        /* Out ile ise; atama yapılmamış bir değişkene atama yapılabilir. */





        /*  PARAMS  */
        /*  PARAMS  */
        /*  PARAMS  */
        /*  PARAMS  */

        int[] dizi2 = new int[3] { 1, 2, 3 };
        Console.WriteLine();
        Console.WriteLine(metot3(dizi2));

        /*  Eğer bu şekilde içerisinde param ile tanımlanmış değişken olan bir
         * metot varsa, bu metot'a değişken gönderilmeden de kullanılabilir.
         *  DİKKAT: bir metot'ta 1'den fazla param değişken bulunamaz.
         *  DİKKAT: param metoto en sona yazılmak zorundadır. Başta olamaz! 
         */






/*                   SINIF YAPIALRI                           */
/*                   SINIF YAPIALRI                           */
/*                   SINIF YAPIALRI                           */
/*                   SINIF YAPIALRI                           */
/*                   SINIF YAPIALRI                           */
/*                   SINIF YAPIALRI                           */
/*                   SINIF YAPIALRI                           */
/*                   SINIF YAPIALRI                           */
/*                   SINIF YAPIALRI                           */
/*                   SINIF YAPIALRI                           */






        Urun urun = new Urun();
        urun.fiyat = 10;
        urun.stok = 14;
        urun.Yazdir();

        /*urun.fiyat = 10.15;
        urun.stok = 15;
        Console.WriteLine("urun fiyati: " + urun.fiyat + " Stok miktari: " + urun.stok);
        urun.Yazdir();

        Urun urun2 = new Urun(212.213, 214);
        urun2.Yazdir();
        */


        Elma elma = new Elma();
        elma.fiyat = 15;
        elma.stok = 25;
        elma.agirlik = 33;
        elma.Yazdir();

        Elma elma1 = new Elma(23, 2124, 43);  // Elma sınıfının içerisindeki constructor çalıştı!
        elma1.Yazdir();
        
    }




    // METOTLAR:
    public static void metot1 (ref int nmbr)
    {
        nmbr += 10;
    }


    public static void metot2 (out int nmbr)
    {
        nmbr = 44;
    }


    public static int metot3 (params int[] dizi)
    {
        int result = 0;
        foreach (var item in dizi)
        {
            result += item;
        }
        return result;
    }

}

