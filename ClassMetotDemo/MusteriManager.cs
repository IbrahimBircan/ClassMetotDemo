using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müsteri Eklendi !"+ musteri.TC + " " + musteri.Ad + " " + musteri.Soyad);
        }
        public void Sil(Musteri musteri)
        {
            Console.WriteLine("Müsteri Silindi !" + musteri.TC + " " + musteri.Ad + " " + musteri.Soyad);
        }
    }
}
