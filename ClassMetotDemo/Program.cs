using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            

            Musteri musteri1 = new Musteri();
            musteri1.Id =1;
            musteri1.TC = "12345678901"; 
            musteri1.Ad = "Ahmet";
            musteri1.Soyad = "Deneme";


            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.TC = "12345678902";
            musteri2.Ad = "Mehmet";
            musteri2.Soyad = "Dağ";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.TC = "12345678903";
            musteri3.Ad = "Ömer";
            musteri3.Soyad = "Kaya";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.TC = "12345678904";
            musteri4.Ad = "Hasan";
            musteri4.Soyad = "Demir";

            Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3 };

            MusteriManager musteriManager = new MusteriManager();
           


            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.TC + " "+musteri.Ad +" "+musteri.Soyad);

            }

            musteriManager.Ekle(musteri4);
            musteriManager.Sil(musteri2);
        }
    }
}
