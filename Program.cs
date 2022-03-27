/*************************************************************************************************************************
 **                                                   SAKARYA ÜNİVERSİTESİ
 **                                        BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
 **                                              BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
 **                                             NESNEYE DAYALI PROGRAMLAMA DERSİ
 **                                                 2021-2022 BAHAR DÖNEMİ
 **                                             
 **                                             ÖDEV NUMARASI:........: 1.ÖDEV
 **                                             ÖĞRENCİ ADI...........: MUHAMMAD YUSUF SABIR
 **                                             ÖĞRENCİ NUMARASI......: B211210351
 **                                             DERSİN ALINDIĞI GRUP..: 1. ÖĞRETİM B GRUBU
 ************************************************************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace ConsoleApp2
{
    class Program
    {
        private static string sifre;
        private static bool sembol;
        private static bool number;
        private static bool bh;
        private static bool kh;
        private static bool kontrol;

        static void Main(string[] args)
        {
            char[] karakterler;
            var regex = new Regex(@"\s");
            List<char> buyukHarf = "ABCÇDEFGĞHIİJKLMNOÖPQRSŞTUÜVWXYZ".ToCharArray().ToList();
            List<char> kucukHarf = "ABCÇDEFGĞHIİJKLMNOÖPQRSŞTUÜVWXYZ".ToLower().ToCharArray().ToList();
            List<char> sayi = "0123456789".ToCharArray().ToList();
            int sembolBelirteci = 0;            

            do
            {
                bh = true;
                kh = true;
                number = true;
                sembol = true;
                kontrol = false;

                Console.WriteLine("Lütfen şifrenizi giriniz: ");
                sifre = Console.ReadLine();
                karakterler = sifre.ToCharArray();
                if (regex.IsMatch(sifre))
                {//Boşluk bırakıldığında kodun çalışmasını engelleyen internetten araştırıp bulduğum regex fonksiyonu.
                    Console.WriteLine("Lütfen boşluk bırakmayınız");
                }

                int sayac = 0;
                int sayiSayaci = 0;
                int buyukHarfSayaci = 0;
                int kucukHarfSayaci = 0;

                for (int i = 0; i < karakterler.Length; i++)
                {//Karakter sayılarını bulmak için, karakter dizisi (şifre boyutu) uzunluğu kadar dönen for döngüsü.
                    foreach (var item in buyukHarf)
                    {//Dönen büyük harf sayısını bulmak için şifreyi atadığımız karakterler dizisinin içinde dönüyor.
                        if (karakterler[i] == item)
                        {
                            buyukHarfSayaci++;
                            sayac++;
                            bh = false;
                            

                        }
                    }

                    foreach (var item in kucukHarf)
                    {//Dönen küçük harf sayısını bulmak için şifreyi atadığımız karakterler dizisinin içinde dönüyor.
                        if (karakterler[i] == item)
                        {
                            kucukHarfSayaci++;
                            sayac++;
                            kh = false;
                            

                        }
                    }

                    foreach (var item in sayi)
                    {// Dönen rakam sayısını bulmak için şifreyi atadığımız karakterler dizisinin içinde dönüyor.
                        if (karakterler[i] == item)
                        {
                            sayiSayaci++;
                            sayac++;
                            number = false;
                            
                        }
                    }

                    if ((karakterler.Length - sayac != 0) && i == karakterler.Length - 1)
                    {// sembol sayısını diğer karakterler - sayaç şeklinde bulduğum için sembol sayısını buluyor bu koşul.
                        sembol = false;
                        Console.WriteLine("Karakter Sayısı: " + karakterler.Length);
                        sembolBelirteci = karakterler.Length - sayac;
                        Console.WriteLine("Sembol sayısı: " + sembolBelirteci);
                        Console.WriteLine("Büyük harf sayısı: " + buyukHarfSayaci);
                        Console.WriteLine("Küçük harf sayısı: " + kucukHarfSayaci);
                        Console.WriteLine("Rakam sayısı: " + sayiSayaci);
                    }
                }
                if (regex.IsMatch(sifre) || sifre.Length < 9)
                {// şifrenin boyutunun 9 dan küçük olduğunda kodun çalışmaması için internetten araştırıp bulduğum regex fonksiyonu.
                    kontrol = true;
                    Console.WriteLine("Karakter sayısı 9'dan büyük olmalı!");
                }
            }
            while (kontrol || sembol || number || bh || kh);

            NDPProje1.Karakterler.BuyukHarfKontrol(karakterler);
            NDPProje1.Karakterler.KucukHarfKontrol(karakterler);
            NDPProje1.Karakterler.Sayi(karakterler);
            NDPProje1.Karakterler.SembolKontrol(karakterler, sembolBelirteci);
            NDPProje1.Karakterler.PuanKontrol();

            
        }
    }
}
