using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Ad = "öznur";
            musteri1.Soyad = "soyad1";
            musteri1.Id = 100000;
            musteri1.Yas = 22;

            Musteri musteri2 = new Musteri();
            musteri2.Ad = "gizem";
            musteri2.Soyad = "soyad2";
            musteri2.Id = 200000;
            musteri2.Yas = 23;

            Musteri musteri3 = new Musteri();
            musteri3.Ad = "onur";
            musteri3.Soyad = "soyad3";
            musteri3.Id = 300000;
            musteri3.Yas = 35;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };
            //foreach (Musteri musteri in musteriler)
            //{
            //    Console.WriteLine(musteri.Id);
            //    Console.WriteLine(musteri.Ad);
            //    Console.WriteLine(musteri.Soyad);
            //    Console.WriteLine(musteri.Yas);
            //}

            MusteriManager customer = new MusteriManager();
            customer.Add(musteri1);
            customer.Delete(musteri2);
            customer.List(musteriler);


        }
    }

}
