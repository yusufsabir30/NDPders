/*************************************************************************************************************************
 **                                                   SAKARYA ÜNİVERSİTESİ
 **                                             BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
 **                                              BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
 **                                             NESNEYE DAYALI PROGRAMLAMA DERSİ
 **                                             2021-2022 BAHAR DÖNEMİ
 **                                             
 **                                             ÖDEV NUMARASI:........: 1.ÖDEV
 **                                             ÖĞRENCİ ADI...........: MUHAMMAD YUSUF SABIR
 **                                             ÖĞRENCİ NUMARASI......: B211210351
 **                                             DERSİN ALINDIĞI GRUP..: 1. ÖĞRETİM B GRUBU
 ************************************************************************************************************************/
using System;
using System.Collections.Generic;
using System.Text;

namespace NDPProje1
{
    static class Karakterler
    {
        static int puan = 0;
        static int sayac = 0;
        public static void Sayi(char[] karakterler)
        {
            sayac = 0;

            if (karakterler.Length == 9)
            {
                puan += 10;
            }



            foreach (char karakter in karakterler)
            {//Karakterler dizisine atanan şifrenin içindeki sayıları bulmaya yönelik karakterler dizisinin içinde dönen döngü.
                if (char.IsNumber(karakter))
                {
                    sayac++;

                }
            }
            if (sayac == 1)
            {
                puan += 10;
            }
            else if (sayac >= 2)
            {
                puan += 20;
            }
            else
            {
                puan += 0;
            }
        }
        public static void BuyukHarfKontrol(char[] karakterler)
        {
            sayac = 0;
            foreach (char karakter in karakterler)
            {//Karakterler dizisine atanan şifrenin içindeki büyük harfleri bulmaya yönelik karakterler dizisinin içinde dönen döngü.
                if (char.IsUpper(karakter))
                {
                    sayac++;

                }
            }
            if (sayac == 1)
            {
                puan += 10;
            }
            else if (sayac >= 2)
            {
                puan += 20;
            }
            else
            {
                puan += 0;
            }
        }


        public static void KucukHarfKontrol(char[] karakterler)
        {
            sayac = 0;
            foreach (char karakter in karakterler)
            {//Karakterler dizisine atanan şifrenin içindeki küçük harfleri bulmaya yönelik karakterler dizisinin içinde dönen döngü.
                if (char.IsLower(karakter))
                {

                    sayac++;
                }

            }
            if (sayac == 1)
            {
                puan += 10;
            }
            else if (sayac >= 2)
            {
                puan += 20;
            }
            else
            {
                puan += 0;
            }
        }




        public static void SembolKontrol(char[] karakterler, int sembolBelirteci)
        {
            puan += 10 * sembolBelirteci;

            Console.WriteLine("Puan: " + puan);
        }

        public static void PuanKontrol()
        {
            if (puan < 70)
            {
                Console.WriteLine("Şifre kabul edilemez");
            }
            else if (puan >=70 && puan < 90)
            {
                Console.WriteLine("Şifre kabul edilebilir");
            }
            else
            {
                Console.WriteLine("Şifre kabul edilebilir ve güçlü");
            }
        }
    }
}
