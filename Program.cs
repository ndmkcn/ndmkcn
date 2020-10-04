using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Akaryakitsatisprojesi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Başlık ve renklendirme;
            Console.Title = "*** Opet Satış Uygulaması ***";
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("\n\n\n\n\n\n\n\n                             Opet'e Hoşgeldiniz");
            Console.Write("\n\n                           Menü İçin Enter'a Basın");
            Console.Write("\n\n                              *** ndmkcn ***");
            Console.ReadLine();

            //değişken tanımlamaları;

            double dizel = 6.27, benzin = 6.98, lpg = 3.99;
            double dizeltank = 5000, benzintank = 5000, lpgtank = 5000;
            double satismiktari = 0;
            char anamenusecim = '0', altmenusecim = '0', akaryakitfiyatguncelle = '0', akaryakitsatistipi = '0', depodurumu = '0', satislar = '0';
            //ana menü oluşturma;
            ANAMENU:
            Console.Clear();
            Console.WriteLine("\n\n\n                         Akaryakıt Satış Takip");
            Console.Write("\n\n                         *********************");
            Console.Write("\n\n                         1-Birim Fiyatı Göster");
            Console.Write("\n\n                         2-Birim Fiyat Güncelle");
            Console.Write("\n\n                         3-Akaryakıt Satışı Yap");
            Console.Write("\n\n                         4-Depo Durumunu Goster");
            Console.Write("\n\n                         5-Toplam Satışları Göster");
            Console.Write("\n\n                         6-Çıkış Yap");

            Console.Write("\n\n                         Seçim Yap [1,2,3,4,5,6]: ");
            anamenusecim = Convert.ToChar(Console.ReadLine());
            //Seçim 1;
            if (anamenusecim == '1')
            {
                Console.Clear();
                Console.Write("\n\n\n\n                       *** Birim Fiyatlar Listesi ***");
                Console.Write("\n\n\n                            Dizel: {0}TL/Litre", dizel);
                Console.Write("\n\n                           Benzin: {0}TL/Litre", benzin);
                Console.Write("\n\n                              Lpg: {0}TL/Litre", lpg);
                Console.Write("\n\n                              1-Ana Menü");
                Console.Write("\n\n                              Seçim Yap [1]: ");
                altmenusecim = Convert.ToChar(Console.ReadLine());
                if (altmenusecim == '1')
                {
                    Console.Clear();
                    goto ANAMENU;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("\n\n\n\n\n\n\n\n\n\n                           Hatalı Seçim Yaptınız !");
                    Console.ReadLine();
                    goto ANAMENU;
                }
            }

            //Seçim 2;
            else if (anamenusecim == '2')
            {
                AKARYAKİTTİPİSEC:
                Console.Clear();
                Console.Write("\n\n\n\n\n                         *** Birim Fiyat Güncelle ***");
                Console.Write("\n\n                              *** Ürünler ***");
                Console.Write("\n\n\n                                  1-Dizel\n\n                                  2-Benzin\n\n                                  3-Lpg\n\n                                  4-Ana Menü");
                Console.Write("\n\n\n                             Seçim Yap:[1,2,3,4] ");
                akaryakitfiyatguncelle = Convert.ToChar(Console.ReadLine());
                if (akaryakitfiyatguncelle == '1')
                {
                    Console.Clear();
                    Console.Write("\n\n\n\n\n\n\n\n                              Dizel: {0}TL/Litre", dizel);
                    Console.Write("\n\n                               Dizel Yeni Fiyat: ");
                    dizel = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\n\n                               Fiyat Kaydedildi");
                    Console.Write("\n\n                              Kayıtlı Yeni Fiyat: {0}", dizel);
                    Console.ReadLine();
                    goto AKARYAKİTTİPİSEC;
                }
                else if (akaryakitfiyatguncelle == '2')
                {
                    Console.Clear();
                    Console.Write("\n\n\n\n\n\n\n\n                              Benzin: {0}TL/Litre", benzin);
                    Console.Write("\n\n                               Benzin Yeni Fiyat: ");
                    benzin = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\n\n                               Fiyat Kaydedildi");
                    Console.Write("\n\n                              Kayıtlı Yeni Fiyat: {0}", benzin);
                    Console.ReadLine();
                    goto AKARYAKİTTİPİSEC;
                }
                else if (akaryakitfiyatguncelle == '3')
                {
                    Console.Clear();
                    Console.Write("\n\n\n\n\n\n\n\n                              Lpg: {0}TL/Litre", lpg);
                    Console.Write("\n\n                               Lpg Yeni Fiyat: ");
                    lpg = Convert.ToDouble(Console.ReadLine());
                    Console.Write("\n\n                               Fiyat Kaydedildi");
                    Console.Write("\n\n                              Kayıtlı Yeni Fiyat: {0}", lpg);
                    Console.ReadLine();
                    goto AKARYAKİTTİPİSEC;
                }
                else if (akaryakitfiyatguncelle == '4')
                {
                    Console.Clear();
                    goto ANAMENU;
                }
                else
                {
                    Console.Clear();
                    Console.Write("\n\n\n\n\n\n\n\n                              Hatalı Seçim Yaptınız !");
                    Console.Write("\n\n                               Tekrar Seçim Yapınız");
                    Console.ReadLine();
                    goto AKARYAKİTTİPİSEC;
                }
            }
            //Seçim 3;
            else if (anamenusecim == '3')
            {
                SATİSTİPİSEC:
                Console.Clear();
                Console.Write("\n\n\n\n\n                             *** Akaryakıt Satış Yap ***");
                Console.Write("\n\n                                    Ürünler");
                Console.Write("\n\n                                    1-Dizel");
                Console.Write("\n\n                                    2-Benzin");
                Console.Write("\n\n                                    3-Lpg");
                Console.Write("\n\n                                    4-Ana Menü");
                Console.Write("\n\n                               Seçim Yap:[1,2,3,4]: ");
                akaryakitsatistipi = Convert.ToChar(Console.ReadLine());
                if (akaryakitsatistipi == '1')
                {
                    Console.Clear();
                    if (dizeltank == 0)
                    {
                        Console.Clear();
                        Console.Write("\n\n\n\n\n\n\n\n                          Yakıt Tankında Dizel Yakıt Kalmamıştır");
                        Console.ReadLine();
                        goto SATİSTİPİSEC;
                    }
                    else
                    {
                        Console.Write("\n\n\n\n\n\n                         Kaç Litre Yakıt Alacaksınız: ");
                        satismiktari = Convert.ToDouble(Console.ReadLine());
                        if (dizeltank < satismiktari)
                        {
                            Console.Clear();
                            Console.Write("\n\n\n\n\n\n\n\n           Yakıt Tankında {0} Litre Dizel Yakıt vardır İşlem Yapılamadı!", dizeltank);
                            Console.ReadLine();
                            goto SATİSTİPİSEC;
                        }
                        else if (satismiktari <= dizeltank)
                        {
                            dizeltank = dizeltank - satismiktari;
                            Console.Write("\n\n                             Yakıt Dolumu Tamamlanmıştır");
                            Console.Write("\n\n                      Yakıt Tankında {0} Litre Dizel Yakıt Kaldı", dizeltank);
                            Console.ReadLine();
                        }
                        goto SATİSTİPİSEC;
                    }
                }
                if (akaryakitsatistipi == '2')
                {
                    Console.Clear();
                    if (benzintank == 0)
                    {
                        Console.Clear();
                        Console.Write("\n\n\n\n\n\n\n\n                          Yakıt Tankında Benzin Yakıt Kalmamıştır");
                        Console.ReadLine();
                        goto SATİSTİPİSEC;
                    }
                    else
                    {
                        Console.Clear();
                        Console.Write("\n\n\n\n\n\n                         Kaç Litre Yakıt Alacaksınız: ");
                        satismiktari = Convert.ToDouble(Console.ReadLine());
                        if (benzintank < satismiktari)
                        {
                            Console.Clear();
                            Console.Write("\n\n\n\n\n\n\n\n           Yakıt Tankında {0} Litre Benzin Yakıt vardır İşlem Yapılamadı!", benzintank);
                            Console.ReadLine();
                            goto SATİSTİPİSEC;
                        }
                        else if (satismiktari <= benzintank)
                        {
                            benzintank = benzintank - satismiktari;
                            Console.Write("\n\n                             Yakıt Dolumu Tamamlanmıştır");
                            Console.Write("\n\n                      Yakıt Tankında {0} Litre Benzin Yakıt Kaldı", benzintank);
                            Console.ReadLine();
                            goto SATİSTİPİSEC;
                        }
                    }
                }
                if (akaryakitsatistipi == '3')
                {
                    Console.Clear();
                    if (lpgtank == 0)
                    {
                        Console.Clear();
                        Console.Write("\n\n\n\n\n\n\n\n                          Yakıt Tankında Lpg Yakıt Kalmamıştır");
                        Console.ReadLine();
                        goto SATİSTİPİSEC;
                    }
                    else
                    {
                        Console.Write("\n\n\n\n\n\n                         Kaç Litre Yakıt Alacaksınız: ");
                        satismiktari = Convert.ToDouble(Console.ReadLine());
                        if (dizeltank < satismiktari)
                        {
                            Console.Clear();
                            Console.Write("\n\n\n\n\n\n\n\n           Yakıt Tankında {0} Litre Lpg Yakıt vardır İşlem Yapılamadı!", lpgtank);
                            Console.ReadLine();
                            goto SATİSTİPİSEC;
                        }
                        else if (satismiktari <= lpgtank)
                        {
                            lpgtank = lpgtank - satismiktari;
                            Console.Write("\n\n                             Yakıt Dolumu Tamamlanmıştır");
                            Console.Write("\n\n                      Yakıt Tankında {0} Litre Lpg Yakıt Kaldı", lpgtank);
                            Console.ReadLine();
                            goto SATİSTİPİSEC;
                        }
                    }
                }
                if (akaryakitsatistipi == '4')
                {
                    Console.Clear();
                    goto ANAMENU;
                }
                else
                {
                    Console.Clear();
                    Console.Write("\n\n\n\n\n\n\n\n                              Hatalı Seçim Yaptınız !");
                    Console.Write("\n\n                               Tekrar Seçim Yapınız");
                    Console.ReadLine();
                    goto SATİSTİPİSEC;
                }
            }
            //Sseçim 4;
            else if (anamenusecim == '4')
            {
                DEPODURUMU:
                Console.Clear();
                Console.Write("\n\n\n\n                             *** Depo Durumu ***");
                Console.Write("\n\n                                   Ürünler");
                Console.Write("\n\n                         Dizel Yakıt Tankı %{0} Doludur", (dizeltank / 50));
                Console.Write("\n\n                        Benzin Yakıt Tankı %{0} Doludur", (benzintank / 50));
                Console.Write("\n\n                           Lpg Yakıt Tankı %{0} Doludur", (lpgtank / 50));
                Console.Write("\n\n                               1-Ana Menü");
                Console.Write("\n\n                               Seçim Yap:[1]");
                depodurumu = Convert.ToChar(Console.ReadLine());
                if (depodurumu == '1')
                {
                    Console.Clear();
                    goto ANAMENU;
                }
                else
                {
                    Console.Clear();
                    Console.Write("\n\n\n\n\n\n\n\n                              Hatalı Seçim Yaptınız !");
                    Console.Write("\n\n                               Tekrar Seçim Yapınız");
                    Console.ReadLine();
                    goto DEPODURUMU;
                }
            }
            //Sseçim 5;
            else if (anamenusecim == '5')
            {
                SATISLAR:
                Console.Clear();
                Console.Write("\n                         *** Toplam Satışlar ***");
                Console.Write("\n\n                                Ürünler");
                Console.Write("\n\n                         Dizel Yakıt Satışı: {0} Litre", 5000 - dizeltank);
                Console.Write("\n\n                   Dizel Yakıt Satış Tutarı: {0} TL", (5000 - dizeltank) * dizel);
                Console.Write("\n\n                        Benzin Yakıt Satışı: {0} Litre", 5000 - benzintank);
                Console.Write("\n\n                  Benzin Yakıt Satış Tutarı: {0} TL", (5000 - benzintank) * benzin);
                Console.Write("\n\n                           Lpg Yakıt Satışı: {0} Litre", 5000 - lpgtank);
                Console.Write("\n\n                     Lpg Yakıt Satış Tutarı: {0} TL", (5000 - lpgtank) * lpg);
                Console.Write("\n\n                         ************************");
                Console.Write("\n\n                 Toplam Yakıt Satışı Tutarı: {0} TL", ((5000 - dizeltank) * dizel) + ((5000 - benzintank) * benzin) + ((5000 - lpgtank) * lpg));
                Console.Write("\n\n                              1-Ana Menü");
                Console.Write("\n\n                              Seçim Yap:[1]");
                satislar = Convert.ToChar(Console.ReadLine());
                if (satislar == '1')
                {
                    Console.Clear();
                    goto ANAMENU;
                }
                else
                {
                    Console.Clear();
                    Console.Write("\n\n\n\n\n\n\n\n                              Hatalı Seçim Yaptınız !");
                    Console.Write("\n\n                               Tekrar Seçim Yapınız");
                    Console.ReadLine();
                    goto SATISLAR;
                }
            }
            //Seçim 6;
            if (anamenusecim == '6')
            {
                Environment.Exit(0);
            }
            else
            {
                Console.Clear();
                Console.Write("\n\n\n\n\n\n\n\n                              Hatalı Seçim Yaptınız !");
                Console.Write("\n\n                               Tekrar Seçim Yapınız");
                Console.ReadLine();
                goto ANAMENU;
            }
                Console.ReadKey();
        }
    }
}
